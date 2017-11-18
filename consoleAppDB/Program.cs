using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAppDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BloggingContext db=new BloggingContext())
            {

                    db.Blog.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                    var count = db.SaveChanges();
                    Console.WriteLine("{0} records saved to database", count);

                    Console.WriteLine();
                    Console.WriteLine("All blogs in database:");
                    foreach (var blog in db.Blog)
                    {
                        Console.WriteLine(" - {0}", blog.Url);
                    }


                List<Post> ps = db.Post.ToList();
                Console.WriteLine(ps.Count());
                foreach(var itm in ps)
                {
                    Console.WriteLine(itm.Title);
                   
                }
                Console.ReadKey();
            }
        }
    }
}
