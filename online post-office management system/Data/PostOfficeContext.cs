using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Online_Post_Office_Management_System.Models;

namespace Online_Post_Office_Management_System.Data
{
    public class PostOfficeContext : IdentityDbContext<User>
    {
        public PostOfficeContext(DbContextOptions<PostOfficeContext> options)
            : base(options)
        {
        }

        // Các DbSet cho các mô hình dữ liệu
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ChargeOnDistance> Charges { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Cấu hình thêm cho các thực thể nếu cần
        }
    }
}
