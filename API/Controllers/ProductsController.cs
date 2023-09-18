
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //https://localhost:5001/api/products
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Method to get all products from the database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products =await _context.Products.ToListAsync();
            return products;
        }
        /// <summary>
        /// Method to get a single product from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>>GetProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}
