namespace Online_Shop_Practice
{

    public class OnlineShop : IOnlineShop
    {
        #region Lists
        public List<Product> Products;
        public List<Customer> Customers;

        public OnlineShop()
        {
            Products = new List<Product>();
            Customers = new List<Customer>();
        }
        #endregion

        #region Customer/Products ADD & Remove
        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }
        public void RemoveCustomer(Customer customer)
        {
            Customers.Remove(customer);
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }
        #endregion

        #region CartMethodsImplementation
        public void AddToCart(Product product, Customer customer)
        {
            if (product.ProductIsAvailable)
            {
                customer.AddToCart(product);
            }
            else
            {
                Console.WriteLine("Sorry, this product is not GetAvailableProducts at this time.");
            }
        }
        public void RemoveFromCart(Product product, Customer customer)
        {
            customer.RemoveFromCart(product);
        }

        public void ProcessPayment(Customer customer)
        {
            customer.MakePayment();
        }

        #endregion


        public List<Product> GetAvailableProducts()
        {
            return Products;
            //throw new NotImplementedException();
        }


    }

}