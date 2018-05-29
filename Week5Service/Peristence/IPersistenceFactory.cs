using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Service.Domain;

namespace Week5Service.Peristence
{
    interface IPersistenceFactory
    {

        List<User> FindAllUsers();

        User FindUserById(string identifier);

        void InsertOrUpdateUser(User dto);

        void DeleteUser(string identifier);

    }
}
