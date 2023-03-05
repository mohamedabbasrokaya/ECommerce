using EcomerceDAL.Entity;
using ECommerceApis.Helper;
using ECommerceBLL.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace ECommerceApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Iuniteofwork uniteofwork;

        public ProductController(Iuniteofwork uniteofwork)
        {
            this.uniteofwork = uniteofwork;
        }
        //GET:api/Product
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return Ok(await uniteofwork.productreposaitry.GetAll());

        }
        //GET:api/Product/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProducts(int id)
        {
          
                var product= await uniteofwork.productreposaitry.Get(id);
            if (id != null)
                return Ok(product);
            return BadRequest();
        }
        //GET:api/product/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            var product = await uniteofwork.productreposaitry.Get(id);
            if (product != null)
            {
                await uniteofwork.productreposaitry.Delete(product);
                return Ok(new ResponseMessage { status = "Success", message = "product is delete succssfuly!" });
            }
            return BadRequest();
               
        }
      //GET:apis/product/5
        [HttpPost]
        public async Task<ActionResult> CreateProduct(Product model)
        {
            if (ModelState.IsValid)
            {
                await uniteofwork.productreposaitry.create(model);
                return CreatedAtAction("GetProduct",new {id=model.id},model);
            }
            return BadRequest(ModelState);

            }
        [HttpPut("{id}")]
        public async Task<ActionResult> putproduct(int id, Product product)
        {
            if(id==product.id)
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        await uniteofwork.productreposaitry.update(product);
                        return Ok(new ResponseMessage { status = "success", message = "product is updated successfully!" });
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
            return BadRequest(ModelState);

        }

        }
    }

