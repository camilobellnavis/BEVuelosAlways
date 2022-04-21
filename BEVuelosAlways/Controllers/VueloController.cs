using BEVuelosAlways.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BEVuelosAlways.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VueloController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        public VueloController(AplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<VueloController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var listVuelos = await _context.Vuelo.ToListAsync();
                return Ok(listVuelos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<VueloController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                var vuelo = await _context.Vuelo.FindAsync(id);

                if (vuelo == null)
                {
                    return NotFound();
                }
                return Ok(vuelo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<VueloController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Vuelo vuelo)
        {
            try
            {
                _context.Add(vuelo);
                await _context.SaveChangesAsync();

                return Ok(vuelo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<VueloController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Vuelo vuelo)
        {
            try
            {
                if (id != vuelo.id)
                {
                    return BadRequest();
                }
                _context.Update(vuelo);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Vuelo actualizado exitosamente!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<VueloController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var vuelo = await _context.Vuelo.FindAsync(id);

                if (vuelo == null)
                {
                    return NotFound();
                }

                _context.Vuelo.Remove(vuelo);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Vuelo elminado exitosamente!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
