using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRezor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRezor.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Book> Books { get; set; }
        public async Task OnGet()
        {
            Books = await _db.Book.ToListAsync();
        }
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var bookFromDb = await _db.Book.FindAsync(id);
            if(bookFromDb == null)
            {
                return NotFound();
            }
            _db.Book.Remove(bookFromDb);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
