using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;

namespace VirtualMemory_PageReplacement_OS7
{
    public class ReferencedChangedEventArgs
    {
        private int _page;
        private int _pageFrame;
        private int _physicalAddress;

        public ReferencedChangedEventArgs(int page, int pageFrame, int physicalAddress)
        {
            _page = page;
            _pageFrame = pageFrame;
            _physicalAddress = physicalAddress;
        }

        public int Page
        {
            get
            {
                return _page;
            }
        }

        public int PageFrame
        {
            get
            {
                return _pageFrame;
            }
        }

        public int PhysicalAddress
        {
            get
            {
                return _physicalAddress;
            }
        }
    }

    public enum DISK_STATUS
    {
        LOADED,
        TAKEN,
        UPDATED
    }

    public delegate void ReferencedChangedHandler(Object sender, ReferencedChangedEventArgs args);
    internal class MemoryManagementUnit
    {
        private const int PAGE_ADDRESS_COUNT = 4096;
        private const int WORKING_SET_TIME = 15;
        private const int PAGE_SIZE = 4;
        private ALGORITHM_TYPE _algorithmType;
        private int _memoryPagesNumber;
        private Process _process;
        private List<Page> _pages;
        private Swapper _swapper;
        private Queue<int> FIFOQueue;

        private System.Timers.Timer _timer;

        public event ReferencedChangedHandler ReferencedChanged;
        public event EventHandler PageTableChanged;

        public MemoryManagementUnit(int size, ALGORITHM_TYPE type)
        {
            _algorithmType = type;
            _memoryPagesNumber = size / PAGE_SIZE;
            _swapper = new Swapper();
        }

        public List<Page> PageTable
        {
            get
            {
                return _pages;
            }
        }

        public Dictionary<int, DISK_STATUS> PagesOnDiskTable
        {
            get
            {
                return _swapper.Table;
            }
        }

        public Process Process
        {
            get
            {
                return _process;
            }
        }

        public Queue<int> Queue
        {
            get
            {
                return FIFOQueue;
            }
        }

        public void SetProcess(Process process)
        {
            _process = process;
            _process.ReferencedToAddress += HandleProcessReferencedToAddress;
            InitializePageTable(process.Size);
            _timer = new System.Timers.Timer(15000);
            _timer.Elapsed += HandleTimerElapsed;
            _timer.Start();
        }

        private void InitializePageTable(short processSize)
        {
            FIFOQueue = new Queue<int>();
            int pageNumber = processSize / PAGE_SIZE;
            _pages = new List<Page>();

            for(int i=0; i < pageNumber; i++)
            {
                _swapper.UploadToDisk(i);
            }

            int counter = 0;

            for(int i=0; i < pageNumber; i++)
            {
                if(counter < _memoryPagesNumber)
                {
                    _pages.Add(new Page(true, false, false, i));
                    if(_algorithmType == ALGORITHM_TYPE.FIFO)FIFOQueue.Enqueue(i);
                    counter++;
                }
                else
                {
                    _pages.Add(new Page());
                }
            }
        }


        private void HandleProcessReferencedToAddress(Object sender, ReferencedToAddressEventArgs e)
        {
            int pageNumber = e.ReferredAddress / PAGE_ADDRESS_COUNT;
            Page page = _pages[pageNumber];

            if(!page.IsPresent)
            {
                if (_algorithmType == ALGORITHM_TYPE.WSCIock)
                {

                    WSCIockAlgorithm(pageNumber, e.AddressingType);
                }
                else
                {
                    int deletedPage = FIFOQueue.Dequeue();

                    DeletePage(deletedPage);
                    if (_pages[deletedPage].IsModified)
                    {
                        _swapper.UpdatePageOnDisk(deletedPage);
                        _pages[deletedPage].IsModified = false;
                    }

                    AddPage(pageNumber, deletedPage, e.AddressingType);
                    FIFOQueue.Enqueue(pageNumber);
                }
            }
            else
            {
                if (e.AddressingType == ADDRESSING_TYPE.MODIFYING)
                {
                    page.IsModified = true;
                    page.Modify();
                }
                page.IsReferenced = true;
                page.Refer();
            }

            int pageFrameNumber = (int)page.PageFrameNumber;
            int physicalAddress = pageFrameNumber * PAGE_ADDRESS_COUNT + e.ReferredAddress % PAGE_ADDRESS_COUNT;
            InvokeReferencedChanged(pageNumber, pageFrameNumber, physicalAddress);

            InvokePageTableChanged();
        }

        private void DeletePage(int index)
        {
            _pages[index].IsPresent = false;
            _pages[index].PageFrameNumber = null;
        }

        private void AddPage(int index, int frameIndex, ADDRESSING_TYPE type)
        {
            _swapper.getPageFromDisk(index);
            _pages[index].PageFrameNumber = frameIndex;
            _pages[index].IsPresent = true;

            if (type == ADDRESSING_TYPE.MODIFYING)
            {
                _pages[index].IsModified = true;
                _pages[index].Modify();
            }
            _pages[index].IsReferenced = true;
            _pages[index].Refer();
        }

        private void WSCIockAlgorithm(int pageNumber, ADDRESSING_TYPE type)
        {
            int index = 0;
            int max = _pages[0].PageAge;
            for(int i=1; i < _pages.Count; i++)
            {
                if (_pages[i].IsPresent && _pages[i].PageAge > max) index = i;
            }

            do
            {
                if (_pages[index].IsReferenced)
                {
                    _pages[index].IsReferenced = false;
                    if (index == _pages.Count - 1) index = 0;
                    else index++;
                }
                else
                {
                    if (_pages[index].IsModified)
                    {
                        _swapper.UpdatePageOnDisk(index);
                        _pages[index].IsModified = false;
                        if (index == _pages.Count - 1) index = 0;
                        else index++;
                    }
                    else if(_pages[index].PageAge >= WORKING_SET_TIME)
                    {
                        DeletePage(index);
                        AddPage(pageNumber, index, type);
                        break;
                    }
                    else
                    {
                        if (index == _pages.Count - 1) index = 0;
                        else index++;
                    }
                 
            }
            } while (true);
        }

        private void HandleTimerElapsed(Object sender, ElapsedEventArgs e)
        {
            for(int i =0; i < _pages.Count; i++)
            {
                Page page = _pages[i];
                if (page.IsReferenced) page.IsReferenced = false;
            }

            _swapper.ResetStatus();
         
            InvokePageTableChanged();
        }

        private void InvokeReferencedChanged(int page, int pageFrame, int physicalAddress)
        {
            ReferencedChanged?.Invoke(this, new ReferencedChangedEventArgs(page, pageFrame, physicalAddress));
        }

        private void InvokePageTableChanged()
        {
            PageTableChanged?.Invoke(this, new EventArgs());
        }
    }
}
