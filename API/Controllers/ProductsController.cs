using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private MyStoreContext _myStoreContext;
        public ProductsController(MyStoreContext myStoreContext)
        {
            _myStoreContext = myStoreContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _myStoreContext.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Getproduct(int id)
        {
            return await _myStoreContext.Products.FindAsync(id);
        }
    }
}
