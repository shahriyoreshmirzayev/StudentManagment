using StudentManagment.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Shared.StudentRepository
{
    public interface IBookIssuanceRepository
    {
        Task<BookIssuance> AddAsync(BookIssuance mod);

        Task<BookIssuance> UpdateAsync(BookIssuance mod);

        Task<BookIssuance> DeleteAsync(int id);

        Task<List<BookIssuance>> GetAllAsync();

        Task<BookIssuance> GetByIdAsync(int id);
    }
}
