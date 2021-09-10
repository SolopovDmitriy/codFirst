using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codFirst.Entities
{
    class MyLibContextInitializer: DropCreateDatabaseAlways<MyLibContext>
    {
        protected override void Seed(MyLibContext myLibContext)
        {
            List<Author> authors = new List<Author>();
            authors.Add(new Author { Id = 1, Fio = "Николдя Гоголя", BirthDate = new DateTime(1985, 10, 13) });
            authors.Add(new Author { Fio = "Дункан Мак Клауд", BirthDate = new DateTime(1315, 5, 5) });
            authors.Add(new Author { Fio = "Дженифер Лопесс", BirthDate = new DateTime(1980, 4, 13) });
            authors.Add(new Author { Fio = "Чак Норрис", BirthDate = new DateTime(1964, 1, 3) });

            myLibContext.Authors.AddRange(authors);

            base.Seed(myLibContext);
        }
    }
}
