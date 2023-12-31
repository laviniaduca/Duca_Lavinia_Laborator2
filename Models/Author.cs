﻿using System.ComponentModel.DataAnnotations;

namespace Duca_Lavinia_Laborator2.Models
{
    public class Author
    {
        public int ID { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set;}

        [Display(Name = "Full Name")]
        public string FullName => FirstName + " " + LastName;
    }
}
