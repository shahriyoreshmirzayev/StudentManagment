using StudentManagment.Shared.Models;

namespace StudentManagment.Shared.StudentRepository
{
    public interface IDepartmentRepository
    {
        Task<Department> AddAsync(Department mod);

        Task<Department> UpdateAsync(Department mod);

        Task<Department> DeleteAsync(int id);

        Task<List<Department>> GetAllAsync();

        Task<Department> GetByIdAsync(int id);
    }
}
