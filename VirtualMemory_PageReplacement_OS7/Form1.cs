using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualMemory_PageReplacement_OS7
{
    public enum ALGORITHM_TYPE
    {
        FIFO,
        WSCIock
    }
    public partial class Form1 : Form
    {
        private MemoryManagementUnit _memoryManager;
        private ALGORITHM_TYPE _algorithmType;
        private System.Timers.Timer _timer;
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add(ALGORITHM_TYPE.FIFO);
            comboBox1.Items.Add(ALGORITHM_TYPE.WSCIock);

        }


        private void Rerender()
        {
            Action action = () =>
            {
                //clear
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                dataGridView3.Rows.Clear();

                //dataGridView1
                if (_algorithmType == ALGORITHM_TYPE.FIFO)
                {
                    for (int i = 0; i < _memoryManager.Queue.Count; i++)
                    {
                        int pageNumber = _memoryManager.Queue.ElementAt(i);
                        Page page = _memoryManager.PageTable[pageNumber];
                        if (page.IsPresent)
                        {
                            dataGridView1.Rows.Add(pageNumber, page.PageFrameNumber);
                        }
                    }
                }
                else
                {
                    for(int i=0; i < _memoryManager.PageTable.Count; i++)
                    {
                        Page page = _memoryManager.PageTable[i];
                        if (page.IsPresent)
                        {
                            dataGridView1.Rows.Add(i, page.PageFrameNumber);
                        }
                    }
                }

                //dataGridView2
                foreach (var pair in _memoryManager.PagesOnDiskTable)
                {
                    dataGridView2.Rows.Add(pair.Key, pair.Value);
                }

                //dataGridView3
                for (int i = 0; i < _memoryManager.PageTable.Count; i++)
                {
                    Page page = _memoryManager.PageTable[i];
                    if (_algorithmType == ALGORITHM_TYPE.FIFO)
                    {
                        dataGridView3.Rows.Add(i, page.IsPresent, page.IsReferenced, page.IsModified, page.PageFrameNumber);
                    }
                    else
                    {
                        if (page.IsPresent) dataGridView3.Rows.Add(i, page.IsPresent, page.IsReferenced, page.IsModified, page.PageFrameNumber, page.PageAge);
                        else dataGridView3.Rows.Add(i, page.IsPresent, page.IsReferenced, page.IsModified, page.PageFrameNumber);
                    }
                    if (page.IsPresent)
                    {
                        dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            };

            this.Invoke(action);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int memorySize;
            int processSize;
            if (comboBox1.SelectedItem != null)
            {
                if (int.TryParse(memorySizeTextBox.Text, out memorySize))
                {
                    if (int.TryParse(processSizeTextBox.Text, out processSize))
                    {
                        if (comboBox1.SelectedIndex == 1)
                        {
                            dataGridView3.Columns.Add("Time", "Page Age");
                            dataGridView3.Width += 100;
                            _algorithmType = ALGORITHM_TYPE.WSCIock;

                            _timer = new System.Timers.Timer(1000);
                            _timer.Elapsed += HandleTimerTick;
                            _timer.Start();
                        }
                        else
                        {
                            _algorithmType = ALGORITHM_TYPE.FIFO;
                        }

                        _memoryManager = new MemoryManagementUnit(memorySize,_algorithmType);
                        _memoryManager.ReferencedChanged += HandleReferenceChanged;
                        _memoryManager.PageTableChanged += HandlePageTableChanged;
                        _memoryManager.SetProcess(new Process((short)processSize));

                        Rerender();
                    }
                }
            }
        }

        private void ReferBtn_Click(object sender, EventArgs e)
        {
            int referedAddress;
            if(int.TryParse(referToAddressTextBox.Text,out referedAddress))
            {
                _memoryManager.Process.ReferToAddress(referedAddress);
                Rerender();
            }
        }

        private void ModifyBTN_Click(object sender, EventArgs e)
        {
            int modifiedAddress;
            if (int.TryParse(modifyAddressTextBox.Text, out modifiedAddress))
            {
                _memoryManager.Process.WriteToAddress(modifiedAddress);
                Rerender();
            }
        }

        private void HandleReferenceChanged(Object sender, ReferencedChangedEventArgs e)
        {
            pageLabel.Text = e.Page.ToString();
            pageFrameLabel.Text = e.PageFrame.ToString();
            physicalAddressLabel.Text = e.PhysicalAddress.ToString();
        }

        private void HandlePageTableChanged(Object sender, EventArgs e)
        {
            Rerender();
        }

        private void HandleTimerTick(Object sender, EventArgs e)
        {
            if(_memoryManager!=null && _memoryManager.Queue!=null && _memoryManager.PageTable!=null)Rerender();
        }
    }
}
