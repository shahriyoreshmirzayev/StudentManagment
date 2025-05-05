using StudentManagment.Shared.Models;
using StudentManagment.Shared.StudentRepository;

namespace StudentManagment.Client.Services
{
    public class SubjectService : ISubjectRepository
    {
        public Task<Subject> AddAsync(Subject mod)
        {
            throw new NotImplementedException();
        }

        public Task<Subject> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Subject>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Subject> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Subject> UpdateAsync(Subject mod)
        {
            throw new NotImplementedException();
        }
    }
}
