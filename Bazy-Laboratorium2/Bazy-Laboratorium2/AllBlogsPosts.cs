using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazy_Laboratorium2
{
    class AllBlogsPosts
    {
        private BloggingContext bContext;

        public AllBlogsPosts(BloggingContext bContext)
        {
            this.bContext = bContext;
        }

        public void ShowAllBlogsAndPostsJoinQuery()
        {
            DbSet<Blog> blogs = this.bContext.Blogs;
            DbSet<Post> posts = this.bContext.Posts;

            var query = from b in blogs
                        join p in posts
                        on b.BlogId equals p.BlogId into blogGroup
                        select new
                        {
                            BlogName = b.Name,
                            PostsCount = blogGroup.Count(),
                            Posts = blogGroup
                        };

            foreach (var group in query)
            {
                Console.WriteLine($"BlogName: {group.BlogName}");
                Console.WriteLine($"PostsCount: {group.PostsCount}");
                foreach (var post in group.Posts)
                {
                    Console.WriteLine($"    PostName: {post.Title}");
                    Console.WriteLine($"    PostDescription: {post.Content}");
                }
                Console.WriteLine("");
            }
        }

        public void ShowAllBlogsAndPostsJoinMethod()
        {
            DbSet<Blog> blogs = this.bContext.Blogs;
            DbSet<Post> posts = this.bContext.Posts;

            var query = blogs.GroupJoin(posts, blog => blog.BlogId, post => post.BlogId,
                        (blog, blogGroup) => new
                        {
                            BlogName = blog.Name,
                            PostsCount = blogGroup.Count(),
                            Posts = blogGroup
                        });

            foreach (var group in query)
            {
                Console.WriteLine($"BlogName: {group.BlogName}");
                Console.WriteLine($"PostsCount: {group.PostsCount}");
                foreach (var post in group.Posts)
                {
                    Console.WriteLine($"    PostName: {post.Title}");
                    Console.WriteLine($"    PostDescription: {post.Content}");
                }
                Console.WriteLine("");
            }
        }

        public void ShowAllBlogsAndPostsNPQuery()
        {
            DbSet<Blog> blogs = this.bContext.Blogs;

            var query = from b in blogs
                        select new
                        {
                            BlogName = b.Name,
                            PostsCount = b.Posts.Count(),
                            Posts = b.Posts
                        };

            foreach (var group in query)
            {
                Console.WriteLine($"BlogName: {group.BlogName}");
                Console.WriteLine($"PostsCount: {group.PostsCount}");
                foreach (var post in group.Posts)
                {
                    Console.WriteLine($"    PostName: {post.Title}");
                    Console.WriteLine($"    PostDescription: {post.Content}");
                }
                Console.WriteLine("");
            }
        }

        public void ShowAllBlogsAndPostsLazyLoading()
        {
            foreach (var blog in this.bContext.Blogs)
            {
                int counter = this.bContext.Entry(blog).Collection(b => b.Posts).Query().Count();
                this.bContext.Entry(blog).Collection(b => b.Posts).Load();
            }
        }

        public void ShowAllBlogsAndPostsEagerLoading()
        {
            DbSet<Blog> blogs = this.bContext.Blogs;
            DbSet<Post> posts = this.bContext.Posts;

            var query = blogs.Include(p => p.Posts).ToList();

            foreach (var group in query)
            {
                Console.WriteLine($"BlogName: {group.Name}");
                Console.WriteLine($"PostsCount: {group.Posts.Count}");
                foreach (var post in group.Posts)
                {
                    Console.WriteLine($"    PostName: {post.Title}");
                    Console.WriteLine($"    PostDescription: {post.Content}");
                }
                Console.WriteLine("");
            }
        }
    }
}
