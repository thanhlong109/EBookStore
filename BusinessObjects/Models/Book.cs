using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public int PublisherId { get; set; }
        public decimal Price { get; set; }
        public decimal Advance { get; set; }
        public decimal Royalty { get; set; }
        public int YtdSales { get; set; }
        public string Notes { get; set; }
        public DateTime PublishedDate { get; set; }

        public Publisher Publisher { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }

}
