using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrowdInsightsServer.Core.Entities;
using CrowdInsightsServer.Infrastructure.Data;

namespace CrowdInsightsServer.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogItemsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LogItemsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/LogItems
        [HttpGet]
        public IEnumerable<LogItem> GetLogItems()
        {
            return _context.LogItems;
        }

        // GET: api/LogItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLogItem([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var logItem = await _context.LogItems.FindAsync(id);

            if (logItem == null)
            {
                return NotFound();
            }

            return Ok(logItem);
        }

        // PUT: api/LogItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLogItem([FromRoute] Guid id, [FromBody] LogItem logItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != logItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(logItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LogItemExists(id))
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

        // POST: api/LogItems
        [HttpPost]
        public async Task<IActionResult> PostLogItem([FromBody] LogItem logItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.LogItems.Add(logItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLogItem", new { id = logItem.Id }, logItem);
        }

        // DELETE: api/LogItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLogItem([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var logItem = await _context.LogItems.FindAsync(id);
            if (logItem == null)
            {
                return NotFound();
            }

            _context.LogItems.Remove(logItem);
            await _context.SaveChangesAsync();

            return Ok(logItem);
        }

        private bool LogItemExists(Guid id)
        {
            return _context.LogItems.Any(e => e.Id == id);
        }
    }
}