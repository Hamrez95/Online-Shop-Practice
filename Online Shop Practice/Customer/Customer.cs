namespace Online_Shop_Practice
{

    public class Customer
    {
        #region Properties
        public string Name { get; set; }
        public string ContactInfo { get; set; }

        public List<Product> Cart { get; }
        public List<Payment> PaymentHistory { get; }
        #endregion

        #region CartMethods
        public void MakePayment()
        {
            double totalAmount = 0;
            foreach(Product product in Cart)
            {
                totalAmount+= product.Price;
            }
            Payment payment = new Payment(totalAmount);
            payment.ProductPurchased.AddRange(Cart);
            PaymentHistory.Add(payment);

            Cart.Clear();
        }

        public void AddToCart(Product product)
        {
            Cart.Add(product);
        }
        public void RemoveFromCart(Product product)
        {
            Cart.Add(product);
        }
        #endregion

        // Constructor
        public Customer(string name, string contactInfo)
        {
            Name = name;
            ContactInfo = contactInfo;
            Cart = new List<Product>();
            PaymentHistory = new List<Payment>();
        }


    }

}