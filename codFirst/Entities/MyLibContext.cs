using System;
using System.Data.Entity;
using System.Linq;

namespace codFirst.Entities
{
    class MyLibContext : DbContext
    {
        // Контекст настроен для использования строки подключения "MyLibContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "codFirst.Entities.MyLibContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "MyLibContext" 
        // в файле конфигурации приложения.
        public MyLibContext()
            : base("name=MyLibContext")
        {
            //CreateDatabaseIfNotExists
            //DropCreateDatabaseAlways
            //DropCreateDatabaseIfModelChanges

            //Database.SetInitializer<MyLibContext>(new CreateDatabaseIfNotExists<MyLibContext>());
            Database.SetInitializer<MyLibContext>(new MyLibContextInitializer());
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Author> Authors { get; set; } 
        public virtual DbSet<Publisher> Publishers { get; set; } 
        public virtual DbSet<Book> Books { get; set; } 
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}