using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Duca_Lavinia_Laborator2.Data;
using Duca_Lavinia_Laborator2.Models;
using Duca_Lavinia_Laborator2.Models.ViewModels;

namespace Duca_Lavinia_Laborator2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Duca_Lavinia_Laborator2.Data.Duca_Lavinia_Laborator2Context _context;

        public IndexModel(Duca_Lavinia_Laborator2.Data.Duca_Lavinia_Laborator2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public CategoryIndexData CategoryData { get; set; }
        public int CategoryID { get; set; }
        public int BookID { get; set; }


        public async Task OnGetAsync(int? id, int? bookID)
        {
            CategoryData = new CategoryIndexData();
            CategoryData.Categories = await _context.Category
                .Include(i => i.BookCategories)
                    .ThenInclude(c => c.Book)
                    .ThenInclude(b => b.Author) // eager loading la Author
                .OrderBy(i => i.CategoryName)
                .ToListAsync();

        if (id != null)
        {
                CategoryID = id.Value;
                Category category = CategoryData.Categories
                    .Where(i => i.ID == id.Value).Single();

                if (category!= null)
                {
                    // accesam books pentru categoria selectata prin navigation property de la BookCategories
                    CategoryData.Books = category.BookCategories.Select(c => c.Book).ToList();
                }
        }

        }
    }
}
