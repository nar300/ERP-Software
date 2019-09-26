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
    public class SalariesController : ControllerBase
    {
        private readonly ISalaryRepo _context;

        public SalariesController(ISalaryRepo context)
        {
            _context = context;
        }

        // GET: api/Salaries
        [HttpGet]
        public async Task< IEnumerable<Salary>> GetSalaries()
        {
            return await _context.GetAll();
        }

        // GET: api/Salaries/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSalary([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var salary = await _context.GetById(id);

            if (salary == null)
            {
                return NotFound();
            }

            return Ok(salary);
        }

        // PUT: api/Salaries/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalary([FromRoute] int id, [FromBody] Salary salary)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != salary.Id)
            {
                return BadRequest();
            }

          await  _context.Update(salary, id);

           

            return NoContent();
        }

        // POST: api/Salaries
        [HttpPost]
        public async Task<IActionResult> PostSalary([FromBody] Salary salary)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

          await  _context.Create(salary);
           

            return CreatedAtAction("GetSalary", new { id = salary.Id }, salary);
        }

        // DELETE: api/Salaries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalary([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var salary = await _context.GetById(id);
            if (salary == null)
            {
                return NotFound();
            }

          await  _context.Delete(salary);
            

            return Ok(salary);
        }

       
    }
}