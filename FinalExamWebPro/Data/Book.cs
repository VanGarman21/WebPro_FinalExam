using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExamWebPro.Data
{
    public class Book
    {
        public int Id { get; set; }
        public String BookIsbn { get; set; }
        public String BookTitle { get; set; }
        public int BookPrice { get; set; }

        public Book()
        {

        }
    }
}
