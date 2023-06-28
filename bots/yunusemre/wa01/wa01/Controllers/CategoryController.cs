using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wa01.Models;

namespace wa01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly StoreContext DbContext;

        public CategoryController(StoreContext context)
        {
            this.DbContext = context;
        }



        [HttpGet]
        [Route("categories")]
        public async Task<IActionResult> GetCategories()
        {

            List<Category> categories = DbContext.Categories.ToList();


            try
            {

                if(categories.Count == 0)
                {
                    return Ok("Kategori listesi Boş");
                }
                else
                {

                    return Ok(categories);
                }
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory([FromBody] Category category)
        {

            DbContext.Categories.Add(category);
            await DbContext.SaveChangesAsync();

            return Ok(category);


        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteCategory(int id)
        {

            try
            {
                var category = await DbContext.Categories.FindAsync(id);
                DbContext.Categories.Remove(category);
                await DbContext.SaveChangesAsync();

                return Ok("Seçilen Kategori Silindi");
            }
            catch
            {
                return BadRequest("Böyle Bir Kategori Yok");
            }

        }


        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> PutCategory(int id, [FromBody] Category category)
        {
            try
            {
                if(id != category.Id)
                {
                    return BadRequest("Böyle bir kategori yok");
                }
                else
                {
                    DbContext.Entry(category).State = EntityState.Modified;
                    await DbContext.SaveChangesAsync();
                    return Ok(category);
                }

            }
            catch(Exception ex) 
            {
                return BadRequest($"Güncellenirken hata meydana geldi: {ex.Message}");
            }
        }

    }
}
