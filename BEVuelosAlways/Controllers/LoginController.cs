using BEVuelosAlways.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEVuelosAlways.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        
        private readonly AplicationDbContext _context;
        public LoginController(AplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<LoginController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var listPersonas = await _context.Login.ToListAsync();
                return Ok(listPersonas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<LoginController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                var login = await _context.Login.FindAsync(id);

                if (login == null)
                {
                    return NotFound();
                }
                return Ok(login);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<LoginController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Login login)
        {
            try
            {
                _context.Add(login);
                await _context.SaveChangesAsync();

                return Ok(login);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Login login)
        {
            try
            {
                if (id != login.id)
                {
                    return BadRequest();
                }
                _context.Update(login);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Usuario actualizado exitosamente!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var login = await _context.Login.FindAsync(id);

                if (login == null)
                {
                    return NotFound();
                }

                _context.Login.Remove(login);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Usuario elminado exitosamente!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
