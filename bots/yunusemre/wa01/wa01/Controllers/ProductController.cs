using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wa01.Models;

namespace wa01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly StoreContext DbContext;

        public ProductController(StoreContext DbContext)
        {
            this.DbContext = DbContext;
        }

        [HttpGet]
        [Route("products")]
        public async Task<IActionResult> GetProducts()
        {

            List<Product> products = DbContext.Products.ToList();

            try
            {
                if(products.Count == 0)
                {
                    return Ok("Ürün Listesi Boş");
                }
                else
                {

                    return Ok(products);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPost]

        public async Task<ActionResult<Product>> PostProduct([FromBody] Product product)
        {

            DbContext.Products.Add(product);
            await DbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProducts),new {id =  product.Id},product);


        }


        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteProduct(int id)
        {

            try
            {
                var product = await DbContext.Products.FindAsync(id);
                DbContext.Products.Remove(product);
                await DbContext.SaveChangesAsync();

                return Ok("Seçilen Ürün Silindi");
            }
            catch
            {
                return BadRequest("Böyle Bir Ürün Yok");
            }

        }


        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> PutProduct(int id, [FromBody] Product product)
        {
            try
            {
                if (id != product.Id)
                {
                    return BadRequest("Böyle bir Ürün yok");
                }
                else
                {
                    DbContext.Entry(product).State = EntityState.Modified;
                    await DbContext.SaveChangesAsync();
                    return Ok(product);
                }

            }
            catch (Exception ex)
            {
                return BadRequest($"Güncellenirken hata meydana geldi: {ex.Message}");
            }
        }




    }
}
