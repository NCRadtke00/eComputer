using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eComputer
{
    class CPU
    {
        public string manufacturer;
        public string name;
        public CPU(string newName, string manufacturer)
        {
            this.name = newName;
            this.manufacturer = manufacturer;
        }
    }
}
