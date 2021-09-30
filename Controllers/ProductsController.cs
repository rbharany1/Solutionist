using Microsoft.AspNetCore.Mvc;
using SolutionistProducts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SolutionistProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/<ProductsController>
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        public IActionResult ListProducts()
        {
            //=============================================================
            //Set up the Services Class object
            //=============================================================
            ProductServicesClass productServices = new ProductServicesClass();

            //=============================================================
            //set up the dictionary object
            //=============================================================
            Dictionary<string, dynamic> productList = new Dictionary<string, dynamic>();

            try
            {
                //=============================================================
                //get the products
                //=============================================================
                productList = productServices.getProductList();

                return Ok(productList);
            }
            catch (Exception ex)
            {
                //=============================================================
                //We have got an error so return a Bad request with the 
                //Error message
                //=============================================================
                return BadRequest(new { message = ex.Message });
            }
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
