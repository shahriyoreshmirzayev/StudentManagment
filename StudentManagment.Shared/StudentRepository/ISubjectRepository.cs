using StudentManagment.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Shared.StudentRepository
{
    public interface ISubjectRepository
    {
        Task<Subject> AddAsync(Subject mod);

        Task<Subject> UpdateAsync(Subject mod);

        Task<Subject> DeleteAsync(int id);

        Task<List<Subject>> GetAllAsync();

        Task<Subject> GetByIdAsync(int id);
    }
}
