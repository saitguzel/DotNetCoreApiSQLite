using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSQLite.Models;

namespace WebApiSQLite.Services
{
    public interface IService
    {
        IEnumerable<Product> GetProducts();

        Product GetProductById(int Id);

        Product Insert(Product item);

        IEnumerable<User> GetUsers();

        User GetUserById(int Id);

    }
}
