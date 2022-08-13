﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIG1.Data;
using WebAPIG1.Models;

namespace WebAPIG1.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class RazasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RazasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Razas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Raza>>> GetRazas()
        {
          if (_context.Razas == null)
          {
              return NotFound();
          }
            return await _context.Razas.ToListAsync();
        }

        // GET: api/Razas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Raza>> GetRaza(int id)
        {
          if (_context.Razas == null)
          {
              return NotFound();
          }
            var raza = await _context.Razas.FindAsync(id);

            if (raza == null)
            {
                return NotFound();
            }

            return raza;
        }

        // PUT: api/Razas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaza(int id, Raza raza)
        {
            if (id != raza.Id)
            {
                return BadRequest();
            }

            _context.Entry(raza).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RazaExists(id))
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

        // POST: api/Razas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Raza>> PostRaza(Raza raza)
        {
          if (_context.Razas == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Razas'  is null.");
          }
            _context.Razas.Add(raza);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRaza", new { id = raza.Id }, raza);
        }

        // DELETE: api/Razas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaza(int id)
        {
            if (_context.Razas == null)
            {
                return NotFound();
            }
            var raza = await _context.Razas.FindAsync(id);
            if (raza == null)
            {
                return NotFound();
            }

            _context.Razas.Remove(raza);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RazaExists(int id)
        {
            return (_context.Razas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
