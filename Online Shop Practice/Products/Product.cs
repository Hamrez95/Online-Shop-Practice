namespace Online_Shop_Practice
{

    public abstract class Product
    {
        public string ProductName { get; set; }
        public string ProductColor { get; set; }
        public int ProductSerialNumber { get; set; }
        public double Price { get; set; }
        public int ProductCount { get; set; }
        public bool ProductIsAvailable { get; set; }


        public abstract void DisplayProductInfo();
    }
    

}