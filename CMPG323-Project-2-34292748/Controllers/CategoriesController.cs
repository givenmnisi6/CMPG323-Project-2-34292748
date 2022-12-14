using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CMPG323_Project_2_34292748.Models;
using Microsoft.AspNetCore.Mvc.Routing;
using JWTAuthentication.Authentication;

namespace CMPG323_Project_2_34292748.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    [Route("")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly Models.ConnectedOfficedbContext _context;

        public CategoriesController(Models.ConnectedOfficedbContext context)
        {
            _context = context;
        }

        // GET: api/Categories
        [HttpGet("Get all Categories")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategory()
        {
            return await _context.Category.ToListAsync();
        }

        // GET: api/Categories/5
        [HttpGet("Get Category")]
        public async Task<ActionResult<Category>> GetCategory(Guid id)
        {
            var category = await _context.Category.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        [HttpGet("Fetch all Devices")]
        public async Task<ActionResult<Device>> RetrieveAllDevices(Guid id)
        {
            if (_context.Device == null){
                return NotFound();
            } else {
                return Ok(await _context.Device.Where(Device => Device.CategoryId == id).ToListAsync());
            }
        }

        [HttpGet("Return Number of Zones")]
        public async Task<ActionResult<Int64>> GetNumberOfZones(Guid id)
        {
            if (_context.Device == null)
            {
                return NotFound();
            }
            else
            {
                return (await _context.Device.Where(device => device.CategoryId == id).Select(device => device.ZoneId).Distinct().CountAsync());
            }
        }
        // POST: api/Categories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost("Create Category")]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            _context.Category.Add(category);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CategoryExists(category.CategoryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCategory", new { id = category.CategoryId }, category);
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPatch("Update Existing Category")]
        public async Task<IActionResult> PutCategory(Guid id, Category category)
        {
            if (id != category.CategoryId)
            {
                return BadRequest();
            }

            _context.Entry(category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

       

        // DELETE: api/Categories/5
        [HttpDelete("Delete Category")]
        public async Task<ActionResult<Category>> DeleteCategory(Guid id)
        {
            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.Category.Remove(category);
            await _context.SaveChangesAsync();

            return category;
        }

        private bool CategoryExists(Guid id)
        {
            return _context.Category.Any(e => e.CategoryId == id);
        }
    }
}
