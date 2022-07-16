using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections;
using System.Collections.Generic;
using WebApiSQLite.Models;
using WebApiSQLite.Services;

namespace WebApiSQLite.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TestController : ControllerBase
    {
        
        private readonly IService _service;

        public TestController(IService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _service.GetProducts();
        }

        [HttpGet]
        public Product Insert()
        {
            Product item = new()
            {
                Name = "Salatalık",
                Price = "18"
            };
            return _service.Insert(item);
        }

        [HttpGet]
        public Product GetProductById(int Id)
        {
            return _service.GetProductById(Id);
        }


        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return _service.GetUsers();
        }

        [HttpGet]
        public User GetUserById(int Id)
        {
            return _service.GetUserById(Id);
        }



    }
}
