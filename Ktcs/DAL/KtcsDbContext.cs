using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Ktcs.DAL
{
  public class KtcsDbContext : DbContext
  {
    public KtcsDbContext() : base("DefaultConnection")
    {
    }

    public static KtcsDbContext Create()
    {
      return new KtcsDbContext();
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
  }
}