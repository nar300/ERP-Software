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
    public class LeavesController : ControllerBase
    {
        private readonly ILeaveRepo _context;

        public LeavesController(ILeaveRepo context)
        {
            _context = context;
        }

        // GET: api/Leaves
        [HttpGet]
        public async Task<IEnumerable<Leave>> GetLeaves()
        {
            return await _context.GetAll();
        }

        // GET: api/Leaves/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLeave([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var leave = await _context.GetById(id);

            if (leave == null)
            {
                return NotFound();
            }

            return Ok(leave);
        }

        // PUT: api/Leaves/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLeave([FromRoute] int id, [FromBody] Leave leave)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != leave.Id)
            {
                return BadRequest();
            }

           await _context.Update(leave,id);

           

            return NoContent();
        }

        // POST: api/Leaves
        [HttpPost]
        public async Task<IActionResult> PostLeave([FromBody] Leave leave)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           await _context.Create(leave);
            

            return CreatedAtAction("GetLeave", new { id = leave.Id }, leave);
        }

        // DELETE: api/Leaves/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLeave([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var leave = await _context.GetById(id);
            if (leave == null)
            {
                return NotFound();
            }

           await _context.Delete(leave);
            

            return Ok(leave);
        }

        
    }
}