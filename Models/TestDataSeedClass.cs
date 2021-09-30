using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SolutionistProducts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionistProducts.Models
{
    public class TestDataSeedClass
    {
        /// <summary>
        /// Used to seed the in memory DB
        /// Not used for this project as I am returning a Dictionary Object instead
        /// </summary>
        /// <param name="serviceProvider"></param>
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProductDBContext(serviceProvider.GetRequiredService<DbContextOptions<ProductDBContext>>()))
            {
                if (context.ProductList.Any())
                {
                    return; // //Data has already been initialised
                }


                for (int i = 1; i <= 20; i++)
                {
                    Product p = new Product();
                    p.ProductId = i;
                    p.Name = "Test Product " + i;
                    p.Price = Convert.ToDouble("10.00");
                    p.Stock = 5;
                    p.Image = "TestImage.jpg";

                    context.ProductList.Add(p);
                }

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Used to seed Test Data for the Product Services Class
        /// Set up 20 test items
        /// </summary>
        /// <returns>Dictionary<string,dynamic></string></returns>
        public static Dictionary<string, dynamic> ProductList()
        {
            Dictionary<string, dynamic> productList = new Dictionary<string, dynamic>();

            List<Product> products = new List<Product>();

            for (int i = 1; i <= 20; i++)
            {
                Product p = new Product();
                p.ProductId = i;
                p.Name = "Test Product " + i;
                p.Price = Convert.ToDouble("10.00");
                p.Stock = 5;
                p.Image = "TestImage" + i + ".jpg";

                products.Add(p);
            }

            productList.Add("ProductList", products);

            return productList;

        }
    }
}
