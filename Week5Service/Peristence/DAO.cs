using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Service.Peristence
{
    interface IDAO<T>
    {
        List<T> FindAll();
        T FindById(string identifier);

        void InsertOrUpdate(T dto);
        void Delete(string identifier);
    }
}
