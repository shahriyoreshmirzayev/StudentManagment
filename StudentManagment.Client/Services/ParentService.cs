using StudentManagment.Shared.Models;
using StudentManagment.Shared.StudentRepository;

namespace StudentManagment.Client.Services
{
    public class ParentService : IParentRepository
    {
        public Task<Parent> AddAsync(Parent mod)
        {
            throw new NotImplementedException();
        }

        public Task<Parent> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Parent>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Parent> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Parent> UpdateAsync(Parent mod)
        {
            throw new NotImplementedException();
        }
    }
}
