using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Entity_Frameworks_Assignment_1
{
    namespace YourNamespace
    {
        public class AppDbContext : DbContext
        {
            public DbSet<User> Users { get; set; }
            public DbSet<BlogType> BlogTypes { get; set; }
            public DbSet<PostType> PostTypes { get; set; }
            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Post> Posts { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<User>().HasData(
                    new User { UserId = 1, UserName = "Gurvinder Singh", Email = "gurvindersingh@gmail.com", PhoneNumber = "854-658-9698" },
                    new User { UserId = 2, UserName = "Ramandeep Kaur", Email = "ramandeepkaur@gmail.com", PhoneNumber = "545-498-4654" },
                    new User { UserId = 3, UserName = "Kanika", Email = "kanika@gmail.com", PhoneNumber = "218-913-5456" }
                );
            }
        }
    }


}
