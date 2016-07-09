namespace Ktcs.Classes
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<BrandCategory> BrandCategories { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<TopicCategory> TopicCategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrandCategory>()
                .HasMany(e => e.Courses)
                .WithMany(e => e.BrandCategories)
                .Map(m => m.ToTable("CourseBrandCategory").MapLeftKey("brandCategoryId").MapRightKey("courseNumber"));

            modelBuilder.Entity<Course>()
                .Property(e => e.courseware)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.coursewarevendor)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.coursewarecost)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Course>()
                .Property(e => e.coursewarenotes)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.instructorNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.vendorwebsite)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.TopicCategories)
                .WithMany(e => e.Courses)
                .Map(m => m.ToTable("CourseTopicCategory").MapLeftKey("courseNumber").MapRightKey("topicCategoryId"));
        }
    }
}
