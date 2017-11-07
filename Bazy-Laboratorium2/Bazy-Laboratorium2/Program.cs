using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazy_Laboratorium2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                DbSet<Blog> blogs = db.Blogs;
                DbSet<User> users = db.Users;
                DbSet<Author> authors = db.Authors;

                //var author = new Author { UserName = "Nimbo", BlogId = 1 };
                //db.Authors.Add(author);
                //db.SaveChanges();

                 var query = from a in authors
                             join b in blogs
                             on a.BlogId equals b.BlogId into blogGroup
                             join u in users
                             on a.UserName equals u.UserName into userGroup
                             select new
                             {
                                 UserName = a.UserName,
                                 TheUser = userGroup,
                                 BlogsCount = blogGroup.Count(),
                                 UserBlogs = blogGroup
                             };

                foreach (var group in query)
                {
                    Console.WriteLine($"UserName: {group.UserName}");
                    Console.WriteLine($"BlogsCount: {group.BlogsCount}");
                    foreach (var theUser in group.TheUser)
                    {
                        Console.WriteLine($"UserDescription: {theUser.Description}");
                    }
                    foreach(var theBlogs in group.UserBlogs)
                    {
                        Console.WriteLine($"    BlogId: {theBlogs.BlogId}");
                        Console.WriteLine($"    BlogName: {theBlogs.Name}");
                        Console.WriteLine($"    BlogURL: {theBlogs.Url}");
                    }
                    Console.WriteLine("");
                }

                var myForm = new BlogForm();
                myForm.ShowDialog();

                //Console.WriteLine("");
                //AllBlogsPosts allBlogsPosts = new AllBlogsPosts(db);
                //allBlogsPosts.ShowAllBlogsAndPostsEagerLoading();
                //allBlogsPosts.ShowAllBlogsAndPostsLazyLoading();

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
