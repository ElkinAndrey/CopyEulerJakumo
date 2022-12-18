using EulerJakumo.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace EulerJakumo.Models
{
    /// <summary>
    /// Вспомогательный класс для создания таблицы для страницы О проекте
    /// </summary>
    [Table("AboutProduct")]
    public class AboutProduct : TextDesign
    {
    }

    /// <summary>
    /// Вспомогательный класс для создания таблицы для страницы Обратная связь
    /// </summary>
    [Table("Feedback")]
    public class Feedback : TextDesign
    {
    }

    public class ApplicationDbContext : DbContext
    {
        public DbSet<AboutProduct> AboutProductText { get; set; }
        public DbSet<Feedback> FeedbackText { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Problem>()
                .HasMany(p => p.Text);
        }
    }
}
