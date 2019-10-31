using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReaderKnight_API.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Pages { get; set; }
        public double Price { get; set; }
    }
}
