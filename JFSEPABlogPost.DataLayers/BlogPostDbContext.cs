using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JFSEPABlogPost.Models
{
    public class BlogPostDbContext :DbContext
    {
        public BlogPostDbContext(
            DbContextOptions<BlogPostDbContext> dbContextOptions)
            : base(dbContextOptions) 
        {}

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Comments> CommentsMsg { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogPost>()
                .HasKey(x => x.PostID);
            modelBuilder.Entity<Comments>()
                .HasKey(x => x.CommId);
        }
    }
}
