using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class jsonPersonArray : jsonPersonComplex
    {
        public List<phoneNum> phoneNumbers { get; set; }
        

        public class phoneNum
        {
            public string type { get; set; }
            public string number { get; set; }
        }
    }
}
