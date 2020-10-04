namespace LanguageMastery.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LanguageMastery_Model : DbContext
    {
        public LanguageMastery_Model()
            : base("name=LanguageMastery_Model")
        {
        }

        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
