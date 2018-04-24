using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Inventory
    {
        private string _ComputerBrand { get; set; }
        private string _ComputerModel { get; set; }
        private bool _Bag { get; set; }
        private bool _PowerCord { get; set; }
        private bool _ExtDrive { get; set; }
        private bool _CompactDiscs { get; set; }
        private string _Other { get; set; }

        public Inventory(string brand, string model)
        {
            this._ComputerBrand = brand;
            this._ComputerModel = model;
        }
    }
}
