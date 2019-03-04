using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;

namespace LinqSample
{

        static class MyCollectionExtensions
        {
            public static IEnumerable<T> Where1<T>(this IEnumerable<T> source, Func<T, bool> pred)
            {
                foreach (T item in source)
                {
                    if (pred(item))
                        yield return item;
                }
            }
        }


    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "James", "John", "Niki", "Gerhard", "Juan" };

            // LINQ query
            var q1 = from n in names
                     where n.StartsWith("J")
                     orderby n
                     select n;

            foreach (var name in q1)
            {
                Console.WriteLine(name);
            }

            var enumerator = q1.GetEnumerator();
            while(enumerator.MoveNext())
            {
                string current = enumerator.Current;
                Console.WriteLine(current);
            }

            var q2 = names.AsParallel().Where(n => n.StartsWith("J"))
                .OrderBy(n => n).Select(n => n);

            var queryable = names.AsQueryable();
            var q3 = queryable.Where(n => n.StartsWith("J"))
                .OrderBy(n => n).Select(n => n);

            foreach (var item in q3)
            {

            }

            Func<string, bool> f1 = (s) => s.StartsWith("J");

            bool result = f1("Jochen");

            Expression<Func<string, bool>> ex1 = (s) => s.StartsWith("J");


        }

        private static void Client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
