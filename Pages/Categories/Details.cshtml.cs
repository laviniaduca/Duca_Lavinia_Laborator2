﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Duca_Lavinia_Laborator2.Data;
using Duca_Lavinia_Laborator2.Models;

namespace Duca_Lavinia_Laborator2.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Duca_Lavinia_Laborator2.Data.Duca_Lavinia_Laborator2Context _context;

        public DetailsModel(Duca_Lavinia_Laborator2.Data.Duca_Lavinia_Laborator2Context context)
        {
            _context = context;
        }

      public Category Category { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}
