using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eComputer
{
    class GPU
    {
        public string manufacturer;
        public double effectiveMemory;
        public GPU(string manufacturer, double effectiveMemory)
        {
            this.manufacturer = manufacturer;
            this.effectiveMemory = effectiveMemory;
        }
    }
}
