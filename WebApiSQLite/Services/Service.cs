using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSQLite.Models;

namespace WebApiSQLite.Services
{
    public class Service : IService
    {
        private DataContext _dataContext;
        public Service(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Product GetProductById(int Id)
        {
            return _dataContext.Products.FirstOrDefault(a => a.Id == Id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dataContext.Products.ToList();
        }

        public User GetUserById(int Id)
        {
            return _dataContext.Users.FirstOrDefault(a => a.Id == Id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _dataContext.Users.ToList();
        }

        public Product Insert(Product item)
        {
            if (item != null)
            {
                _dataContext.Products.Add(item);

                _dataContext.SaveChanges();

                return _dataContext.Products.OrderByDescending(a=>a.Id).FirstOrDefault();
            }
            return null;
        }
    }
}
