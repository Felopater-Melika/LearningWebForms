using System.Data.Entity;

namespace LearningWebForms.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("LearningWebForms")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}