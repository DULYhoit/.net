using AspnetNote.MVC6.Models;
using Microsoft.EntityFrameworkCore;

namespace AspnetNote.MVC6.DataContext
{
    public class AspnetNoteDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=AspnetNoteDb;User Id=sa;Password=mssql;Encrypt=false;");
        }
    }
}
