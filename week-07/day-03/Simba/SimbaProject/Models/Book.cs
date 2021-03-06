﻿using System;
using System.Collections.Generic;

namespace SimbaProject.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public ICollection<BookReader> BookReaders { get; set; } = new List<BookReader>();
        public int TotalCopies { get; set; }
        public int BorrowedCopies { get; set; }
        public Author Author { get; set; }
        public long? AuthorId { get; set; }
    }
}
