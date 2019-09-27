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
    public class DesignationsController : ControllerBase
    {
        private readonly IDesignationRepo _context;

        public DesignationsController(IDesignationRepo context)
        {
            _context = context;
        }

        // GET: api/Designations
        [HttpGet]
        public async Task< IEnumerable<Designation>> GetDesignations()
        {
            return await _context.GetAll();
        }

        // GET: api/Designations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDesignation([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var designation = await _context.GetById(id);

            if (designation == null)
            {
                return NotFound();
            }

            return Ok(designation);
        }

        // PUT: api/Designations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDesignation([FromRoute] int id, [FromBody] Designation designation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != designation.Id)
            {
                return BadRequest();
            }

          await  _context.Update(designation,id);

            
            

            return NoContent();
        }

        // POST: api/Designations
        [HttpPost]
        public async Task<IActionResult> PostDesignation([FromBody] Designation designation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           await  _context.Create(designation);
            

            return CreatedAtAction("GetDesignation", new { id = designation.Id }, designation);
        }

        // DELETE: api/Designations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDesignation([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var designation = await _context.GetById(id);
            if (designation == null)
            {
                return NotFound();
            }

           await _context.Delete(designation);
            

            return Ok(designation);
        }

        
    }
}