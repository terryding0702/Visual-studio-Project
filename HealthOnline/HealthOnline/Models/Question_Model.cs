namespace HealthOnline.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Question_Model : DbContext
    {
        public Question_Model()
            : base("name=Question_Model")
        {
        }

        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
