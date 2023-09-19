using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext: DbContext
    {
        /// <summary>
        /// Constructor for StoreContext
        /// </summary>
        /// <param name="options"></param>
        public StoreContext(DbContextOptions options) : base(options)
        {

        }
        /// <summary>
        /// Creates a table in the database called Products
        /// </summary>
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductBrand> ProductBrands{ get; set; }
    }
}
