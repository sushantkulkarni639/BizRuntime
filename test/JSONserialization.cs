using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment
{
    // related program is JSONProgram
    public class JSONserialization
    {
        public string Name
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public int Phone
        {
            set; get;
        }
        public string Email
        {
            set; get;
        }
        public override string ToString()
        {
            return string.Format("Student info:\n\tName:{0},\n\tAddress:{1},\n\tPhone:{2},\n\tEmail:{3}", Name, Address, 
                Phone, Email);
        }
    }
}
