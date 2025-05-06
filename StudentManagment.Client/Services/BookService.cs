using StudentManagment.Shared.Models;
using StudentManagment.Shared.StudentRepository;

namespace StudentManagment.Client.Services
{
    public class BookService : IBookRepository
    {
        public Task<Book> AddAsync(Book mod)
        {
            throw new NotImplementedException();
        }

        public Task<Book> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> UpdateAsync(Book mod)
        {
            throw new NotImplementedException();
        }
    }
}
