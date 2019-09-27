using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ErpBackend.Data;
using ErpBackend.Models;
using ErpBackend.Repository;

namespace ErpBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayRollsController : ControllerBase
    {
        private readonly IPayRollRepo _context;

        public PayRollsController(IPayRollRepo context)
        {
            _context = context;
        }

        // GET: api/PayRolls
        [HttpGet]
        public async Task< IEnumerable<PayRoll>> GetPayRolls()
        {
            return await _context.GetAll();
        }

        // GET: api/PayRolls/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPayRoll([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var payRoll = await _context.GetById(id);

            if (payRoll == null)
            {
                return NotFound();
            }

            return Ok(payRoll);
        }

        // PUT: api/PayRolls/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayRoll([FromRoute] int id, [FromBody] PayRoll payRoll)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != payRoll.Id)
            {
                return BadRequest();
            }

            await _context.Update(payRoll,id);

           

            return NoContent();
        }

        // POST: api/PayRolls
        [HttpPost]
        public async Task<IActionResult> PostPayRoll([FromBody] PayRoll payRoll)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _context.Create(payRoll);
            

            return CreatedAtAction("GetPayRoll", new { id = payRoll.Id }, payRoll);
        }

        // DELETE: api/PayRolls/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePayRoll([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var payRoll = await _context.GetById(id);
            if (payRoll == null)
            {
                return NotFound();
            }

          await  _context.Delete(payRoll);
            

            return Ok(payRoll);
        }

       
    }
}