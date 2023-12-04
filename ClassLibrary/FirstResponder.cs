using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FirstResponder
    {
        public string type;

        public FirstResponder() { }
        public string Type { get { return type; } set { type = value; } }
    }
}
