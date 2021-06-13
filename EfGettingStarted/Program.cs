using EfGettingStarted.Data;
using EfGettingStarted.Models;
using System;
using System.Linq;
using static System.Console;

namespace EfGettingStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");

            using (var db = new ApplicationDbContext())
            {
                // Create
                WriteLine("Inserting a new blog");
                db.Add(new Blog { Url = "https://blog.msdn.com/adonet" });
                db.SaveChanges();

                // Read
                WriteLine("Quering for a blog");
                var blog = db.Blogs
                    .OrderBy(b => b.BlogId)
                    .First();

                // Update
                WriteLine("Updating the blog and adding a post");
                blog.Url = "https://devblogs.msdn.com/adonet";
                blog.Posts.Add(new Post { Title = "Hello World!", Content = "I wrote an app using EF Core" });
                db.SaveChanges();

                // Delete
                WriteLine("Deleting the blog");
                db.Remove(blog);
                db.SaveChanges();
            }
        }
    }
}
