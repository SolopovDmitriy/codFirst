using codFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyLibContext myLibContext = new MyLibContext())
            {
                Console.WriteLine("Authors: " + myLibContext.Authors.Count());
                Console.WriteLine("Publishers: " + myLibContext.Publishers.Count());
                Console.WriteLine("Books:" + myLibContext.Books.Count());

                /*Author author = new Author();
                author.BirthDate = DateTime.Now;
                myLibContext.Authors.Add(author);
                myLibContext.SaveChanges();*/
            }

        }
    }
}
