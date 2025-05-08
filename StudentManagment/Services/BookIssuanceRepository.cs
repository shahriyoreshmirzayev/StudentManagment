using Microsoft.EntityFrameworkCore;
using StudentManagment.Data;
using StudentManagment.Shared.Models;
using StudentManagment.Shared.StudentRepository;

namespace StudentManagment.Services
{
    public class BookIssuanceRepository : IBookIssuanceRepository
    {
        private readonly ApplicationDbContext _context;

        public BookIssuanceRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<BookIssuance> AddAsync(BookIssuance mod)
        {
            if (mod == null) return null;

            var issuesstatus = await _context.SystemCodeDetails
                .Include(x => x.SystemCode)
                .Where(x => x.SystemCode.Code == "BookIssuanceStatus" && x.Code == "Issued")
                .FirstOrDefaultAsync();

            mod.StatusId = issuesstatus.Id;
            mod.CreatedById = "system";
            mod.CreatedOn = DateTime.UtcNow;

            // ✅ Har bir DateTime ni UTC sifatida belgilaymiz
            mod.IssueDate = DateTime.SpecifyKind(mod.IssueDate, DateTimeKind.Utc);
            mod.DueDate = DateTime.SpecifyKind(mod.DueDate, DateTimeKind.Utc);

            if (mod.ReturnDate.HasValue)
                mod.ReturnDate = DateTime.SpecifyKind(mod.ReturnDate.Value, DateTimeKind.Utc);

            var data = _context.BookIssuanceHistory.Add(mod).Entity;
            await _context.SaveChangesAsync();

            return data;

            // ishlatilayotgan kod
            //var issuesstatus = await _context.SystemCodeDetails
            //    .Include(x => x.SystemCode)
            //    .Where(x => x.SystemCode.Code == "BookIssuanceStatus" && x.Code == "Issued")
            //    .FirstOrDefaultAsync();


            //mod.StatusId = issuesstatus.Id;
            //mod.CreatedById = "system";
            //mod.CreatedOn = DateTime.UtcNow;
            //if (mod == null) return null;

            //var data = _context.BookIssuanceHistory.Add(mod).Entity;
            //await _context.SaveChangesAsync();

            //return data;



            //if (mod == null) return null;

            /* mod.CreatedById = "system";
             mod.CreatedOn = DateTime.UtcNow;

             // DateTime turlarini UTC sifatida belgilash
             mod.IssueDate = DateTime.SpecifyKind(mod.IssueDate, DateTimeKind.Utc);
             mod.ReturnDate = DateTime.SpecifyKind(mod.ReturnDate, DateTimeKind.Utc);

             var data = _context.BookIssuanceHistory.Add(mod).Entity;
             await _context.SaveChangesAsync();

             return data;*/
        }

        public async Task<BookIssuance> DeleteAsync(int id)
        {
            var data = await _context.BookIssuanceHistory.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (data == null) return null;

            _context.BookIssuanceHistory.Remove(data);
            await _context.SaveChangesAsync();

            return data;
        }

        public async Task<List<BookIssuance>> GetAllAsync()
        {
            var data = await _context.BookIssuanceHistory
                                     .Include(x => x.Student)
                                     .Include(x => x.Book)
                                     .Include(x => x.Class)
                                     .Include(x => x.Status)
                                     .ToListAsync();

            return data;
        }

        public async Task<BookIssuance> GetByIdAsync(int id)
        {
            var data = await _context.BookIssuanceHistory.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (data == null) return null;

            return data;
        }

        public async Task<BookIssuance> UpdateAsync(BookIssuance mod)
        {
            if (mod == null) return null;

            var data = _context.BookIssuanceHistory.Update(mod).Entity;
            await _context.SaveChangesAsync();

            return data;
        }
        public async Task<BookIssuance> ReturnUpdateAsync(BookIssuance mod)
        {
            if (mod == null) return null;

            var returnedstatus = await _context.SystemCodeDetails
                .Include(x => x.SystemCode)
                .Where(x => x.SystemCode.Code == "BookIssuanceStatus" && x.Code == "Returned")
                .FirstOrDefaultAsync();
            mod.StatusId = returnedstatus.Id;
            var data = _context.BookIssuanceHistory.Update(mod).Entity;
            await _context.SaveChangesAsync();

            return data;
        }
    }
}
