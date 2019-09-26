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
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepo _context;

        public DepartmentsController(IDepartmentRepo context)
        {
            _context = context;
        }

        // GET: api/Departments
        [HttpGet]
        public async Task <IEnumerable<Department>> GetDepartments()
        {
            return await _context.GetAll();
        }

        // GET: api/Departments/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartment([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var department = await _context.GetById(id);

            if (department == null)
            {
                return NotFound();
            }

            return Ok(department);
        }

        // PUT: api/Departments/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartment([FromRoute] int id, [FromBody] Department department)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != department.Id)
            {
                return BadRequest();
            }

           await _context.Update(department, id);

           

            return NoContent();
        }

        // POST: api/Departments
        [HttpPost]
        public async Task<IActionResult> PostDepartment([FromBody] Department department)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _context.Create(department);
           

            return CreatedAtAction("GetDepartment", new { id = department.Id }, department);
        }

        // DELETE: api/Departments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var department = await _context.GetById(id);
            if (department == null)
            {
                return NotFound();
            }

           await  _context.Delete(department);
            

            return Ok(department);
        }

      
    }
}