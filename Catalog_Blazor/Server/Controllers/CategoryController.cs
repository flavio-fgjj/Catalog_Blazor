using Catalog_Blazor.Server.Context;
using Catalog_Blazor.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Catalog_Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly AppDbContext context;

        // ctor
        public CategoryController(AppDbContext context) // dependency injection
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> Get() => await context.Categories.AsNoTracking().ToListAsync();

        [HttpGet("{id}", Name = "GetCategory")]
        public async Task<ActionResult<Category>> Get(int id)
        {
            var result = await context.Categories.FirstOrDefaultAsync(x => x.CategoryId == id);
            return result != null ? result : NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Category>> Post(Category category)
        {
            context.Add(category);
 
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("GetCategory", new { id = category.CategoryId }, category);
        }

        [HttpPut]
        public async Task<ActionResult<Category>> Put(Category category)
        {
            context.Entry(category).State = EntityState.Modified;

            await context.SaveChangesAsync();
            return Ok(category);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Category>> Delete(int id)
        {
            var category = new Category { CategoryId = id };
            context.Remove(category);

            await context.SaveChangesAsync();
            return Ok(category);

        }
    }
}
