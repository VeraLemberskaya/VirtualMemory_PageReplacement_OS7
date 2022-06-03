using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMemory_PageReplacement_OS7
{
    internal class Swapper
    {
        private Dictionary<int, DISK_STATUS> _pagesOnDisk;

        public Swapper()
        {
            _pagesOnDisk = new Dictionary<int, DISK_STATUS>();
        }

        public Dictionary<int, DISK_STATUS> Table
        {
            get
            {
               return  _pagesOnDisk;
            }
        }

        public void UploadToDisk(int page)
        {
            _pagesOnDisk.Add(page, DISK_STATUS.LOADED);
        }
        public void UpdatePageOnDisk(int page)
        {
            _pagesOnDisk[page] = DISK_STATUS.UPDATED;
        }
        public void getPageFromDisk(int page)
        {
            _pagesOnDisk[page] = DISK_STATUS.TAKEN;
        }

        public void ResetStatus()
        {
            for (int i = 0; i < _pagesOnDisk.Count; i++)
            {
                if (_pagesOnDisk[i] != DISK_STATUS.LOADED) _pagesOnDisk[i] = DISK_STATUS.LOADED;
            }
        }

    }
}
