using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Duca_Lavinia_Laborator2.Models;

namespace Duca_Lavinia_Laborator2.Data
{
    public class Duca_Lavinia_Laborator2Context : DbContext
    {
        public Duca_Lavinia_Laborator2Context (DbContextOptions<Duca_Lavinia_Laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Duca_Lavinia_Laborator2.Models.Book> Book { get; set; } = default!;

        public DbSet<Duca_Lavinia_Laborator2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Duca_Lavinia_Laborator2.Models.Author>? Author { get; set; }

        public DbSet<Duca_Lavinia_Laborator2.Models.Category>? Category { get; set; }
    }
}
