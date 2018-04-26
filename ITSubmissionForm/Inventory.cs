using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSubmissionForm
{
    class Inventory
    {
        public string ComputerBrand { get; private set; }
        public string ComputerModel { get; private set; }
        public bool Bag { get; set; }
        public bool PowerCord { get; set; }
        public bool UsbDrive { get; set; }
        public bool CompactDiscs { get; set; }
        public bool Keyboard { get; set; }
        public bool Mouse { get; set; }
        public string Other { get; set; }

        public Inventory(string brand, string model)
        {
            ComputerBrand = brand;
            ComputerModel = model;
        }
    }
}
