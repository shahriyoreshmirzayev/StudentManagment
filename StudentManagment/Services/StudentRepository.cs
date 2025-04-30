using StudentManagment.Data;
using StudentManagment.Shared.Models;
using StudentManagment.Shared.StudentRepository;

namespace StudentManagment.Services
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context)
        {
            this._context = context;
        }


        public Task<Student> AddStudentAsync(Student student)
        {
            throw new NotImplementedException();
        }

        public Task<Student> DeleteStudentAsync(int studentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> GetAllStudentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudentByIdAsync(int studentId)
        {
            throw new NotImplementedException();
        }

        public Task<Student> UpdateStudentAsync(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
