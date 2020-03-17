namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Parameter)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Type>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Type)
                .HasForeignKey(e => e.IdType);
        }
    }
}
