using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMemory_PageReplacement_OS7
{
    internal class Process
    {
        private short _size;

        public event ReferencedToAddressEventHandler ReferencedToAddress;

        public Process(short size)
        {
            _size = size;
        }

        public short Size
        {
            get
            {
                return _size; 
            }
        }

        public void ReferToAddress(int address)
        {
            InvokeReferencedToAddress(address, ADDRESSING_TYPE.REFERENCE);
        }

        public void WriteToAddress(int address)
        {
            InvokeReferencedToAddress(address, ADDRESSING_TYPE.MODIFYING);
        }

        private void InvokeReferencedToAddress(int referencedAddress,ADDRESSING_TYPE type)
        {
            ReferencedToAddress?.Invoke(this, new ReferencedToAddressEventArgs(referencedAddress, type));
        }
    }
}
