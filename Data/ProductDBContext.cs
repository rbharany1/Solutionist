using Microsoft.EntityFrameworkCore;
using SolutionistProducts.Models;

namespace SolutionistProducts.Data
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {
        }

        public DbSet<Product> ProductList { get; set; }
    }
}
