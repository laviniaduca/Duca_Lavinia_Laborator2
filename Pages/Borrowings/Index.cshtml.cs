using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Duca_Lavinia_Laborator2.Data;
using Duca_Lavinia_Laborator2.Models;

namespace Duca_Lavinia_Laborator2.Pages.Borrowings
{
    public class IndexModel : PageModel
    {
        private readonly Duca_Lavinia_Laborator2.Data.Duca_Lavinia_Laborator2Context _context;

        public IndexModel(Duca_Lavinia_Laborator2.Data.Duca_Lavinia_Laborator2Context context)
        {
            _context = context;
        }

        public IList<Borrowing> Borrowing { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Borrowing != null)
            {
                Borrowing = await _context.Borrowing
                .Include(b => b.Book)
                    .ThenInclude(b => b.Author )
                .Include(b => b.Member).ToListAsync();
            }
        }
    }
}
