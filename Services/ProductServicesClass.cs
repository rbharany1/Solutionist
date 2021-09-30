using SolutionistProducts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionistProducts.Services
{
    public class ProductServicesClass
    {
        /// <summary>
        /// Product Service Class used to retrieve the Test Data
        /// in a dictionary
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, dynamic> getProductList()
        {
            Dictionary<string, dynamic> productList = new Dictionary<string, dynamic>();
            productList = TestDataSeedClass.ProductList();

            return productList;
        }
    }
}
