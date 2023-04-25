using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIDEE.Models;
namespace APIDEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
       public  string GetProduct ()
        {
            return "Milk";
        }
        [HttpGet]
        [Route("All")]
        public IEnumerable<Product> GetProducts() 
        {
            return new List<Product> { new Product(1, "bread"),
                                      new Product    (2, "milk"),
               new Product (3, "meat"),
               new Product (4, "oil"),
               new Product (5, "sweets"),
               new Product (6, "fruits"),
               new Product (7, "chicken"),
               new Product(8, "weed")  };
        }
    }
}
