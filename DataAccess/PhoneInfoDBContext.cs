using Microsoft.EntityFrameworkCore;
using PhoneInfo.ApplicationLogic.DataModel;


namespace PhoneInfo.DataAccess
{
    public class PhoneInfoDBContext : DbContext
    {
        public PhoneInfoDBContext(DbContextOptions<PhoneInfoDBContext> options) : base(options)
        {
        }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<TipUs> TipUs { get; set; }
        public DbSet<User> User { get; set; }
    }
}
