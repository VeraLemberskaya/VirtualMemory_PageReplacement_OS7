using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMemory_PageReplacement_OS7
{
    public enum ADDRESSING_TYPE
    {
        REFERENCE,
        MODIFYING
    }

    public class ReferencedToAddressEventArgs
    {
        private int _referredAddress;
        private ADDRESSING_TYPE _type;

        public ReferencedToAddressEventArgs(int referredAddress, ADDRESSING_TYPE type)
        {
            _referredAddress = referredAddress;
            _type = type;
        }

        public int ReferredAddress
        {
            get
            {
                return _referredAddress;
            }
        }

        public ADDRESSING_TYPE AddressingType
        {
            get
            {
                return _type;
            }
        }
    }

    public delegate void ReferencedToAddressEventHandler(Object sender, ReferencedToAddressEventArgs e);

}
