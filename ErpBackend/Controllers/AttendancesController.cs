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
    public class AttendancesController : ControllerBase
    {
        private readonly IAttendanceRepo _context;

        public AttendancesController(IAttendanceRepo context)
        {
            _context = context;
        }

        // GET: api/Attendances
        [HttpGet]
        public async Task<IEnumerable<Attendance>> GetAttendances()
        {
            return await _context.GetAll();
        }

        // GET: api/Attendances/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAttendance([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var attendance = await _context.GetById(id);

            if (attendance == null)
            {
                return NotFound();
            }

            return Ok(attendance);
        }

        // PUT: api/Attendances/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAttendance([FromRoute] int id, [FromBody] Attendance attendance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != attendance.id)
            {
                return BadRequest();
            }

           await _context.Update(attendance, id);

          

            return NoContent();
        }

        // POST: api/Attendances
        [HttpPost]
        public async Task<IActionResult> PostAttendance([FromBody] Attendance attendance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           await  _context.Create(attendance);
           

            return CreatedAtAction("GetAttendance", new { id = attendance.id }, attendance);
        }

        // DELETE: api/Attendances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAttendance([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var attid = await _context.GetById(id);
            
            if (attid == null)
            {
                return NotFound();
            }

            var attendance = await _context.Delete(attid);
            

            return Ok(attendance);
        }

       
    }
}