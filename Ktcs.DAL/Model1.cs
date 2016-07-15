namespace Ktcs.DAL
{
  using System;
  using System.Data.Entity;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Linq;

  public partial class Model1 : DbContext
  {
    public Model1()
        : base("name=Model1")
    {
    }

    public virtual DbSet<Log> Logs { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Log>()
          .Property(e => e.Thread)
          .IsUnicode(false);

      modelBuilder.Entity<Log>()
          .Property(e => e.Level)
          .IsUnicode(false);

      modelBuilder.Entity<Log>()
          .Property(e => e.Logger)
          .IsUnicode(false);

      modelBuilder.Entity<Log>()
          .Property(e => e.Message)
          .IsUnicode(false);

      modelBuilder.Entity<Log>()
          .Property(e => e.Exception)
          .IsUnicode(false);
    }
  }
}
