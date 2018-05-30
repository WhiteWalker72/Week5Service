using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Week5Service.Domain;
using Week5Service.Peristence;

namespace Week5Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in both code and config file together.
    public class ProductService : IProductService
    {
        private readonly PersistenceService persistenceService;

        public ProductService()
        {
            persistenceService = Main.Instance.PersistenceService;
        }

        public void InsertProduct(string name, double price)
        {
            persistenceService.InsertOrUpdateProduct(new Product(name, price, 10));
        }

        List<Product> IProductService.GetAllProducts()
        {
            return persistenceService.FindAllProducts();
        }

        Product IProductService.GetProduct(string name)
        {
            return persistenceService.FindProductByID(name);
        }

        Boolean IProductService.BuyProduct(string productName, string username)
        {
            Product product = persistenceService.FindProductByID(productName);
            if (product == null)
                return false;

            User user = persistenceService.FindUserByID(username);
            if (user == null)
                return false;
            if (product.Price > user.Money)
                return false;

            product.AmountInStock = product.AmountInStock - 1;
            if (product.AmountInStock <= 0)
            {
                persistenceService.DeleteProduct(product.Name);
            } else
            {
                persistenceService.InsertOrUpdateProduct(product);
            }


            user.Money = user.Money - product.Price;
            persistenceService.InsertOrUpdateUser(user);
            //TODO: add to user inv items

            return true;
        }
    }
}
