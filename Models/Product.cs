using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionistProducts.Models
{
    /// <summary>
    /// Product DB Entity
    /// </summary>
    public class Product
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
    }
}
