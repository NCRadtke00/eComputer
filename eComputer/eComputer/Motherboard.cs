using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eComputer
{
    class Motherboard
    {
        public string Manufacturer;
        public CPU Processor;
        public Ram TemporaryMemory;
        public HardDrive Storage;
        public GPU Graphics;
        public Motherboard(string manufacturer, CPU cpu, Ram ram, HardDrive hardDrive, GPU gpu)
        {
            Manufacturer = manufacturer;
            TemporaryMemory = ram;
            Processor = cpu;
            Storage = hardDrive;
            Graphics = gpu;
        }

    }
}
