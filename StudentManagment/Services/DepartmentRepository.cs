using Microsoft.EntityFrameworkCore;
using StudentManagment.Data;
using StudentManagment.Shared.Models;
using StudentManagment.Shared.StudentRepository;

namespace StudentManagment.Services
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _context;

        public DepartmentRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<Department> AddAsync(Department mod)
        {
            mod.CreatedById = "Macro Code";
            mod.CreatedOn = DateTime.UtcNow;

            if (mod == null) return null;

            var data = _context.Departments.Add(mod).Entity;
            await _context.SaveChangesAsync();

            return data;


            //if (mod == null) return null;
            //// Himoya: CreatedById bo‘sh bo‘lsa, tizim nomidan yozamiz
            //if (string.IsNullOrEmpty(mod.CreatedById))
            //    mod.CreatedById = "system"; // yoki istalgan default user id
            //mod.CreatedOn = DateTime.UtcNow;
            //var data = _context.Books.Add(mod).Entity;
            //await _context.SaveChangesAsync();
            //return data;
        }

        public async Task<Department> DeleteAsync(int id)
        {
            var data = await _context.Departments.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (data == null) return null;

            _context.Departments.Remove(data);
            await _context.SaveChangesAsync();

            return data;
        }

        public async Task<List<Department>> GetAllAsync()
        {
            var data = await _context.Departments.ToListAsync();
            return data;
        }

        public async Task<Department> GetByIdAsync(int id)
        {
            var data = await _context.Departments.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (data == null) return null;

            return data;
        }

        public async Task<Department> UpdateAsync(Department mod)
        {
            if (mod == null) return null;

            var data = _context.Departments.Update(mod).Entity;
            await _context.SaveChangesAsync();

            return data;
        }
    }
}
