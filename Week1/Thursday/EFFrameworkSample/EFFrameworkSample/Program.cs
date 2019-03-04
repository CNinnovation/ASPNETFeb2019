using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFrameworkSample
{
    class Program
    {
        static void Main(string[] args)
        {
            AddBooks();
        }

        private static void AddBooks()
        {
            using (var context = new BooksSample2Entities())
            {
                context.Books.Add(new Book { Title = "Enterprise Services", Publisher = "AWL" });
                int changed = context.SaveChanges();
            }
        }
    }
}
