using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Week5Service.Domain;

namespace Week5Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in both code and config file together.
    public class UserService : IUserService
    {
        public void AddProduct(string username, string productName)
        {
            User user = Main.Instance.PersistenceService.FindUserByID(username);
            if (user != null)
            {
                foreach (ProductItem productItem in user.ProductItemList)
                {
                    if (productItem.ProductName.Equals(productName))
                    {
                        productItem.Amount += 1;
                        Main.Instance.PersistenceService.InsertOrUpdateUser(user);
                        return;
                    }
                }
                user.ProductItemList.Add(new ProductItem { ProductName = productName, Amount = 1 });
                Main.Instance.PersistenceService.InsertOrUpdateUser(user);
            }
        }

        public double GetMoney(string username)
        {
            User user = Main.Instance.PersistenceService.FindUserByID(username);
            return user == null ? 0.00 : Math.Round(user.Money, 2);
        }

        public void RemoveProduct(string username, string productName)
        {
            User user = Main.Instance.PersistenceService.FindUserByID(username);
            if (user != null)
            {
                foreach (ProductItem productItem in user.ProductItemList)
                {
                    if (productItem.ProductName.Equals(productName))
                    {
                        productItem.Amount -= 1;
                        if (productItem.Amount <= 0)
                        {
                            user.ProductItemList.Remove(productItem);
                        }
                        Main.Instance.PersistenceService.InsertOrUpdateUser(user);
                        return;
                    }
                }
            }
        }

        public List<ProductItem> GetProductItems(string username)
        {
            User user = Main.Instance.PersistenceService.FindUserByID(username);
            return user == null ? new List<ProductItem>() : user.ProductItemList;
        }

    }
}
