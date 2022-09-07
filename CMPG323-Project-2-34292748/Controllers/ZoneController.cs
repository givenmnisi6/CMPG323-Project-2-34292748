using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using CMPG323_Project_2_34292748.Models;
using JWTAuthentication.Authentication;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CMPG323_Project_2_34292748.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    [Route("")]
    [ApiController]
    public class ZoneController : ControllerBase
    {
        private readonly Models.ConnectedOfficedbContext _context;

        public ZoneController(Models.ConnectedOfficedbContext context)
        {
            _context = context;
        }

        // GET: api/Zone
        [HttpGet("Request all Zones")]
        public async Task<ActionResult<IEnumerable<Zone>>> GetZone()
        {
            return await _context.Zone.ToListAsync();
        }

        // GET: api/Zone/5
        [HttpGet("Search Zone")]
        public async Task<ActionResult<Zone>> GetZone(Guid id)
        {
            var zone = await _context.Zone.FindAsync(id);

            if (zone == null)
            {
                return NotFound();
            }

            return zone;
        }

         [HttpGet("Retrieve all Devices")]
         public async Task<ActionResult<Device>> RetrieveAllDevices(Guid id)
         {
            if (_context.Device == null){
                return NotFound();
            } else {
                return Ok(await _context.Device.Where(Device => Device.ZoneId == id).ToListAsync());
            }      
         }

        // POST: api/Zone
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost("Create Zone")]
        public async Task<ActionResult<Zone>> PostZone(Zone zone)
        {
            _context.Zone.Add(zone);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ZoneExists(zone.ZoneId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetZone", new { id = zone.ZoneId }, zone);
        }


        // PUT: api/Zone/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPatch("Update Existing Zone")]
        public async Task<IActionResult> PutZone(Guid id, Zone zone)
        {
            if (id != zone.ZoneId)
            {
                return BadRequest();
            }

            _context.Entry(zone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZoneExists(id))
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

       
        // DELETE: api/Zone/5
        [HttpDelete("Delete Zone")]
        public async Task<ActionResult<Zone>> DeleteZone(Guid id)
        {
            var zone = await _context.Zone.FindAsync(id);
            if (zone == null)
            {
                return NotFound();
            }

            _context.Zone.Remove(zone);
            await _context.SaveChangesAsync();

            return zone;
        }

        private bool ZoneExists(Guid id)
        {
            return _context.Zone.Any(e => e.ZoneId == id);
        }
    }
}
