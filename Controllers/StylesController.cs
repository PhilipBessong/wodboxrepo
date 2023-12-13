﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wodapi.Models;

namespace wodapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StylesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StylesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Styles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Style>>> GetStyles()
        {
          if (_context.Styles == null)
          {
              return NotFound();
          }
            return await _context.Styles.ToListAsync();
        }

        // GET: api/Styles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Style>> GetStyle(int id)
        {
          if (_context.Styles == null)
          {
              return NotFound();
          }
            var style = await _context.Styles.FindAsync(id);

            if (style == null)
            {
                return NotFound();
            }

            return style;
        }

        // PUT: api/Styles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStyle(int id, Style style)
        {
            if (id != style.styleId)
            {
                return BadRequest();
            }

            _context.Entry(style).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StyleExists(id))
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

        // POST: api/Styles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Style>> PostStyle(Style style)
        {
          if (_context.Styles == null)
          {
              return Problem("Entity set 'AppDbContext.Styles'  is null.");
          }
            _context.Styles.Add(style);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStyle", new { id = style.styleId }, style);
        }

        // DELETE: api/Styles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStyle(int id)
        {
            if (_context.Styles == null)
            {
                return NotFound();
            }
            var style = await _context.Styles.FindAsync(id);
            if (style == null)
            {
                return NotFound();
            }

            _context.Styles.Remove(style);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StyleExists(int id)
        {
            return (_context.Styles?.Any(e => e.styleId == id)).GetValueOrDefault();
        }
    }
}
