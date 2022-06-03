using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMemory_PageReplacement_OS7
{
    internal class Page
    {
        private bool _presentBit;
        private bool _referencedBit;
        private bool _mofifiedBit;
        private int? _pageFrameNumber;
        private DateTime _dateOfLastReference;

        public Page()
        {
            _presentBit = false;
            _referencedBit = false;
            _mofifiedBit = false;
            _pageFrameNumber = null;
        }

        public Page(bool presentBit, bool referencedBit, bool modifiedBit, int pageFrameNumber)
        {
            _presentBit = presentBit;
            _referencedBit = referencedBit;
            _mofifiedBit = modifiedBit;
            _pageFrameNumber = pageFrameNumber;
            _dateOfLastReference = DateTime.Now;
        }

        public bool IsPresent
        {
            set
            {
                _presentBit = value;
            }
            get
            {
                return _presentBit;
            }
        }

        public bool IsReferenced
        {
            set
            {
                _referencedBit = value;
            }
            get
            {
                return _referencedBit;
            }
        }

        public bool IsModified
        {
            set
            {
                _mofifiedBit = value;
            }
            get
            {
                return _mofifiedBit;
            }
        }

        public int? PageFrameNumber
        {
            set
            {
                _pageFrameNumber = value;
            }
            get
            {
                return _pageFrameNumber;
            }
        }

        public void Modify()
        {
            _mofifiedBit = true;
            _dateOfLastReference = DateTime.Now;
        }

        public void Refer()
        {
            _referencedBit = true;
            _dateOfLastReference = DateTime.Now;
        }

        public int PageAge
        {
            get
            {
                DateTime date1 = DateTime.Now;
                DateTime date2 = _dateOfLastReference;
                TimeSpan interval = date1 - date2;
                return (int)interval.TotalSeconds;
            }
        }
    }
}
