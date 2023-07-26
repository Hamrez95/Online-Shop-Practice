namespace Online_Shop_Practice
{

    public class KitchenProduct : Product
    {
        public bool ElectricalKitchenProduct { get; set; }
        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Digital Product - Name : {ProductName} - Color: {ProductColor} - SerialNum: {ProductSerialNumber} - Price: {Price} - Count : {ProductCount}");

        }
    }

}