using CodePulse.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

<<<<<<< HEAD
=======

>>>>>>> 6297efd776b649db9cbcfcd4397c6e7526fdcb7b
namespace CodePulse.API.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) { 
        
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
<<<<<<< HEAD

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
=======
>>>>>>> 6297efd776b649db9cbcfcd4397c6e7526fdcb7b
    }
}
