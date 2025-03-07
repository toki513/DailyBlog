using DailyBlog.Models.Domain;
using DailyBlog.Models.NewFolder;
using Microsoft.EntityFrameworkCore;

namespace DailyBlog.Data
{
    public class BloggieDbContext : DbContext
    {
        public BloggieDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
