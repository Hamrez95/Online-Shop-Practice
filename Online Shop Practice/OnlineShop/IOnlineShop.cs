namespace Online_Shop_Practice
{

    public interface IOnlineShop
    {
        #region BaseMethods For Products & Customers
        void AddProduct(Product product);
        void RemoveProduct(Product product);
        void AddCustomer(Customer customer);
        void RemoveCustomer(Customer customer);
        

        #endregion

        #region CartsMethods
        void AddToCart(Product product, Customer customer);
        void RemoveFromCart(Product product, Customer customer);

        void ProcessPayment(Customer customer);
        #endregion

        List<Product> GetAvailableProducts();
        
    }

}