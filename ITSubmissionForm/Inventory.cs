namespace ITSubmissionForm
{
    class Inventory
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public bool Bag { get; private set; }
        public bool PowerCord { get; private set; }
        public bool UsbDrive { get; private set; }
        public bool CompactDiscs { get; private set; }
        public bool Keyboard { get; private set; }
        public bool Mouse { get; private set; }
        public string Other { get; private set; }

        public Inventory(string InventoryBrand, string InventoryModel, bool InventoryBag, bool InventoryPower, bool InventoryUsb, bool InventoryCD, bool InventoryKB, bool InventoryMouse, string InventoryOther)
        {
            Brand = InventoryBrand;
            Model = InventoryModel;
            Bag = InventoryBag;
            PowerCord = InventoryPower;
            UsbDrive = InventoryUsb;
            CompactDiscs = InventoryCD;
            Keyboard = InventoryKB;
            Mouse = InventoryMouse;
            Other = InventoryOther;
        }
    }
}
