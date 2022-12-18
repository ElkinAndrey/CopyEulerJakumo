using EulerJakumo.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace EulerJakumo.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<TextDesign> AboutProductText { get; set; }
        public DbSet<TextDesign> FeedbackText { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
