using System;
using System.Linq;

namespace EFCoreSample
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTheDatabase();
            // AddBooks();
            Query();
        }

        private static void Query()
        {
            using (var context = new BooksContext())
            {
                var q = context.Books.Where(b => b.Title.StartsWith("Pro"));
                foreach (var b in q)
                {
                    Console.WriteLine($"{b.Title} {b.Publisher}");
                }
            }
        }

        private static void AddBooks()
        {
            using (var context = new BooksContext())
            {
                context.Books.Add(new Book { Title = "Professional C# 7", Publisher = "Wrox Press" });
                context.Books.Add(new Book { Title = "Professional C# 8", Publisher = "Wrox Press" });

                int recordsChanged = context.SaveChanges();
                Console.WriteLine($"{recordsChanged} changed");
            }
        }

        private static void CreateTheDatabase()
        {
            using (var context = new BooksContext())
            {
                bool created = context.Database.EnsureCreated();
                Console.WriteLine($"database {created} created");
            }
        }
    }
}
