﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Duca_Lavinia_Laborator2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 3)]
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }

        public Publisher? Publisher { get; set; } // proprietate de navigare

        public int? AuthorID { get; set; }

        public Author? Author { get; set; } // proprietatea de navigare


        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
