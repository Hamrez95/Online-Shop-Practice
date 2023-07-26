namespace Online_Shop_Practice
{

    public class Payment
    {
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public List<Product> ProductPurchased { get; }

        //constructor
        public Payment(double amount)
        {
            Amount = amount;
            PaymentDate = DateTime.Now;
            ProductPurchased = new List<Product>();
        }
    }

}