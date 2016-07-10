namespace Ktcs.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixForCourse_CourseTypeDetail : DbMigration
    {
        public override void Up()
        {
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
            
            CreateTable(
                "dbo.Answer",
                c => new
                    {
                        AnswerID = c.Int(nullable: false, identity: true),
                        AnswerTxt = c.String(storeType: "ntext"),
                        AnswerNum = c.Decimal(precision: 2, scale: 0),
                        SQID = c.Int(nullable: false),
                        StudentID = c.Int(),
                        ScheduledClassID = c.Int(),
                    })
                .PrimaryKey(t => t.AnswerID);
            
            CreateTable(
                "dbo.area",
                c => new
                    {
                        AreaID = c.Int(nullable: false, identity: true),
                        Area = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.AreaID);
            
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
                .PrimaryKey(t => t.courseTypeID)
                .ForeignKey("dbo.area", t => t.AreaID)
                .Index(t => t.AreaID);
            
            CreateTable(
                "dbo.CourseTypeDetail",
                c => new
                    {
                        CourseTypeDetailID = c.Int(nullable: false, identity: true),
                        CourseTypeID = c.Int(nullable: false),
                        CourseTypeDetail = c.String(nullable: false, maxLength: 60),
                        pagenotes = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.CourseTypeDetailID)
                .ForeignKey("dbo.CourseType", t => t.CourseTypeID)
                .Index(t => t.CourseTypeID);
            
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        courseNumber = c.String(nullable: false, maxLength: 10),
                        title = c.String(nullable: false, maxLength: 125),
                        description = c.String(storeType: "ntext"),
                        prereq = c.String(maxLength: 4000),
                        duration = c.String(maxLength: 10),
                        courseTypeDetailID = c.Int(),
                        comments = c.String(maxLength: 1000),
                        inscomments = c.String(maxLength: 50),
                        overview = c.String(nullable: false, storeType: "ntext"),
                        basePriceID = c.Int(nullable: false),
                        courseware = c.String(maxLength: 100, unicode: false),
                        coursewarevendor = c.String(maxLength: 100, unicode: false),
                        coursewarecost = c.Decimal(precision: 9, scale: 2),
                        coursewarenotes = c.String(maxLength: 4000, unicode: false),
                        datecreated = c.DateTime(storeType: "smalldatetime"),
                        lastupdate = c.DateTime(storeType: "smalldatetime"),
                        instructorNotes = c.String(maxLength: 4000, unicode: false),
                        vendorwebsite = c.String(maxLength: 250, unicode: false),
                        isvisable = c.Int(),
                        visibleInFlyout = c.Int(),
                    })
                .PrimaryKey(t => t.courseNumber)
                .ForeignKey("dbo.BasePrice", t => t.basePriceID)
                .ForeignKey("dbo.CourseTypeDetail", t => t.courseTypeDetailID)
                .Index(t => t.courseTypeDetailID)
                .Index(t => t.basePriceID);
            
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
                "dbo.ScheduledClass",
                c => new
                    {
                        ScheduledClassID = c.Int(nullable: false, identity: true),
                        courseNumber = c.String(nullable: false, maxLength: 10),
                        startDate = c.DateTime(),
                        endDate = c.DateTime(),
                        startTime = c.String(maxLength: 50, unicode: false),
                        endTime = c.String(maxLength: 50, unicode: false),
                        Price = c.Decimal(storeType: "smallmoney"),
                        MarketRate = c.Decimal(storeType: "smallmoney"),
                        ispublic = c.String(nullable: false, maxLength: 3, unicode: false),
                        KTCSRate = c.Decimal(storeType: "smallmoney"),
                        KTCScourse = c.String(maxLength: 3, unicode: false),
                        startDateconfirmed = c.String(maxLength: 3, unicode: false),
                        bookOrderMade = c.String(maxLength: 3, unicode: false),
                        insTestReminder = c.String(maxLength: 3, unicode: false),
                        bookOrderRecieved = c.String(maxLength: 3, unicode: false),
                        insconfirmed = c.String(maxLength: 3, unicode: false),
                        locconfirmed = c.String(maxLength: 3, unicode: false),
                        MaxStudents = c.Short(),
                        locationID = c.Int(nullable: false),
                        InstructorID = c.String(maxLength: 10, unicode: false),
                        CompanyID = c.Int(nullable: false),
                        SurveyID = c.Int(nullable: false),
                        Mirrored = c.String(maxLength: 50, unicode: false),
                        MirroredWebsite = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ScheduledClassID)
                .ForeignKey("dbo.Instructor", t => t.InstructorID)
                .ForeignKey("dbo.Location", t => t.locationID)
                .ForeignKey("dbo.Survey", t => t.SurveyID)
                .ForeignKey("dbo.Course", t => t.courseNumber)
                .Index(t => t.courseNumber)
                .Index(t => t.locationID)
                .Index(t => t.InstructorID)
                .Index(t => t.SurveyID);
            
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        ConfirmationNum = c.Int(nullable: false, identity: true),
                        Enrolled = c.DateTime(storeType: "smalldatetime"),
                        Confirmation = c.DateTime(storeType: "smalldatetime"),
                        Reminder = c.DateTime(storeType: "smalldatetime"),
                        Paid = c.Decimal(storeType: "money"),
                        invoice = c.String(maxLength: 10),
                        Discount = c.Decimal(storeType: "money"),
                        MTSfee = c.Decimal(storeType: "money"),
                        statusID = c.Int(nullable: false),
                        Amountdue = c.Decimal(storeType: "money"),
                        StudentID = c.Int(nullable: false),
                        ScheduledClassID = c.Int(nullable: false),
                        cancellationNum = c.String(maxLength: 10),
                        cancellationDate = c.DateTime(storeType: "smalldatetime"),
                        dateDue = c.DateTime(storeType: "smalldatetime"),
                        mgrConfirmation = c.String(maxLength: 3, unicode: false),
                        conarchived = c.String(maxLength: 3, unicode: false),
                        DiscountDollars = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.ConfirmationNum)
                .ForeignKey("dbo.Status", t => t.statusID)
                .ForeignKey("dbo.student", t => t.StudentID)
                .ForeignKey("dbo.ScheduledClass", t => t.ScheduledClassID)
                .Index(t => t.statusID)
                .Index(t => t.StudentID)
                .Index(t => t.ScheduledClassID);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusID = c.Int(nullable: false),
                        Status = c.String(nullable: false, maxLength: 30),
                        BgColor = c.String(maxLength: 6),
                        FtColor = c.String(maxLength: 6),
                    })
                .PrimaryKey(t => t.StatusID);
            
            CreateTable(
                "dbo.student",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        stuLName = c.String(nullable: false, maxLength: 35),
                        stuFName = c.String(maxLength: 30),
                        stuEmail = c.String(maxLength: 75),
                        Password = c.String(maxLength: 10, unicode: false),
                        stuHomePhone = c.String(maxLength: 20),
                        stuInternationalCode = c.String(maxLength: 2, unicode: false),
                        stuProductArea = c.String(maxLength: 70),
                        ManagerID = c.Int(nullable: false),
                        CompanyID = c.Int(nullable: false),
                        stupassword = c.String(maxLength: 10),
                        authorityID = c.Int(nullable: false),
                        stuWorkPhone = c.String(maxLength: 20),
                        stuCountry = c.String(maxLength: 30),
                        stuJobTitle = c.String(maxLength: 70),
                        stuCity = c.String(maxLength: 30),
                        stustate = c.String(maxLength: 2),
                        stuaddress = c.String(maxLength: 75),
                        stuaddress2 = c.String(maxLength: 75),
                        stuzip = c.String(maxLength: 12),
                        ReferredByID = c.Int(),
                        stufax = c.String(maxLength: 20),
                        CostCenter = c.String(maxLength: 15),
                        BillName = c.String(maxLength: 75),
                        BillAddress = c.String(maxLength: 75),
                        BillAddress2 = c.String(maxLength: 75),
                        BillCity = c.String(maxLength: 30),
                        BillState = c.String(maxLength: 2),
                        BillZip = c.String(maxLength: 12),
                        BillCountry = c.String(maxLength: 30),
                        BillPhone = c.String(maxLength: 20),
                        BillFax = c.String(maxLength: 20),
                        BillEmail = c.String(maxLength: 75),
                        BillInternationalCode = c.String(maxLength: 2, unicode: false),
                        OtherCompany = c.String(maxLength: 60, unicode: false),
                        OtherReferredBy = c.String(maxLength: 60, unicode: false),
                        OtherManager = c.String(maxLength: 60, unicode: false),
                        OtherManagerPhone = c.String(maxLength: 20, unicode: false),
                        mailList = c.String(maxLength: 3, unicode: false),
                        UserID = c.String(maxLength: 10, unicode: false),
                        ClassesTaken = c.Byte(),
                        blockReminder = c.String(maxLength: 3, unicode: false),
                        other = c.String(maxLength: 75, unicode: false),
                        stuarchived = c.String(maxLength: 3, unicode: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.WaitList",
                c => new
                    {
                        WaitListID = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        CourseNumber = c.String(nullable: false, maxLength: 10),
                        TimeFrame = c.String(maxLength: 20),
                        Comments = c.String(storeType: "ntext"),
                        DateCreated = c.DateTime(nullable: false, storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.WaitListID)
                .ForeignKey("dbo.student", t => t.StudentID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.Instructor",
                c => new
                    {
                        InstructorID = c.String(nullable: false, maxLength: 10, unicode: false),
                        insfname = c.String(maxLength: 30),
                        inslname = c.String(nullable: false, maxLength: 35),
                        insaddress = c.String(maxLength: 75),
                        inscity = c.String(maxLength: 30),
                        insstate = c.String(maxLength: 2),
                        inszip = c.String(maxLength: 12),
                        insphone = c.String(maxLength: 20),
                        insphone2 = c.String(maxLength: 20),
                        insemail = c.String(maxLength: 60),
                        insemail2 = c.String(maxLength: 60),
                        insfax = c.String(maxLength: 20),
                        inscountry = c.String(maxLength: 30),
                        VendorID = c.Int(nullable: false),
                        password = c.String(maxLength: 10, unicode: false),
                        insIndependent = c.String(maxLength: 50, unicode: false),
                        insReferredBy = c.String(maxLength: 50, unicode: false),
                        Keywords = c.String(maxLength: 200, unicode: false),
                        resumeText = c.String(maxLength: 7000, unicode: false),
                        Skill1 = c.String(maxLength: 50, unicode: false),
                        Skill2 = c.String(maxLength: 50, unicode: false),
                        Skill3 = c.String(maxLength: 50, unicode: false),
                        Skill4 = c.String(maxLength: 50, unicode: false),
                        Skill5 = c.String(maxLength: 50, unicode: false),
                        Category1 = c.String(maxLength: 50, unicode: false),
                        Category2 = c.String(maxLength: 50, unicode: false),
                        Category3 = c.String(maxLength: 50, unicode: false),
                        notes = c.String(maxLength: 2000, unicode: false),
                        coursewareNotes = c.String(maxLength: 2000, unicode: false),
                    })
                .PrimaryKey(t => t.InstructorID);
            
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        LocationID = c.Int(nullable: false, identity: true),
                        locaddress = c.String(maxLength: 75),
                        loccity = c.String(nullable: false, maxLength: 30),
                        locstate = c.String(nullable: false, maxLength: 2),
                        loczip = c.String(maxLength: 12),
                        locnotes = c.String(maxLength: 300),
                        locName = c.String(nullable: false, maxLength: 75),
                        VendorID = c.Int(),
                        locmapLink = c.String(maxLength: 75),
                        locphone = c.String(maxLength: 20),
                        loccountry = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.LocationID)
                .ForeignKey("dbo.vendor", t => t.VendorID)
                .Index(t => t.VendorID);
            
            CreateTable(
                "dbo.vendor",
                c => new
                    {
                        vendorID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 75),
                        address = c.String(maxLength: 75),
                        city = c.String(maxLength: 30),
                        state = c.String(maxLength: 2),
                        zip = c.String(maxLength: 12),
                        phone = c.String(maxLength: 20),
                        fax = c.String(maxLength: 20),
                        country = c.String(maxLength: 30),
                        NegDiscount = c.String(maxLength: 255),
                        VendorTypeID = c.Int(nullable: false),
                        maplink = c.String(maxLength: 75),
                        notes = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.vendorID)
                .ForeignKey("dbo.VendorType", t => t.VendorTypeID)
                .Index(t => t.VendorTypeID);
            
            CreateTable(
                "dbo.VendorType",
                c => new
                    {
                        VendorTypeID = c.Int(nullable: false, identity: true),
                        VendorType = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.VendorTypeID);
            
            CreateTable(
                "dbo.Survey",
                c => new
                    {
                        SurveyID = c.Int(nullable: false, identity: true),
                        SurveyName = c.String(nullable: false, maxLength: 75, unicode: false),
                        DateCreated = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Creator = c.String(maxLength: 50, unicode: false),
                        DefaultSurvey = c.String(nullable: false, maxLength: 3, unicode: false),
                    })
                .PrimaryKey(t => t.SurveyID);
            
            CreateTable(
                "dbo.SurveyQuestion",
                c => new
                    {
                        SQID = c.Int(nullable: false, identity: true),
                        QID = c.Int(nullable: false),
                        SurveyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SQID)
                .ForeignKey("dbo.Question", t => t.QID)
                .ForeignKey("dbo.Survey", t => t.SurveyID)
                .Index(t => t.QID)
                .Index(t => t.SurveyID);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        QID = c.Int(nullable: false, identity: true),
                        Question = c.String(nullable: false, maxLength: 255, unicode: false),
                        ATypeID = c.Int(nullable: false),
                        SectionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QID)
                .ForeignKey("dbo.AType", t => t.ATypeID)
                .ForeignKey("dbo.SectionType", t => t.SectionID)
                .Index(t => t.ATypeID)
                .Index(t => t.SectionID);
            
            CreateTable(
                "dbo.AType",
                c => new
                    {
                        ATypeID = c.Int(nullable: false, identity: true),
                        AType = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ATypeID);
            
            CreateTable(
                "dbo.SectionType",
                c => new
                    {
                        SectionID = c.Int(nullable: false, identity: true),
                        SectionName = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.SectionID);
            
            CreateTable(
                "dbo.aspnet_Applications",
                c => new
                    {
                        ApplicationId = c.Guid(nullable: false),
                        ApplicationName = c.String(nullable: false, maxLength: 256),
                        LoweredApplicationName = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ApplicationId);
            
            CreateTable(
                "dbo.aspnet_Membership",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        ApplicationId = c.Guid(nullable: false),
                        Password = c.String(nullable: false, maxLength: 128),
                        PasswordFormat = c.Int(nullable: false),
                        PasswordSalt = c.String(nullable: false, maxLength: 128),
                        MobilePIN = c.String(maxLength: 16),
                        Email = c.String(maxLength: 256),
                        LoweredEmail = c.String(maxLength: 256),
                        PasswordQuestion = c.String(maxLength: 256),
                        PasswordAnswer = c.String(maxLength: 128),
                        IsApproved = c.Boolean(nullable: false),
                        IsLockedOut = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        LastLoginDate = c.DateTime(nullable: false),
                        LastPasswordChangedDate = c.DateTime(nullable: false),
                        LastLockoutDate = c.DateTime(nullable: false),
                        FailedPasswordAttemptCount = c.Int(nullable: false),
                        FailedPasswordAttemptWindowStart = c.DateTime(nullable: false),
                        FailedPasswordAnswerAttemptCount = c.Int(nullable: false),
                        FailedPasswordAnswerAttemptWindowStart = c.DateTime(nullable: false),
                        Comment = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.aspnet_Users", t => t.UserId)
                .ForeignKey("dbo.aspnet_Applications", t => t.ApplicationId)
                .Index(t => t.UserId)
                .Index(t => t.ApplicationId);
            
            CreateTable(
                "dbo.aspnet_Users",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        ApplicationId = c.Guid(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        LoweredUserName = c.String(nullable: false, maxLength: 256),
                        MobileAlias = c.String(maxLength: 16),
                        IsAnonymous = c.Boolean(nullable: false),
                        LastActivityDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.aspnet_Applications", t => t.ApplicationId)
                .Index(t => t.ApplicationId);
            
            CreateTable(
                "dbo.aspnet_PersonalizationPerUser",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PathId = c.Guid(),
                        UserId = c.Guid(),
                        PageSettings = c.Binary(nullable: false, storeType: "image"),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.aspnet_Paths", t => t.PathId)
                .ForeignKey("dbo.aspnet_Users", t => t.UserId)
                .Index(t => t.PathId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.aspnet_Paths",
                c => new
                    {
                        PathId = c.Guid(nullable: false),
                        ApplicationId = c.Guid(nullable: false),
                        Path = c.String(nullable: false, maxLength: 256),
                        LoweredPath = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.PathId)
                .ForeignKey("dbo.aspnet_Applications", t => t.ApplicationId)
                .Index(t => t.ApplicationId);
            
            CreateTable(
                "dbo.aspnet_PersonalizationAllUsers",
                c => new
                    {
                        PathId = c.Guid(nullable: false),
                        PageSettings = c.Binary(nullable: false, storeType: "image"),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PathId)
                .ForeignKey("dbo.aspnet_Paths", t => t.PathId)
                .Index(t => t.PathId);
            
            CreateTable(
                "dbo.aspnet_Profile",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        PropertyNames = c.String(nullable: false, storeType: "ntext"),
                        PropertyValuesString = c.String(nullable: false, storeType: "ntext"),
                        PropertyValuesBinary = c.Binary(nullable: false, storeType: "image"),
                        LastUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.aspnet_Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.aspnet_Roles",
                c => new
                    {
                        RoleId = c.Guid(nullable: false),
                        ApplicationId = c.Guid(nullable: false),
                        RoleName = c.String(nullable: false, maxLength: 256),
                        LoweredRoleName = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.RoleId)
                .ForeignKey("dbo.aspnet_Applications", t => t.ApplicationId)
                .Index(t => t.ApplicationId);
            
            CreateTable(
                "dbo.aspnet_SchemaVersions",
                c => new
                    {
                        Feature = c.String(nullable: false, maxLength: 128),
                        CompatibleSchemaVersion = c.String(nullable: false, maxLength: 128),
                        IsCurrentVersion = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.Feature, t.CompatibleSchemaVersion });
            
            CreateTable(
                "dbo.aspnet_WebEvent_Events",
                c => new
                    {
                        EventId = c.String(nullable: false, maxLength: 32, fixedLength: true, unicode: false),
                        EventTimeUtc = c.DateTime(nullable: false),
                        EventTime = c.DateTime(nullable: false),
                        EventType = c.String(nullable: false, maxLength: 256),
                        EventSequence = c.Decimal(nullable: false, precision: 19, scale: 0),
                        EventOccurrence = c.Decimal(nullable: false, precision: 19, scale: 0),
                        EventCode = c.Int(nullable: false),
                        EventDetailCode = c.Int(nullable: false),
                        Message = c.String(maxLength: 1024),
                        ApplicationPath = c.String(maxLength: 256),
                        ApplicationVirtualPath = c.String(maxLength: 256),
                        MachineName = c.String(nullable: false, maxLength: 256),
                        RequestUrl = c.String(maxLength: 1024),
                        ExceptionType = c.String(maxLength: 256),
                        Details = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "dbo.Authority",
                c => new
                    {
                        AuthorityID = c.Int(nullable: false),
                        Authority = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => new { t.AuthorityID, t.Authority });
            
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
                "dbo.Category",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Category = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.ClassRequest",
                c => new
                    {
                        RequestID = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        ScheduledClassID = c.Int(nullable: false),
                        RequestDate = c.DateTime(storeType: "smalldatetime"),
                        ApprovalSent = c.DateTime(storeType: "smalldatetime"),
                        ApprovalReceived = c.DateTime(storeType: "smalldatetime"),
                        Denied = c.String(maxLength: 3, unicode: false),
                        Withdrew = c.String(maxLength: 3, unicode: false),
                        Enrolled = c.DateTime(storeType: "smalldatetime"),
                        WithdrawReason = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.RequestID);
            
            CreateTable(
                "dbo.ComContactNote",
                c => new
                    {
                        NoteID = c.Int(nullable: false, identity: true),
                        ComContactID = c.Int(nullable: false),
                        NoteDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Notes = c.String(nullable: false, maxLength: 4000, unicode: false),
                        NoteTypeID = c.Int(nullable: false),
                        AdminInitials = c.String(maxLength: 3, unicode: false),
                        FollowUp = c.String(maxLength: 4000),
                        FollowUpDate = c.DateTime(storeType: "smalldatetime"),
                        Priority = c.String(maxLength: 10, unicode: false),
                        toDoFor = c.String(maxLength: 60, unicode: false),
                    })
                .PrimaryKey(t => t.NoteID);
            
            CreateTable(
                "dbo.ComContact",
                c => new
                    {
                        ComContactID = c.Int(nullable: false, identity: true),
                        CompanyID = c.Int(nullable: false),
                        ComConTitle = c.String(maxLength: 75),
                        ComConFName = c.String(maxLength: 30, unicode: false),
                        ComConLName = c.String(nullable: false, maxLength: 35, unicode: false),
                        ComConAddress = c.String(maxLength: 75, unicode: false),
                        ComConAddress2 = c.String(maxLength: 75, unicode: false),
                        ComConCity = c.String(maxLength: 30, unicode: false),
                        ComConState = c.String(maxLength: 2, fixedLength: true, unicode: false),
                        ComConZip = c.String(maxLength: 12, unicode: false),
                        ComConPhone = c.String(maxLength: 20, unicode: false),
                        ComConPhone2 = c.String(maxLength: 20, unicode: false),
                        ComConEmail = c.String(maxLength: 60, unicode: false),
                        ComConEmail2 = c.String(maxLength: 60, unicode: false),
                        ComConFax = c.String(maxLength: 20, unicode: false),
                        ComConCountry = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.ComContactID);
            
            CreateTable(
                "dbo.company",
                c => new
                    {
                        CompanyID = c.Int(nullable: false, identity: true),
                        comName = c.String(nullable: false, maxLength: 75),
                        comAddress = c.String(maxLength: 75),
                        comAddress2 = c.String(maxLength: 75),
                        comCity = c.String(maxLength: 30),
                        comState = c.String(maxLength: 2),
                        comZip = c.String(maxLength: 12),
                        comcountry = c.String(maxLength: 30),
                        comphone = c.String(maxLength: 20),
                        comfax = c.String(maxLength: 20),
                        comMapLink = c.String(maxLength: 75),
                        billname = c.String(maxLength: 50, unicode: false),
                        billaddress = c.String(maxLength: 75, unicode: false),
                        billaddress2 = c.String(maxLength: 75, unicode: false),
                        billcity = c.String(maxLength: 30, unicode: false),
                        billstate = c.String(maxLength: 2, unicode: false),
                        billzip = c.String(maxLength: 12, unicode: false),
                        billphone = c.String(maxLength: 20, unicode: false),
                        billfax = c.String(maxLength: 20, unicode: false),
                        billcountry = c.String(maxLength: 50, unicode: false),
                        logo = c.String(maxLength: 75, unicode: false),
                        billemail = c.String(maxLength: 75, unicode: false),
                    })
                .PrimaryKey(t => t.CompanyID);
            
            CreateTable(
                "dbo.ContactNote",
                c => new
                    {
                        NoteID = c.Int(nullable: false, identity: true),
                        ContactID = c.Int(nullable: false),
                        NoteDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Notes = c.String(nullable: false, maxLength: 4000, unicode: false),
                        NoteTypeID = c.Int(nullable: false),
                        AdminInitials = c.String(maxLength: 3),
                        Followup = c.String(maxLength: 4000),
                        FollowupDate = c.DateTime(storeType: "smalldatetime"),
                        Priority = c.String(maxLength: 10, unicode: false),
                        toDoFor = c.String(maxLength: 60, unicode: false),
                    })
                .PrimaryKey(t => t.NoteID);
            
            CreateTable(
                "dbo.contact",
                c => new
                    {
                        contactID = c.Int(nullable: false, identity: true),
                        vendorid = c.Int(nullable: false),
                        contitle = c.String(maxLength: 75),
                        conFName = c.String(maxLength: 30),
                        conLName = c.String(nullable: false, maxLength: 35),
                        conaddress = c.String(maxLength: 75),
                        concity = c.String(maxLength: 30),
                        constate = c.String(maxLength: 2),
                        conzip = c.String(maxLength: 12),
                        conphone = c.String(maxLength: 20),
                        conphone2 = c.String(maxLength: 20),
                        conemail = c.String(maxLength: 60),
                        conemail2 = c.String(maxLength: 60),
                        confax = c.String(maxLength: 20),
                        concountry = c.String(maxLength: 30),
                        conext1 = c.String(maxLength: 15, unicode: false),
                        conext2 = c.String(maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.contactID);
            
            CreateTable(
                "dbo.Course_Area",
                c => new
                    {
                        coursenumber = c.String(nullable: false, maxLength: 10),
                        AreaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.coursenumber, t.AreaID });
            
            CreateTable(
                "dbo.Course_CourseType",
                c => new
                    {
                        coursenumber = c.String(nullable: false, maxLength: 10),
                        courseTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.coursenumber, t.courseTypeID });
            
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
                "dbo.Expense",
                c => new
                    {
                        ExpenseID = c.Int(nullable: false, identity: true),
                        VendorID = c.Int(nullable: false),
                        Cost = c.Decimal(storeType: "smallmoney"),
                        Qty = c.Int(),
                        Description = c.String(maxLength: 300),
                        ExpenseTypeID = c.Int(),
                        ScheduledClassID = c.Int(),
                        VenInvoiceNum = c.String(maxLength: 10),
                        VenInvoiceDate = c.DateTime(storeType: "smalldatetime"),
                        VenInvoicePaid = c.String(maxLength: 3, unicode: false),
                        Tax = c.Decimal(storeType: "smallmoney"),
                        Shipping = c.Decimal(storeType: "smallmoney"),
                    })
                .PrimaryKey(t => t.ExpenseID)
                .ForeignKey("dbo.ExpenseType", t => t.ExpenseTypeID)
                .Index(t => t.ExpenseTypeID);
            
            CreateTable(
                "dbo.ExpenseType",
                c => new
                    {
                        ExpenseTypeID = c.Int(nullable: false, identity: true),
                        ExpenseType = c.String(nullable: false, maxLength: 75),
                    })
                .PrimaryKey(t => t.ExpenseTypeID);
            
            CreateTable(
                "dbo.Income",
                c => new
                    {
                        IncomeID = c.Int(nullable: false, identity: true),
                        CompanyID = c.Int(nullable: false),
                        Cost = c.Decimal(storeType: "smallmoney"),
                        Qty = c.Int(),
                        Description = c.String(maxLength: 300),
                        IncomeTypeID = c.Int(),
                        ScheduledClassID = c.Int(),
                        VenInvoiceNum = c.String(maxLength: 10),
                        VenInvoiceDate = c.DateTime(storeType: "smalldatetime"),
                        VenInvoicePaid = c.String(maxLength: 3, unicode: false),
                        Tax = c.Decimal(storeType: "smallmoney"),
                        Shipping = c.Decimal(storeType: "smallmoney"),
                    })
                .PrimaryKey(t => t.IncomeID);
            
            CreateTable(
                "dbo.IncomeType",
                c => new
                    {
                        IncomeTypeID = c.Int(nullable: false, identity: true),
                        IncomeType = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.IncomeTypeID);
            
            CreateTable(
                "dbo.insCategory",
                c => new
                    {
                        insCategory = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.insCategory);
            
            CreateTable(
                "dbo.insCertification",
                c => new
                    {
                        insCertification = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.insCertification);
            
            CreateTable(
                "dbo.insSkill",
                c => new
                    {
                        insSkill = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.insSkill);
            
            CreateTable(
                "dbo.instructorCert",
                c => new
                    {
                        insCertification = c.String(nullable: false, maxLength: 50, unicode: false),
                        instructorID = c.String(nullable: false, maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => new { t.insCertification, t.instructorID });
            
            CreateTable(
                "dbo.InstructorNote",
                c => new
                    {
                        NoteID = c.Int(nullable: false, identity: true),
                        InstructorID = c.String(nullable: false, maxLength: 50, unicode: false),
                        NoteDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Notes = c.String(nullable: false, maxLength: 7000, unicode: false),
                        NoteTypeID = c.Int(nullable: false),
                        AdminInitials = c.String(maxLength: 3, unicode: false),
                        FollowUp = c.String(maxLength: 7000, unicode: false),
                        FollowUpDate = c.DateTime(storeType: "smalldatetime"),
                        Priority = c.String(maxLength: 10, unicode: false),
                        toDoFor = c.String(maxLength: 60, unicode: false),
                    })
                .PrimaryKey(t => t.NoteID);
            
            CreateTable(
                "dbo.Manager",
                c => new
                    {
                        ManagerID = c.Int(nullable: false, identity: true),
                        mgrFName = c.String(maxLength: 30),
                        mgrLName = c.String(nullable: false, maxLength: 35),
                        mgrPhone = c.String(maxLength: 20),
                        mgrEmail = c.String(maxLength: 60),
                        mgrFax = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ManagerID);
            
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
                "dbo.NoteType",
                c => new
                    {
                        NoteTypeID = c.Int(nullable: false, identity: true),
                        NoteType = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.NoteTypeID);
            
            CreateTable(
                "dbo.Payment",
                c => new
                    {
                        PaymentID = c.Int(nullable: false, identity: true),
                        PayAmount = c.Decimal(nullable: false, storeType: "money"),
                        PayDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        ConfirmationNum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentID);
            
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
                "dbo.ReferredBy",
                c => new
                    {
                        ReferredByID = c.Int(nullable: false, identity: true),
                        ReferredBy = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ReferredByID);
            
            CreateTable(
                "dbo.StudentCertifications",
                c => new
                    {
                        StudentID = c.Int(nullable: false),
                        CertificationID = c.Int(nullable: false),
                        ExpireDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.StudentDistribution",
                c => new
                    {
                        StudentDistributionID = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        DistributionID = c.Int(nullable: false),
                        ExamStatus = c.String(nullable: false, maxLength: 20, unicode: false),
                        startTime = c.DateTime(),
                        EndTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.StudentDistributionID);
            
            CreateTable(
                "dbo.StudentNote2",
                c => new
                    {
                        NoteID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                        NoteDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Notes = c.String(maxLength: 4000),
                        NoteTypeID = c.Int(nullable: false),
                        followup = c.String(maxLength: 4000),
                        AdminInitials = c.String(maxLength: 3),
                        FollowUpDate = c.DateTime(storeType: "smalldatetime"),
                        ToDoFor = c.String(maxLength: 60, unicode: false),
                        Priority = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.NoteID);
            
            CreateTable(
                "dbo.StudentNote",
                c => new
                    {
                        NoteID = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        NoteDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Notes = c.String(maxLength: 4000),
                        NoteTypeID = c.Int(nullable: false),
                        followup = c.String(maxLength: 4000),
                        AdminInitials = c.String(maxLength: 3),
                        FollowUpDate = c.DateTime(storeType: "smalldatetime"),
                        ToDoFor = c.String(maxLength: 60, unicode: false),
                        Priority = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.NoteID);
            
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
                "dbo.aspnet_UsersInRoles",
                c => new
                    {
                        RoleId = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.aspnet_Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.aspnet_Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Expense", "ExpenseTypeID", "dbo.ExpenseType");
            DropForeignKey("dbo.aspnet_Users", "ApplicationId", "dbo.aspnet_Applications");
            DropForeignKey("dbo.aspnet_Roles", "ApplicationId", "dbo.aspnet_Applications");
            DropForeignKey("dbo.aspnet_Paths", "ApplicationId", "dbo.aspnet_Applications");
            DropForeignKey("dbo.aspnet_Membership", "ApplicationId", "dbo.aspnet_Applications");
            DropForeignKey("dbo.aspnet_UsersInRoles", "UserId", "dbo.aspnet_Users");
            DropForeignKey("dbo.aspnet_UsersInRoles", "RoleId", "dbo.aspnet_Roles");
            DropForeignKey("dbo.aspnet_Profile", "UserId", "dbo.aspnet_Users");
            DropForeignKey("dbo.aspnet_PersonalizationPerUser", "UserId", "dbo.aspnet_Users");
            DropForeignKey("dbo.aspnet_PersonalizationPerUser", "PathId", "dbo.aspnet_Paths");
            DropForeignKey("dbo.aspnet_PersonalizationAllUsers", "PathId", "dbo.aspnet_Paths");
            DropForeignKey("dbo.aspnet_Membership", "UserId", "dbo.aspnet_Users");
            DropForeignKey("dbo.CourseType", "AreaID", "dbo.area");
            DropForeignKey("dbo.CourseTypeDetail", "CourseTypeID", "dbo.CourseType");
            DropForeignKey("dbo.ScheduledClass", "courseNumber", "dbo.Course");
            DropForeignKey("dbo.SurveyQuestion", "SurveyID", "dbo.Survey");
            DropForeignKey("dbo.SurveyQuestion", "QID", "dbo.Question");
            DropForeignKey("dbo.Question", "SectionID", "dbo.SectionType");
            DropForeignKey("dbo.Question", "ATypeID", "dbo.AType");
            DropForeignKey("dbo.ScheduledClass", "SurveyID", "dbo.Survey");
            DropForeignKey("dbo.vendor", "VendorTypeID", "dbo.VendorType");
            DropForeignKey("dbo.Location", "VendorID", "dbo.vendor");
            DropForeignKey("dbo.ScheduledClass", "locationID", "dbo.Location");
            DropForeignKey("dbo.ScheduledClass", "InstructorID", "dbo.Instructor");
            DropForeignKey("dbo.Enrollments", "ScheduledClassID", "dbo.ScheduledClass");
            DropForeignKey("dbo.WaitList", "StudentID", "dbo.student");
            DropForeignKey("dbo.Enrollments", "StudentID", "dbo.student");
            DropForeignKey("dbo.Enrollments", "statusID", "dbo.Status");
            DropForeignKey("dbo.Course", "courseTypeDetailID", "dbo.CourseTypeDetail");
            DropForeignKey("dbo.Course", "basePriceID", "dbo.BasePrice");
            DropIndex("dbo.aspnet_UsersInRoles", new[] { "UserId" });
            DropIndex("dbo.aspnet_UsersInRoles", new[] { "RoleId" });
            DropIndex("dbo.Expense", new[] { "ExpenseTypeID" });
            DropIndex("dbo.aspnet_Roles", new[] { "ApplicationId" });
            DropIndex("dbo.aspnet_Profile", new[] { "UserId" });
            DropIndex("dbo.aspnet_PersonalizationAllUsers", new[] { "PathId" });
            DropIndex("dbo.aspnet_Paths", new[] { "ApplicationId" });
            DropIndex("dbo.aspnet_PersonalizationPerUser", new[] { "UserId" });
            DropIndex("dbo.aspnet_PersonalizationPerUser", new[] { "PathId" });
            DropIndex("dbo.aspnet_Users", new[] { "ApplicationId" });
            DropIndex("dbo.aspnet_Membership", new[] { "ApplicationId" });
            DropIndex("dbo.aspnet_Membership", new[] { "UserId" });
            DropIndex("dbo.Question", new[] { "SectionID" });
            DropIndex("dbo.Question", new[] { "ATypeID" });
            DropIndex("dbo.SurveyQuestion", new[] { "SurveyID" });
            DropIndex("dbo.SurveyQuestion", new[] { "QID" });
            DropIndex("dbo.vendor", new[] { "VendorTypeID" });
            DropIndex("dbo.Location", new[] { "VendorID" });
            DropIndex("dbo.WaitList", new[] { "StudentID" });
            DropIndex("dbo.Enrollments", new[] { "ScheduledClassID" });
            DropIndex("dbo.Enrollments", new[] { "StudentID" });
            DropIndex("dbo.Enrollments", new[] { "statusID" });
            DropIndex("dbo.ScheduledClass", new[] { "SurveyID" });
            DropIndex("dbo.ScheduledClass", new[] { "InstructorID" });
            DropIndex("dbo.ScheduledClass", new[] { "locationID" });
            DropIndex("dbo.ScheduledClass", new[] { "courseNumber" });
            DropIndex("dbo.Course", new[] { "basePriceID" });
            DropIndex("dbo.Course", new[] { "courseTypeDetailID" });
            DropIndex("dbo.CourseTypeDetail", new[] { "CourseTypeID" });
            DropIndex("dbo.CourseType", new[] { "AreaID" });
            DropTable("dbo.aspnet_UsersInRoles");
            DropTable("dbo.subCategory");
            DropTable("dbo.StudentNote");
            DropTable("dbo.StudentNote2");
            DropTable("dbo.StudentDistribution");
            DropTable("dbo.StudentCertifications");
            DropTable("dbo.ReferredBy");
            DropTable("dbo.Promo");
            DropTable("dbo.Payment");
            DropTable("dbo.NoteType");
            DropTable("dbo.News");
            DropTable("dbo.Manager");
            DropTable("dbo.InstructorNote");
            DropTable("dbo.instructorCert");
            DropTable("dbo.insSkill");
            DropTable("dbo.insCertification");
            DropTable("dbo.insCategory");
            DropTable("dbo.IncomeType");
            DropTable("dbo.Income");
            DropTable("dbo.ExpenseType");
            DropTable("dbo.Expense");
            DropTable("dbo.dtproperties");
            DropTable("dbo.Course_CourseType");
            DropTable("dbo.Course_Area");
            DropTable("dbo.contact");
            DropTable("dbo.ContactNote");
            DropTable("dbo.company");
            DropTable("dbo.ComContact");
            DropTable("dbo.ComContactNote");
            DropTable("dbo.ClassRequest");
            DropTable("dbo.Category");
            DropTable("dbo.CaseStudy");
            DropTable("dbo.Authority");
            DropTable("dbo.aspnet_WebEvent_Events");
            DropTable("dbo.aspnet_SchemaVersions");
            DropTable("dbo.aspnet_Roles");
            DropTable("dbo.aspnet_Profile");
            DropTable("dbo.aspnet_PersonalizationAllUsers");
            DropTable("dbo.aspnet_Paths");
            DropTable("dbo.aspnet_PersonalizationPerUser");
            DropTable("dbo.aspnet_Users");
            DropTable("dbo.aspnet_Membership");
            DropTable("dbo.aspnet_Applications");
            DropTable("dbo.SectionType");
            DropTable("dbo.AType");
            DropTable("dbo.Question");
            DropTable("dbo.SurveyQuestion");
            DropTable("dbo.Survey");
            DropTable("dbo.VendorType");
            DropTable("dbo.vendor");
            DropTable("dbo.Location");
            DropTable("dbo.Instructor");
            DropTable("dbo.WaitList");
            DropTable("dbo.student");
            DropTable("dbo.Status");
            DropTable("dbo.Enrollments");
            DropTable("dbo.ScheduledClass");
            DropTable("dbo.BasePrice");
            DropTable("dbo.Course");
            DropTable("dbo.CourseTypeDetail");
            DropTable("dbo.CourseType");
            DropTable("dbo.area");
            DropTable("dbo.Answer");
            DropTable("dbo.Admin");
        }
    }
}
