using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Service.Domain;

namespace Week5Service.Peristence
{
    class PersistenceService
    {

        public PersistenceService(IPersistenceFactory factory)
        {
            Factory = factory;
        }

        IPersistenceFactory Factory { get; set; }

        public List<User> FindAllUsers()
        {
            return Factory.FindAllUsers();
        }

        public User FindUserById(string identifier)
        {
            return Factory.FindUserById(identifier);
        }

        public void InsertOrUpdateUser(User dto)
        {
            Factory.InsertOrUpdateUser(dto);
        }

        public void DeleteUser(string identifier)
        {
            Factory.DeleteUser(identifier);
        }

    }
}
