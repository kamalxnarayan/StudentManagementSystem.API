
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.API.Data;
using StudentManagementSystem.API.Models;

namespace StudentManagementSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 1. GET: Get all students
        // GET /api/Students
        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var students = await _context.Students.ToListAsync();

            return Ok(students);
        }

        // 2. GET: Get student by ID
        // GET /api/Students/1
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound("Student not found");
            }

            return Ok(student);
        }

        // 3. POST: Add a new student
        // POST /api/Students
        [HttpPost]
        public async Task<IActionResult> AddStudent(
            [FromBody] Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            student.Id = 0;

            _context.Students.Add(student);

            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetStudentById),
                new { id = student.Id },
                student);
        }

        // 4. PUT: Update an existing student
        // PUT /api/Students/1
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateStudent(
            int id,
            [FromBody] Student updatedStudent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound("Student not found");
            }

            student.Name = updatedStudent.Name;
            student.Email = updatedStudent.Email;
            student.Age = updatedStudent.Age;
            student.Course = updatedStudent.Course;

            await _context.SaveChangesAsync();

            return Ok(student);
        }

        // 5. DELETE: Delete student by ID
        // DELETE /api/Students/1
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound("Student not found");
            }

            _context.Students.Remove(student);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
