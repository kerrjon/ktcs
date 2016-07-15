using System;
using System.Collections.Generic;
using System.Linq;
using Ktcs.Classes;
using Ktcs.Datamodel;

namespace Ktcs.DataModel.Migrations
{
  using System.Data.Entity.Migrations;

  internal sealed class Configuration : DbMigrationsConfiguration<KtcsDbContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = false;
    }

    protected override void Seed(KtcsDbContext context)
    {
      //  This method will be called after migrating to the latest version.
      //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
      //  to avoid creating duplicate seed data.
     
      try
      {
        // add Topics
        var topics = new List<Topic>{
          new Topic{Name = "Application Development"},
          new Topic{Name = "Data Center"},
          new Topic{Name = "Leadership and Mangement"}
        };
        topics.ForEach(s => context.Topics.AddOrUpdate(s));
        context.SaveChanges();

        // add Topic Categories
        var topicCategories = new List<TopicCategory>{
          new TopicCategory
          {
            Name = "New and Popular",
            TopicCategoryId = topics.First(x => x.TopicId == 1).TopicId
          },
          new TopicCategory
          {
            Name = "Programming Languages",
            TopicCategoryId = topics.First(x => x.TopicId == 1).TopicId
          },
          new TopicCategory
          {
            Name = "Frameworks and Environments",
            TopicCategoryId = topics.First(x => x.TopicId == 1).TopicId
          },
          new TopicCategory
          {
            Name = "Cisco",
            TopicCategoryId = topics.First(x => x.TopicId == 2).TopicId
          },
          new TopicCategory
          {
            Name = "EMC",
            TopicCategoryId = topics.First(x => x.TopicId == 2).TopicId
          },
          new TopicCategory
          {
            Name = "Leadership",
            TopicCategoryId = topics.First(x => x.TopicId == 3).TopicId
          },
          new TopicCategory
          {
            Name = "Management",
            TopicCategoryId = topics.First(x => x.TopicId == 3).TopicId
          },
          new TopicCategory
          {
            Name = "Organizational Development",
            TopicCategoryId = topics.First(x => x.TopicId == 3).TopicId
          }
        };
        topicCategories.ForEach(s => context.TopicCategories.AddOrUpdate(s));
        context.SaveChanges();

        // add Brands
        var brands = new List<Brand>{
          new Brand{Name = "Microsoft"},
          new Brand{Name = "Adobe"},
          new Brand{Name = "Oracle"}
        };
        brands.ForEach(s => context.Brands.AddOrUpdate(s));
        context.SaveChanges();

        // add Topic Categories
        var brandCategories = new List<BrandCategory>{
          new BrandCategory
          {
            Name = "Office",
            BrandCategoryId = brands.First(x => x.BrandId == 1).BrandId
          },
          new BrandCategory
          {
            Name = "Azure",
            BrandCategoryId = brands.First(x => x.BrandId == 1).BrandId
          },
          new BrandCategory
          {
            Name = "SharePoint",
            BrandCategoryId = brands.First(x => x.BrandId == 1).BrandId
          },
          new BrandCategory
          {
            Name = "SQL Server",
            BrandCategoryId = brands.First(x => x.BrandId == 1).BrandId
          },
          new BrandCategory
          {
            Name = "Visual Studio & .NET",
            BrandCategoryId = brands.First(x => x.BrandId == 1).BrandId
          },
          new BrandCategory
          {
            Name = "Windows Server",
            BrandCategoryId = brands.First(x => x.BrandId == 1).BrandId
          },
          new BrandCategory
          {
            Name = "Desktop Publishing",
            BrandCategoryId = brands.First(x => x.BrandId == 2).BrandId
          },
          new BrandCategory
          {
            Name = "Digital Video",
            BrandCategoryId = topics.First(x => x.TopicId == 2).TopicId
          },
          new BrandCategory
          {
            Name = "Web Design",
            BrandCategoryId = brands.First(x => x.BrandId == 2).BrandId
          },
          new BrandCategory
          {
            Name = "Oracle 10g",
            BrandCategoryId = brands.First(x => x.BrandId == 3).BrandId
          },
          new BrandCategory
          {
            Name = "Oracle 11g",
            BrandCategoryId = brands.First(x => x.BrandId == 3).BrandId
          },
          new BrandCategory
          {
            Name = "Oracle 12g",
            BrandCategoryId = brands.First(x => x.BrandId == 3).BrandId
          },
          new BrandCategory
          {
            Name = "Sun Solaris",
            BrandCategoryId = brands.First(x => x.BrandId == 3).BrandId
          }
        };
        brandCategories.ForEach(s => context.BrandCategories.AddOrUpdate(s));
        context.SaveChanges();
      }

      catch (Exception exception)
      {
        //Log.Error("error trying to add seed data", exception);
      }

    

    }
  }
}
