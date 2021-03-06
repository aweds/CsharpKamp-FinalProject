using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //loosely coupled  gevşej bir bağlılık var aralrında
        // naming convention
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        //[HttpGet]
        //public List<Product> Get()
        //{
        //    _productService = new ProductManager(new EfProductDal());
        //    var result = _productService.GetAll();
        //    return result.Data;

        //    //return "Merhaba";
        //}

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            _productService = new ProductManager(new EfProductDal());
            var result = _productService.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add(Product product)
        { 
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
