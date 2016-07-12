using Ktcs.Classes;

namespace Ktcs.Datamodel
{
  using System.Data.Entity;

  public partial class KtcsDbContext : DbContext
  {
    public KtcsDbContext()
        : base("name=KtcsDbContext")
    {
    }

    public virtual DbSet<Answer> Answers { get; set; }
    public virtual DbSet<AType> ATypes { get; set; }
    public virtual DbSet<Brand> Brands { get; set; }
    public virtual DbSet<BrandCategory> BrandCategories { get; set; }
    public virtual DbSet<ClassRequest> ClassRequests { get; set; }
    public virtual DbSet<ComContact> ComContacts { get; set; }
    public virtual DbSet<ComContactNote> ComContactNotes { get; set; }
    public virtual DbSet<Company> Companies { get; set; }
    public virtual DbSet<Contact> Contacts { get; set; }
    public virtual DbSet<ContactNote> ContactNotes { get; set; }
    public virtual DbSet<Course> Courses { get; set; }
    public virtual DbSet<Enrollment> Enrollments { get; set; }
    public virtual DbSet<Expense> Expenses { get; set; }
    public virtual DbSet<ExpenseType> ExpenseTypes { get; set; }
    public virtual DbSet<Income> Incomes { get; set; }
    public virtual DbSet<IncomeType> IncomeTypes { get; set; }
    public virtual DbSet<InsCategory> InsCategories { get; set; }
    public virtual DbSet<InsCertification> InsCertifications { get; set; }
    public virtual DbSet<InsSkill> InsSkills { get; set; }
    public virtual DbSet<Instructor> Instructors { get; set; }
    public virtual DbSet<InstructorCert> InstructorCerts { get; set; }
    public virtual DbSet<InstructorNote> InstructorNotes { get; set; }
    public virtual DbSet<Location> Locations { get; set; }
    public virtual DbSet<Manager> Managers { get; set; }
    public virtual DbSet<NoteType> NoteTypes { get; set; }
    public virtual DbSet<Payment> Payments { get; set; }
    public virtual DbSet<Question> Questions { get; set; }
    public virtual DbSet<ReferredBy> ReferredBies { get; set; }
    public virtual DbSet<ScheduledClass> ScheduledClasses { get; set; }
    public virtual DbSet<SectionType> SectionTypes { get; set; }
    public virtual DbSet<Status> Status { get; set; }
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<StudentCertification> StudentCertifications { get; set; }
    public virtual DbSet<StudentDistribution> StudentDistributions { get; set; }
    public virtual DbSet<StudentNote> StudentNotes { get; set; }
    public virtual DbSet<StudentNote2> StudentNote2 { get; set; }
    public virtual DbSet<Survey> Surveys { get; set; }
    public virtual DbSet<SurveyQuestion> SurveyQuestions { get; set; }
    public virtual DbSet<Topic> Topics { get; set; }
    public virtual DbSet<TopicCategory> TopicCategories { get; set; }
    public virtual DbSet<Vendor> Vendors { get; set; }
    public virtual DbSet<VendorType> VendorTypes { get; set; }
    public virtual DbSet<WaitList> WaitLists { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {

      modelBuilder.Entity<Answer>()
          .Property(e => e.AnswerNum)
          .HasPrecision(2, 0);

      modelBuilder.Entity<AType>()
          .Property(e => e.AType1)
          .IsUnicode(false);

      modelBuilder.Entity<AType>()
          .HasMany(e => e.Questions)
          .WithRequired(e => e.AType)
          .WillCascadeOnDelete(false);


      modelBuilder.Entity<BrandCategory>()
          .HasMany(e => e.Courses)
          .WithMany(e => e.BrandCategories)
          .Map(m => m.ToTable("CourseBrandCategory").MapLeftKey("brandCategoryId").MapRightKey("courseNumber"));


      //modelBuilder.Entity<ClassRequest>()
      //    .Property(e => e.Withdrew)
      //    .IsUnicode(false);

      modelBuilder.Entity<ComContact>()
          .Property(e => e.ComConFName)
          .IsUnicode(false);

      modelBuilder.Entity<ComContact>()
          .Property(e => e.ComConLName)
          .IsUnicode(false);

      modelBuilder.Entity<ComContact>()
          .Property(e => e.ComConAddress)
          .IsUnicode(false);

      modelBuilder.Entity<ComContact>()
          .Property(e => e.ComConAddress2)
          .IsUnicode(false);

      modelBuilder.Entity<ComContact>()
          .Property(e => e.ComConCity)
          .IsUnicode(false);

      modelBuilder.Entity<ComContact>()
          .Property(e => e.ComConState)
          .IsFixedLength()
          .IsUnicode(false);

      modelBuilder.Entity<ComContact>()
          .Property(e => e.ComConZip)
          .IsUnicode(false);

      modelBuilder.Entity<ComContact>()
          .Property(e => e.ComConPhone)
          .IsUnicode(false);

      modelBuilder.Entity<ComContact>()
          .Property(e => e.ComConPhone2)
          .IsUnicode(false);

      modelBuilder.Entity<ComContact>()
          .Property(e => e.ComConEmail)
          .IsUnicode(false);

      modelBuilder.Entity<ComContact>()
          .Property(e => e.ComConEmail2)
          .IsUnicode(false);

      modelBuilder.Entity<ComContact>()
          .Property(e => e.ComConFax)
          .IsUnicode(false);

      modelBuilder.Entity<ComContact>()
          .Property(e => e.ComConCountry)
          .IsUnicode(false);

      modelBuilder.Entity<ComContactNote>()
          .Property(e => e.Notes)
          .IsUnicode(false);

      modelBuilder.Entity<ComContactNote>()
          .Property(e => e.AdminInitials)
          .IsUnicode(false);

      modelBuilder.Entity<ComContactNote>()
          .Property(e => e.Priority)
          .IsUnicode(false);

      modelBuilder.Entity<ComContactNote>()
          .Property(e => e.ToDoFor)
          .IsUnicode(false);

      modelBuilder.Entity<Company>()
          .Property(e => e.Billname)
          .IsUnicode(false);

      modelBuilder.Entity<Company>()
          .Property(e => e.Billaddress)
          .IsUnicode(false);

      modelBuilder.Entity<Company>()
          .Property(e => e.Billaddress2)
          .IsUnicode(false);

      modelBuilder.Entity<Company>()
          .Property(e => e.Billcity)
          .IsUnicode(false);

      modelBuilder.Entity<Company>()
          .Property(e => e.Billstate)
          .IsUnicode(false);

      modelBuilder.Entity<Company>()
          .Property(e => e.Billzip)
          .IsUnicode(false);

      modelBuilder.Entity<Company>()
          .Property(e => e.Billphone)
          .IsUnicode(false);

      modelBuilder.Entity<Company>()
          .Property(e => e.Billfax)
          .IsUnicode(false);

      modelBuilder.Entity<Company>()
          .Property(e => e.Billcountry)
          .IsUnicode(false);

      modelBuilder.Entity<Company>()
          .Property(e => e.Logo)
          .IsUnicode(false);

      modelBuilder.Entity<Company>()
          .Property(e => e.Billemail)
          .IsUnicode(false);

      modelBuilder.Entity<Contact>()
          .Property(e => e.Conext1)
          .IsUnicode(false);

      modelBuilder.Entity<Contact>()
          .Property(e => e.Conext2)
          .IsUnicode(false);

      modelBuilder.Entity<ContactNote>()
          .Property(e => e.Notes)
          .IsUnicode(false);

      modelBuilder.Entity<ContactNote>()
          .Property(e => e.Priority)
          .IsUnicode(false);

      modelBuilder.Entity<ContactNote>()
          .Property(e => e.ToDoFor)
          .IsUnicode(false);

      modelBuilder.Entity<Course>()
          .Property(e => e.Courseware)
          .IsUnicode(false);

      modelBuilder.Entity<Course>()
          .Property(e => e.Coursewarevendor)
          .IsUnicode(false);

      modelBuilder.Entity<Course>()
          .Property(e => e.Coursewarecost)
          .HasPrecision(9, 2);

      modelBuilder.Entity<Course>()
          .Property(e => e.Coursewarenotes)
          .IsUnicode(false);

      modelBuilder.Entity<Course>()
          .Property(e => e.InstructorNotes)
          .IsUnicode(false);

      modelBuilder.Entity<Course>()
          .Property(e => e.Vendorwebsite)
          .IsUnicode(false);

      modelBuilder.Entity<Course>()
          .HasMany(e => e.ScheduledClasses)
          .WithRequired(e => e.Course)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<Course>()
          .HasMany(e => e.TopicCategories)
          .WithMany(e => e.Courses)
          .Map(m => m.ToTable("CourseTopicCategory").MapLeftKey("courseNumber").MapRightKey("topicCategoryId"));

      modelBuilder.Entity<Enrollment>()
          .Property(e => e.Paid)
          .HasPrecision(19, 4);

      modelBuilder.Entity<Enrollment>()
          .Property(e => e.Discount)
          .HasPrecision(19, 4);

      modelBuilder.Entity<Enrollment>()
          .Property(e => e.MtSfee)
          .HasPrecision(19, 4);

      modelBuilder.Entity<Enrollment>()
          .Property(e => e.Amountdue)
          .HasPrecision(19, 4);

      modelBuilder.Entity<Enrollment>()
          .Property(e => e.MgrConfirmation)
          .IsUnicode(false);

      modelBuilder.Entity<Enrollment>()
          .Property(e => e.Conarchived)
          .IsUnicode(false);

      modelBuilder.Entity<Enrollment>()
          .Property(e => e.DiscountDollars)
          .HasPrecision(19, 4);

      modelBuilder.Entity<Expense>()
          .Property(e => e.Cost)
          .HasPrecision(10, 4);

      modelBuilder.Entity<Expense>()
          .Property(e => e.VenInvoicePaid)
          .IsUnicode(false);

      modelBuilder.Entity<Expense>()
          .Property(e => e.Tax)
          .HasPrecision(10, 4);

      modelBuilder.Entity<Expense>()
          .Property(e => e.Shipping)
          .HasPrecision(10, 4);

      modelBuilder.Entity<Income>()
          .Property(e => e.Cost)
          .HasPrecision(10, 4);

      modelBuilder.Entity<Income>()
          .Property(e => e.VenInvoicePaid)
          .IsUnicode(false);

      modelBuilder.Entity<Income>()
          .Property(e => e.Tax)
          .HasPrecision(10, 4);

      modelBuilder.Entity<Income>()
          .Property(e => e.Shipping)
          .HasPrecision(10, 4);

      modelBuilder.Entity<IncomeType>()
          .Property(e => e.IncomeType1)
          .IsUnicode(false);

      modelBuilder.Entity<InsCategory>()
          .Property(e => e.InsCategory1)
          .IsUnicode(false);

      modelBuilder.Entity<InsCertification>()
          .Property(e => e.InsCertification1)
          .IsUnicode(false);

      modelBuilder.Entity<InsSkill>()
          .Property(e => e.InsSkill1)
          .IsUnicode(false);

      modelBuilder.Entity<Instructor>()
          .Property(e => e.InstructorId)
          .IsUnicode(false);

      modelBuilder.Entity<Instructor>()
          .Property(e => e.Password)
          .IsUnicode(false);

      modelBuilder.Entity<Instructor>()
          .Property(e => e.InsIndependent)
          .IsUnicode(false);

      modelBuilder.Entity<Instructor>()
          .Property(e => e.InsReferredBy)
          .IsUnicode(false);

      modelBuilder.Entity<Instructor>()
          .Property(e => e.Keywords)
          .IsUnicode(false);

      modelBuilder.Entity<Instructor>()
          .Property(e => e.ResumeText)
          .IsUnicode(false);

      modelBuilder.Entity<Instructor>()
          .Property(e => e.Skill1)
          .IsUnicode(false);

      modelBuilder.Entity<Instructor>()
          .Property(e => e.Skill2)
          .IsUnicode(false);

      modelBuilder.Entity<Instructor>()
          .Property(e => e.Skill3)
          .IsUnicode(false);

      modelBuilder.Entity<Instructor>()
          .Property(e => e.Skill4)
          .IsUnicode(false);

      modelBuilder.Entity<Instructor>()
          .Property(e => e.Skill5)
          .IsUnicode(false);

      modelBuilder.Entity<Instructor>()
          .Property(e => e.Category1)
          .IsUnicode(false);

      modelBuilder.Entity<Instructor>()
          .Property(e => e.Category2)
          .IsUnicode(false);

      modelBuilder.Entity<Instructor>()
          .Property(e => e.Category3)
          .IsUnicode(false);

      modelBuilder.Entity<Instructor>()
          .Property(e => e.Notes)
          .IsUnicode(false);

      modelBuilder.Entity<Instructor>()
          .Property(e => e.CoursewareNotes)
          .IsUnicode(false);

      modelBuilder.Entity<InstructorCert>()
          .Property(e => e.InsCertification)
          .IsUnicode(false);

      modelBuilder.Entity<InstructorCert>()
          .Property(e => e.InstructorId)
          .IsUnicode(false);

      modelBuilder.Entity<InstructorNote>()
          .Property(e => e.InstructorId)
          .IsUnicode(false);

      modelBuilder.Entity<InstructorNote>()
          .Property(e => e.Notes)
          .IsUnicode(false);

      modelBuilder.Entity<InstructorNote>()
          .Property(e => e.AdminInitials)
          .IsUnicode(false);

      modelBuilder.Entity<InstructorNote>()
          .Property(e => e.FollowUp)
          .IsUnicode(false);

      modelBuilder.Entity<InstructorNote>()
          .Property(e => e.Priority)
          .IsUnicode(false);

      modelBuilder.Entity<InstructorNote>()
          .Property(e => e.ToDoFor)
          .IsUnicode(false);

      modelBuilder.Entity<Location>()
          .HasMany(e => e.ScheduledClasses)
          .WithRequired(e => e.Location)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<Payment>()
          .Property(e => e.PayAmount)
          .HasPrecision(19, 4);

      modelBuilder.Entity<Question>()
          .Property(e => e.Question1)
          .IsUnicode(false);

      modelBuilder.Entity<Question>()
          .HasMany(e => e.SurveyQuestions)
          .WithRequired(e => e.Question)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<ScheduledClass>()
          .Property(e => e.StartTime)
          .IsUnicode(false);

      modelBuilder.Entity<ScheduledClass>()
          .Property(e => e.EndTime)
          .IsUnicode(false);

      modelBuilder.Entity<ScheduledClass>()
          .Property(e => e.Price)
          .HasPrecision(10, 4);

      modelBuilder.Entity<ScheduledClass>()
          .Property(e => e.MarketRate)
          .HasPrecision(10, 4);

      modelBuilder.Entity<ScheduledClass>()
          .Property(e => e.Ispublic)
          .IsUnicode(false);

      modelBuilder.Entity<ScheduledClass>()
          .Property(e => e.KtcsRate)
          .HasPrecision(10, 4);

      modelBuilder.Entity<ScheduledClass>()
          .Property(e => e.KtcScourse)
          .IsUnicode(false);

      modelBuilder.Entity<ScheduledClass>()
          .Property(e => e.StartDateconfirmed)
          .IsUnicode(false);

      modelBuilder.Entity<ScheduledClass>()
          .Property(e => e.BookOrderMade)
          .IsUnicode(false);

      modelBuilder.Entity<ScheduledClass>()
          .Property(e => e.InsTestReminder)
          .IsUnicode(false);

      modelBuilder.Entity<ScheduledClass>()
          .Property(e => e.BookOrderRecieved)
          .IsUnicode(false);

      modelBuilder.Entity<ScheduledClass>()
          .Property(e => e.Insconfirmed)
          .IsUnicode(false);

      modelBuilder.Entity<ScheduledClass>()
          .Property(e => e.Locconfirmed)
          .IsUnicode(false);

      modelBuilder.Entity<ScheduledClass>()
          .Property(e => e.InstructorId)
          .IsUnicode(false);

      modelBuilder.Entity<ScheduledClass>()
          .Property(e => e.Mirrored)
          .IsUnicode(false);

      modelBuilder.Entity<ScheduledClass>()
          .Property(e => e.MirroredWebsite)
          .IsUnicode(false);

      modelBuilder.Entity<ScheduledClass>()
          .HasMany(e => e.Enrollments)
          .WithRequired(e => e.ScheduledClass)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<SectionType>()
          .Property(e => e.SectionName)
          .IsUnicode(false);

      modelBuilder.Entity<SectionType>()
          .HasMany(e => e.Questions)
          .WithRequired(e => e.SectionType)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<Status>()
          .HasMany(e => e.Enrollments)
          .WithRequired(e => e.Status)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<Student>()
          .Property(e => e.Password)
          .IsUnicode(false);

      modelBuilder.Entity<Student>()
          .Property(e => e.StuInternationalCode)
          .IsUnicode(false);

      modelBuilder.Entity<Student>()
          .Property(e => e.BillInternationalCode)
          .IsUnicode(false);

      modelBuilder.Entity<Student>()
          .Property(e => e.OtherCompany)
          .IsUnicode(false);

      modelBuilder.Entity<Student>()
          .Property(e => e.OtherReferredBy)
          .IsUnicode(false);

      modelBuilder.Entity<Student>()
          .Property(e => e.OtherManager)
          .IsUnicode(false);

      modelBuilder.Entity<Student>()
          .Property(e => e.OtherManagerPhone)
          .IsUnicode(false);

      modelBuilder.Entity<Student>()
          .Property(e => e.MailList)
          .IsUnicode(false);

      modelBuilder.Entity<Student>()
          .Property(e => e.UserId)
          .IsUnicode(false);

      modelBuilder.Entity<Student>()
          .Property(e => e.BlockReminder)
          .IsUnicode(false);

      modelBuilder.Entity<Student>()
          .Property(e => e.Other)
          .IsUnicode(false);

      modelBuilder.Entity<Student>()
          .Property(e => e.Stuarchived)
          .IsUnicode(false);

      modelBuilder.Entity<Student>()
          .HasMany(e => e.Enrollments)
          .WithRequired(e => e.Student)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<Student>()
          .HasMany(e => e.WaitLists)
          .WithRequired(e => e.Student)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<StudentDistribution>()
          .Property(e => e.ExamStatus)
          .IsUnicode(false);

      modelBuilder.Entity<StudentNote>()
          .Property(e => e.ToDoFor)
          .IsUnicode(false);

      modelBuilder.Entity<StudentNote>()
          .Property(e => e.Priority)
          .IsUnicode(false);

      modelBuilder.Entity<StudentNote2>()
          .Property(e => e.ToDoFor)
          .IsUnicode(false);

      modelBuilder.Entity<StudentNote2>()
          .Property(e => e.Priority)
          .IsUnicode(false);


      modelBuilder.Entity<Survey>()
          .Property(e => e.SurveyName)
          .IsUnicode(false);

      modelBuilder.Entity<Survey>()
          .Property(e => e.Creator)
          .IsUnicode(false);

      modelBuilder.Entity<Survey>()
          .Property(e => e.DefaultSurvey)
          .IsUnicode(false);

      modelBuilder.Entity<Survey>()
          .HasMany(e => e.ScheduledClasses)
          .WithRequired(e => e.Survey)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<Survey>()
          .HasMany(e => e.SurveyQuestions)
          .WithRequired(e => e.Survey)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<VendorType>()
          .HasMany(e => e.Vendors)
          .WithRequired(e => e.VendorType)
          .WillCascadeOnDelete(false);
    }
  }
}
