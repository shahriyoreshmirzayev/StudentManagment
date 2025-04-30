using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagment.Shared.Models;
using StudentManagment.Shared.StudentRepository;

namespace StudentManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
             this._studentRepository = studentRepository;
        }

        [HttpGet("All-Students")]
        public async Task<ActionResult<List<Student>>> GetAllStudentsAsync()
        {
            var students = await _studentRepository.GetAllStudentsAsync();
            
            return Ok(students);
        }


        [HttpGet("Single-Students/{id}")]
        public async Task<ActionResult<Student>> GetSingleStudentAsync(int id)
        {
            var student = await _studentRepository.GetStudentByIdAsync(id);

            return Ok(student);
        }


        [HttpGet("Single-Students/{id}")]
        public async Task<ActionResult<Student>> AddNewStudentAsync(Student student)
        {
            var newstudent = await _studentRepository.AddStudentAsync(student);

            return Ok(newstudent);
        }


        [HttpGet("Delete-Students/{id}")]
        public async Task<ActionResult<Student>> DeleteStudentAsync(int id)
        {
            var deletestudent = await _studentRepository.DeleteStudentAsync(id);

            return Ok(deletestudent);
        }
    }
}
