namespace Online_Shop_Practice
{

    public class DigitalProduct : Product
    {
        public int DProductSize { get; set; }

        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Digital Product - Name : {ProductName} - Color: {ProductColor} - Size: {DProductSize} - Price: {Price} - SerialNum: {ProductSerialNumber} - Count : {ProductCount}");
        }
    }

}