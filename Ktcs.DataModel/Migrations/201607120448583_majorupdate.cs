namespace Ktcs.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Majorupdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Course", "basePriceID", "dbo.BasePrice");
            DropForeignKey("dbo.Course", "courseTypeDetailID", "dbo.CourseTypeDetail");
            DropForeignKey("dbo.CourseTypeDetail", "CourseTypeID", "dbo.CourseType");
            DropForeignKey("dbo.CourseType", "AreaID", "dbo.area");
            DropIndex("dbo.CourseType", new[] { "AreaID" });
            DropIndex("dbo.CourseTypeDetail", new[] { "CourseTypeID" });
            DropIndex("dbo.Course", new[] { "courseTypeDetailID" });
            DropIndex("dbo.Course", new[] { "basePriceID" });
            DropIndex("dbo.ScheduledClass", new[] { "courseNumber" });
            DropIndex("dbo.ScheduledClass", new[] { "locationID" });
            DropIndex("dbo.ScheduledClass", new[] { "InstructorID" });
            DropIndex("dbo.ScheduledClass", new[] { "SurveyID" });
            DropIndex("dbo.Enrollments", new[] { "statusID" });
            DropIndex("dbo.Enrollments", new[] { "StudentID" });
            DropIndex("dbo.Enrollments", new[] { "ScheduledClassID" });
            DropIndex("dbo.WaitList", new[] { "StudentID" });
            DropIndex("dbo.Location", new[] { "VendorID" });
            DropIndex("dbo.vendor", new[] { "VendorTypeID" });
            DropIndex("dbo.SurveyQuestion", new[] { "QID" });
            DropIndex("dbo.SurveyQuestion", new[] { "SurveyID" });
            DropIndex("dbo.Question", new[] { "ATypeID" });
            DropIndex("dbo.Question", new[] { "SectionID" });
            DropIndex("dbo.Expense", new[] { "ExpenseTypeID" });
            CreateTable(
                "dbo.BrandCategory",
                c => new
                    {
                        BrandCategoryId = c.Int(nullable: false, identity: true),
                        brandCategory = c.String(maxLength: 200),
                        BrandId = c.Int(),
                    })
                .PrimaryKey(t => t.BrandCategoryId)
                .ForeignKey("dbo.Brand", t => t.BrandId)
                .Index(t => t.BrandId);
            
            CreateTable(
                "dbo.Brand",
                c => new
                    {
                        BrandId = c.Int(nullable: false, identity: true),
                        brand = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.BrandId);
            
            CreateTable(
                "dbo.TopicCategory",
                c => new
                    {
                        TopicCategoryId = c.Int(nullable: false, identity: true),
                        topicCategory = c.String(maxLength: 200),
                        TopicId = c.Int(),
                    })
                .PrimaryKey(t => t.TopicCategoryId)
                .ForeignKey("dbo.Topic", t => t.TopicId)
                .Index(t => t.TopicId);
            
            CreateTable(
                "dbo.Topic",
                c => new
                    {
                        TopicId = c.Int(nullable: false, identity: true),
                        topic = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.TopicId);
            
            CreateTable(
                "dbo.CourseBrandCategory",
                c => new
                    {
                        brandCategoryId = c.Int(nullable: false),
                        courseNumber = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => new { t.brandCategoryId, t.courseNumber })
                .ForeignKey("dbo.BrandCategory", t => t.brandCategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Course", t => t.courseNumber, cascadeDelete: true)
                .Index(t => t.brandCategoryId)
                .Index(t => t.courseNumber);
            
            CreateTable(
                "dbo.CourseTopicCategory",
                c => new
                    {
                        courseNumber = c.String(nullable: false, maxLength: 10),
                        topicCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.courseNumber, t.topicCategoryId })
                .ForeignKey("dbo.Course", t => t.courseNumber, cascadeDelete: true)
                .ForeignKey("dbo.TopicCategory", t => t.topicCategoryId, cascadeDelete: true)
                .Index(t => t.courseNumber)
                .Index(t => t.topicCategoryId);
            
            AddColumn("dbo.Course", "OfficialCourseNumber", c => c.String(maxLength: 15));
            AlterColumn("dbo.ClassRequest", "Denied", c => c.String(maxLength: 3));
            AlterColumn("dbo.ClassRequest", "Withdrew", c => c.String(maxLength: 3));
            CreateIndex("dbo.Question", "ATypeId");
            CreateIndex("dbo.Question", "SectionId");
            CreateIndex("dbo.SurveyQuestion", "Qid");
            CreateIndex("dbo.SurveyQuestion", "SurveyId");
            CreateIndex("dbo.ScheduledClass", "CourseNumber");
            CreateIndex("dbo.ScheduledClass", "LocationId");
            CreateIndex("dbo.ScheduledClass", "InstructorId");
            CreateIndex("dbo.ScheduledClass", "SurveyId");
            CreateIndex("dbo.Enrollments", "StatusId");
            CreateIndex("dbo.Enrollments", "StudentId");
            CreateIndex("dbo.Enrollments", "ScheduledClassId");
            CreateIndex("dbo.WaitList", "StudentId");
            CreateIndex("dbo.Location", "VendorId");
            CreateIndex("dbo.vendor", "VendorTypeId");
            CreateIndex("dbo.Expense", "ExpenseTypeId");
            DropColumn("dbo.Course", "courseTypeDetailID");
            DropColumn("dbo.Course", "basePriceID");
            DropColumn("dbo.student", "authorityID");
            DropTable("dbo.Admin");
            DropTable("dbo.area");
            DropTable("dbo.CourseType");
            DropTable("dbo.CourseTypeDetail");
            DropTable("dbo.BasePrice");
            DropTable("dbo.Authority");
            DropTable("dbo.CaseStudy");
            DropTable("dbo.Category");
            DropTable("dbo.Course_Area");
            DropTable("dbo.Course_CourseType");
            DropTable("dbo.dtproperties");
            DropTable("dbo.News");
            DropTable("dbo.Promo");
            DropTable("dbo.subCategory");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.subCategory",
                c => new
                    {
                        subCategoryID = c.Int(nullable: false, identity: true),
                        subCategory = c.String(nullable: false, maxLength: 100, unicode: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.subCategoryID);
            
            CreateTable(
                "dbo.Promo",
                c => new
                    {
                        promotionID = c.Int(nullable: false, identity: true),
                        promoTitle = c.String(nullable: false, maxLength: 30, unicode: false),
                        promoText = c.String(nullable: false, maxLength: 7000, unicode: false),
                        promorules = c.String(nullable: false, maxLength: 2000, unicode: false),
                        startDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        endDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        MajorPromo = c.String(nullable: false, maxLength: 3, unicode: false),
                    })
                .PrimaryKey(t => t.promotionID);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        NewsID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 120),
                        Body = c.String(nullable: false, storeType: "ntext"),
                        Visible = c.String(nullable: false, maxLength: 3),
                        Source = c.String(maxLength: 75),
                        NewsDate = c.DateTime(storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.NewsID);
            
            CreateTable(
                "dbo.dtproperties",
                c => new
                    {
                        id = c.Int(nullable: false),
                        property = c.String(nullable: false, maxLength: 64, unicode: false),
                        objectid = c.Int(),
                        value = c.String(maxLength: 255, unicode: false),
                        uvalue = c.String(maxLength: 255),
                        lvalue = c.Binary(storeType: "image"),
                        version = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.id, t.property });
            
            CreateTable(
                "dbo.Course_CourseType",
                c => new
                    {
                        coursenumber = c.String(nullable: false, maxLength: 10),
                        courseTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.coursenumber, t.courseTypeID });
            
            CreateTable(
                "dbo.Course_Area",
                c => new
                    {
                        coursenumber = c.String(nullable: false, maxLength: 10),
                        AreaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.coursenumber, t.AreaID });
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Category = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.CaseStudy",
                c => new
                    {
                        CaseStudyID = c.Int(nullable: false, identity: true),
                        CaseStudyTitle = c.String(nullable: false, maxLength: 60, fixedLength: true, unicode: false),
                        CaseStudyText = c.String(nullable: false, maxLength: 7000, unicode: false),
                        CaseStudyDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        visible = c.String(nullable: false, maxLength: 3, unicode: false),
                        CaseSummary = c.String(nullable: false, maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.CaseStudyID);
            
            CreateTable(
                "dbo.Authority",
                c => new
                    {
                        AuthorityID = c.Int(nullable: false),
                        Authority = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => new { t.AuthorityID, t.Authority });
            
            CreateTable(
                "dbo.BasePrice",
                c => new
                    {
                        BasePriceID = c.Int(nullable: false, identity: true),
                        BasePrice = c.Decimal(nullable: false, storeType: "smallmoney"),
                        BaseDescription = c.String(maxLength: 75, unicode: false),
                        membership = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.BasePriceID);
            
            CreateTable(
                "dbo.CourseTypeDetail",
                c => new
                    {
                        CourseTypeDetailID = c.Int(nullable: false, identity: true),
                        CourseTypeID = c.Int(nullable: false),
                        CourseTypeDetail = c.String(nullable: false, maxLength: 60),
                        pagenotes = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.CourseTypeDetailID);
            
            CreateTable(
                "dbo.CourseType",
                c => new
                    {
                        courseTypeID = c.Int(nullable: false, identity: true),
                        courseType = c.String(nullable: false, maxLength: 60),
                        AreaID = c.Int(nullable: false),
                        pageNotes = c.String(maxLength: 500),
                        visibleInFlyout = c.Int(),
                        flyoutText = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.courseTypeID);
            
            CreateTable(
                "dbo.area",
                c => new
                    {
                        AreaID = c.Int(nullable: false, identity: true),
                        Area = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.AreaID);
            
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        UserID = c.String(nullable: false, maxLength: 25),
                        Password = c.String(nullable: false, maxLength: 20),
                        adminemail = c.String(nullable: false, maxLength: 75),
                        AdminInitials = c.String(nullable: false, maxLength: 3),
                        AdminFName = c.String(nullable: false, maxLength: 30),
                        AdminLName = c.String(nullable: false, maxLength: 30),
                        AdminPhone = c.String(maxLength: 20),
                        AdminWebsite = c.String(maxLength: 75),
                        AdminFax = c.String(maxLength: 20),
                        AdminCompany = c.String(maxLength: 75),
                        SysAdmin = c.String(nullable: false, maxLength: 3, unicode: false),
                        CompanyID = c.Int(),
                        ReportDateRange = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            AddColumn("dbo.student", "authorityID", c => c.Int(nullable: false));
            AddColumn("dbo.Course", "basePriceID", c => c.Int(nullable: false));
            AddColumn("dbo.Course", "courseTypeDetailID", c => c.Int());
            DropForeignKey("dbo.CourseTopicCategory", "topicCategoryId", "dbo.TopicCategory");
            DropForeignKey("dbo.CourseTopicCategory", "courseNumber", "dbo.Course");
            DropForeignKey("dbo.TopicCategory", "TopicId", "dbo.Topic");
            DropForeignKey("dbo.CourseBrandCategory", "courseNumber", "dbo.Course");
            DropForeignKey("dbo.CourseBrandCategory", "brandCategoryId", "dbo.BrandCategory");
            DropForeignKey("dbo.BrandCategory", "BrandId", "dbo.Brand");
            DropIndex("dbo.CourseTopicCategory", new[] { "topicCategoryId" });
            DropIndex("dbo.CourseTopicCategory", new[] { "courseNumber" });
            DropIndex("dbo.CourseBrandCategory", new[] { "courseNumber" });
            DropIndex("dbo.CourseBrandCategory", new[] { "brandCategoryId" });
            DropIndex("dbo.Expense", new[] { "ExpenseTypeId" });
            DropIndex("dbo.vendor", new[] { "VendorTypeId" });
            DropIndex("dbo.Location", new[] { "VendorId" });
            DropIndex("dbo.WaitList", new[] { "StudentId" });
            DropIndex("dbo.Enrollments", new[] { "ScheduledClassId" });
            DropIndex("dbo.Enrollments", new[] { "StudentId" });
            DropIndex("dbo.Enrollments", new[] { "StatusId" });
            DropIndex("dbo.TopicCategory", new[] { "TopicId" });
            DropIndex("dbo.BrandCategory", new[] { "BrandId" });
            DropIndex("dbo.ScheduledClass", new[] { "SurveyId" });
            DropIndex("dbo.ScheduledClass", new[] { "InstructorId" });
            DropIndex("dbo.ScheduledClass", new[] { "LocationId" });
            DropIndex("dbo.ScheduledClass", new[] { "CourseNumber" });
            DropIndex("dbo.SurveyQuestion", new[] { "SurveyId" });
            DropIndex("dbo.SurveyQuestion", new[] { "Qid" });
            DropIndex("dbo.Question", new[] { "SectionId" });
            DropIndex("dbo.Question", new[] { "ATypeId" });
            AlterColumn("dbo.ClassRequest", "Withdrew", c => c.String(maxLength: 3, unicode: false));
            AlterColumn("dbo.ClassRequest", "Denied", c => c.String(maxLength: 3, unicode: false));
            DropColumn("dbo.Course", "OfficialCourseNumber");
            DropTable("dbo.CourseTopicCategory");
            DropTable("dbo.CourseBrandCategory");
            DropTable("dbo.Topic");
            DropTable("dbo.TopicCategory");
            DropTable("dbo.Brand");
            DropTable("dbo.BrandCategory");
            CreateIndex("dbo.Expense", "ExpenseTypeID");
            CreateIndex("dbo.Question", "SectionID");
            CreateIndex("dbo.Question", "ATypeID");
            CreateIndex("dbo.SurveyQuestion", "SurveyID");
            CreateIndex("dbo.SurveyQuestion", "QID");
            CreateIndex("dbo.vendor", "VendorTypeID");
            CreateIndex("dbo.Location", "VendorID");
            CreateIndex("dbo.WaitList", "StudentID");
            CreateIndex("dbo.Enrollments", "ScheduledClassID");
            CreateIndex("dbo.Enrollments", "StudentID");
            CreateIndex("dbo.Enrollments", "statusID");
            CreateIndex("dbo.ScheduledClass", "SurveyID");
            CreateIndex("dbo.ScheduledClass", "InstructorID");
            CreateIndex("dbo.ScheduledClass", "locationID");
            CreateIndex("dbo.ScheduledClass", "courseNumber");
            CreateIndex("dbo.Course", "basePriceID");
            CreateIndex("dbo.Course", "courseTypeDetailID");
            CreateIndex("dbo.CourseTypeDetail", "CourseTypeID");
            CreateIndex("dbo.CourseType", "AreaID");
            AddForeignKey("dbo.CourseType", "AreaID", "dbo.area", "AreaID");
            AddForeignKey("dbo.CourseTypeDetail", "CourseTypeID", "dbo.CourseType", "courseTypeID");
            AddForeignKey("dbo.Course", "courseTypeDetailID", "dbo.CourseTypeDetail", "CourseTypeDetailID");
            AddForeignKey("dbo.Course", "basePriceID", "dbo.BasePrice", "BasePriceID");
        }
    }
}
