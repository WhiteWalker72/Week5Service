using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Week5.Utils;
using Week5Service.Domain;

namespace Week5Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RegisterService" in both code and config file together.
    public class RegisterService : IRegisterService
    {

        public bool AccountExists(string username)
        {
            return Main.Instance.PersistenceService.FindUserById(username) != null;
        }

        public void Register(string username, string password)
        {
            Main.Instance.PersistenceService.InsertOrUpdateUser(new User(username, password));
        }

        public string GeneratePassword()
        {
            return StringUtils.GetRandomAlphanumericString(20);
        }

    }
}
