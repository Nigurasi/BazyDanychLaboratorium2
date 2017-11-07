using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bazy_Laboratorium2
{
    public partial class BlogForm : Form
    {
        BloggingContext bContext = new BloggingContext();
        public BlogForm()
        {
            InitializeComponent();
        }

        private void BlogForm_Load(object sender, EventArgs e)
        {
            
            this.authorsTableAdapter.Fill(this._Bazy_Laboratorium2_BloggingContextDataSet2.Authors);
            bContext.Blogs.Load();
            bContext.Posts.Load();
            this.blogsBindingSource.DataSource = bContext.Blogs.Local.ToBindingList();
            this.postsBindingSource.DataSource = bContext.Posts.Local.ToBindingList();

            // var mostAuthor = bContext.Authors.Include(a => a.BlogId).FirstOrDefault<Author>();

            var blogsWithCount = from blogs in bContext.Blogs
                                 join posts in bContext.Posts
                                 on blogs.BlogId equals posts.BlogId into postsGroup
                                   select new {
                                       BlogName = blogs.Name,
                                       postsCount = postsGroup.Count()
                              };

            var top3Blogs = blogsWithCount.OrderByDescending(author => author.postsCount).Take(3);

            StatsInfo.Text = "";
            foreach(var item in top3Blogs)
            {
                StatsInfo.Text += $"BlogName: {item.BlogName}\n";
                StatsInfo.Text += $"PostsCount: {item.postsCount}\n";
                StatsInfo.Text += "\n";
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int foundBlogId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            var query = from post in bContext.Posts
                        where post.BlogId == foundBlogId
                        select post;

            var queryMethod = bContext.Posts.Where(post => post.BlogId == foundBlogId);
            this.postsBindingSource.DataSource = queryMethod.ToList();

            this.dataGridView2.Refresh();

            var queryMethodAuthors = bContext.Authors.Where(author => author.BlogId == foundBlogId);
            this.authorsBindingSource.DataSource = queryMethodAuthors.ToList();

            this.dataGridView3.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bContext.SaveChanges();
            bContext.Blogs.Load();
            bContext.Posts.Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Show Authors")
            {
                button1.Text = "Show Posts";
                dataGridView3.Visible = true;
                dataGridView2.Visible = false;
            } else
            {
                button1.Text = "Show Authors";
                dataGridView3.Visible = false;
                dataGridView2.Visible = true;
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string topic = wantedTopic.Text;
     
            var blogs = bContext.Blogs.Include("Posts").
                Where(c => c.Name.IndexOf(topic) >= 0).OrderByDescending(c => c.Posts.Count());

            var blogsCount = blogs.Count();
            label2.Text = $"Found Blogs: {blogsCount}";
            foundBlogs.Text = "\n";
           
            foreach (var item in blogs)
            {
                foundBlogs.Text += $"Name: {item.Name}, PostsCount: {item.Posts.Count}";
                foundBlogs.Text += "\n";
            }
        }
    }
}
