using StudentManagment.Shared.Models;
using StudentManagment.Shared.StudentRepository;

namespace StudentManagment.Client.Services
{
    public class TeacherService : ITeacherRepository
    {
        public Task<Teacher> AddAsync(Teacher mod)
        {
            throw new NotImplementedException();
        }

        public Task<Teacher> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Teacher>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Teacher> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Teacher> UpdateAsync(Teacher mod)
        {
            throw new NotImplementedException();
        }
    }
}
