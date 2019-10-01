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
using ErpBackend.Utils;

namespace ErpBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeRepo _context;

        public EmployeesController(EmployeeRepo context)
        {
            _context = context;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
          //  DataGenerator dg = new DataGenerator(_context);
          //await  dg.Fakedata();
            return await _context.GetAll();
        }

        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employee = await _context.GetById(id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // PUT: api/Employees/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee([FromRoute] int id, [FromBody] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employee.Id)
            {
                return BadRequest();
            }

            var Empupdate = await _context.Update(employee, id);


            return Ok(Empupdate);
        }

        // POST: api/Employees
        [HttpPost]
        public async Task<IActionResult> PostEmployee([FromBody] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _context.Create(employee);


            return CreatedAtAction("GetEmployee", new { id = employee.Id }, employee);
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var emp = await _context.GetById(id);

            if (emp == null)
            {
                return NotFound();
            }

            var employee = await _context.Delete(emp);

            return Ok(employee);
        }

    }
}