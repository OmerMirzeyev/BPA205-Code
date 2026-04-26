using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Library_System.Models
{
    public record Book
    {
        public string Title { get; init; }
        public string Author { get; init; }
        public BookCode Code { get; init; }
        public DateTime CreatedAt { get; init; }

    }
}
