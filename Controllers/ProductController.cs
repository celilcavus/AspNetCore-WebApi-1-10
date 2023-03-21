using Microsoft.AspNetCore.Mvc;
using productWebApi.Entity;
using productWebApi.Models;
namespace productWebApi.Controllers
{
    [ApiController]
    [Route("api/[Controller]/[Action]")]
    public class ProductController : ControllerBase
    {
        ProductRepository rep = new ProductRepository();
        [HttpGet]
        public IActionResult GetList()
        {

            var productList = rep.GetProductionList();
            return Ok(productList);
        }
        [HttpGet("{id}")]
        public IActionResult GetList(int id)
        {

            var productList = rep.GetProductionList(id);
            return Ok(productList);
        }
        [HttpPost]
        public IActionResult PostProduct(Product product)
        {
            rep.AddProduct(product);
            return NoContent();
        }
        [HttpPut]
        public IActionResult PutProduct(Product product)
        {
            rep.UpdateProduct(product);
            return NoContent();
        }
        [HttpDelete]
        public IActionResult DeleteProduct(Product product)
        {
            rep.DeleteProduct(product);
            return NoContent();
        }

    }
}