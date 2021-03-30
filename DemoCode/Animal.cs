using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode
{
    public class Animal
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string GetTypeName(string Type, string Name)
        {
            return Name + " is an animal of type " + Type;
        }

    }
}
