using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codFirst.Entities
{
    class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Author_Id { get; set; }

        public Author Author { get; set; }

        public int Publisher_Id { get; set; }

        public Publisher Publisher { get; set; }
    }
}
