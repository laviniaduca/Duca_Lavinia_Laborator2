﻿using Duca_Lavinia_Laborator2.Models;

namespace Duca_Lavinia_Laborator2.Models.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
