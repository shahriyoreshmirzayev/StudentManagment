using StudentManagment.Shared.Models;
using StudentManagment.Shared.StudentRepository;

namespace StudentManagment.Client.Services
{
    public class SystemCodeDetailService : ISystemCodeDetailRepository
    {
        public Task<SystemCodeDetail> AddAsync(SystemCodeDetail mod)
        {
            throw new NotImplementedException();
        }

        public Task<SystemCodeDetail> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SystemCodeDetail>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<SystemCodeDetail>> GetByCodeAsync(string code)
        {
            throw new NotImplementedException();
        }

        public Task<SystemCodeDetail> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SystemCodeDetail> UpdateAsync(SystemCodeDetail mod)
        {
            throw new NotImplementedException();
        }
    }
}
