using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Week5Service.Domain;

namespace Week5Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LoginService" in both code and config file together.
    public class LoginService : ILoginService
    {
        public bool Authenticate(string username, string password)
        {
            if (username == null || password == null)
                return false;
            User user = Main.Instance.PersistenceService.FindUserByID(username);
            return user != null && user.Password.Equals(password);
        }

    }
}
