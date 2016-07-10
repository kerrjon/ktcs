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

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<area> areas { get; set; }
        public virtual DbSet<AType> ATypes { get; set; }
        public virtual DbSet<BasePrice> BasePrices { get; set; }
        public virtual DbSet<CaseStudy> CaseStudies { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ClassRequest> ClassRequests { get; set; }
        public virtual DbSet<ComContact> ComContacts { get; set; }
        public virtual DbSet<ComContactNote> ComContactNotes { get; set; }
        public virtual DbSet<company> companies { get; set; }
        public virtual DbSet<contact> contacts { get; set; }
        public virtual DbSet<ContactNote> ContactNotes { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Course_Area> Course_Area { get; set; }
        public virtual DbSet<Course_CourseType> Course_CourseType { get; set; }
        public virtual DbSet<CourseType> CourseTypes { get; set; }
        public virtual DbSet<CourseTypeDetail> CourseTypeDetails { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<ExpenseType> ExpenseTypes { get; set; }
        public virtual DbSet<Income> Incomes { get; set; }
        public virtual DbSet<IncomeType> IncomeTypes { get; set; }
        public virtual DbSet<insCategory> insCategories { get; set; }
        public virtual DbSet<insCertification> insCertifications { get; set; }
        public virtual DbSet<insSkill> insSkills { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<instructorCert> instructorCerts { get; set; }
        public virtual DbSet<InstructorNote> InstructorNotes { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NoteType> NoteTypes { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Promo> Promoes { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<ReferredBy> ReferredBies { get; set; }
        public virtual DbSet<ScheduledClass> ScheduledClasses { get; set; }
        public virtual DbSet<SectionType> SectionTypes { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<StudentCertification> StudentCertifications { get; set; }
        public virtual DbSet<StudentDistribution> StudentDistributions { get; set; }
        public virtual DbSet<StudentNote> StudentNotes { get; set; }
        public virtual DbSet<StudentNote2> StudentNote2 { get; set; }
        public virtual DbSet<subCategory> subCategories { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<SurveyQuestion> SurveyQuestions { get; set; }
        public virtual DbSet<vendor> vendors { get; set; }
        public virtual DbSet<VendorType> VendorTypes { get; set; }
        public virtual DbSet<WaitList> WaitLists { get; set; }
        public virtual DbSet<Authority> Authorities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.SysAdmin)
                .IsUnicode(false);

            modelBuilder.Entity<Answer>()
                .Property(e => e.AnswerNum)
                .HasPrecision(2, 0);

            modelBuilder.Entity<area>()
                .HasMany(e => e.CourseTypes)
                .WithRequired(e => e.area)
                .WillCascadeOnDelete(false);

            

            modelBuilder.Entity<AType>()
                .Property(e => e.AType1)
                .IsUnicode(false);

            modelBuilder.Entity<AType>()
                .HasMany(e => e.Questions)
                .WithRequired(e => e.AType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BasePrice>()
                .Property(e => e.BasePrice1)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BasePrice>()
                .Property(e => e.BaseDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BasePrice>()
                .Property(e => e.membership)
                .IsUnicode(false);

            modelBuilder.Entity<BasePrice>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.BasePrice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CaseStudy>()
                .Property(e => e.CaseStudyTitle)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CaseStudy>()
                .Property(e => e.CaseStudyText)
                .IsUnicode(false);

            modelBuilder.Entity<CaseStudy>()
                .Property(e => e.visible)
                .IsUnicode(false);

            modelBuilder.Entity<CaseStudy>()
                .Property(e => e.CaseSummary)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Category1)
                .IsUnicode(false);

            modelBuilder.Entity<ClassRequest>()
                .Property(e => e.Denied)
                .IsUnicode(false);

            modelBuilder.Entity<ClassRequest>()
                .Property(e => e.Withdrew)
                .IsUnicode(false);

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
                .Property(e => e.toDoFor)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.billname)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.billaddress)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.billaddress2)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.billcity)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.billstate)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.billzip)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.billphone)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.billfax)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.billcountry)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.logo)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.billemail)
                .IsUnicode(false);

            modelBuilder.Entity<contact>()
                .Property(e => e.conext1)
                .IsUnicode(false);

            modelBuilder.Entity<contact>()
                .Property(e => e.conext2)
                .IsUnicode(false);

            modelBuilder.Entity<ContactNote>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<ContactNote>()
                .Property(e => e.Priority)
                .IsUnicode(false);

            modelBuilder.Entity<ContactNote>()
                .Property(e => e.toDoFor)
                .IsUnicode(false);

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
                .HasMany(e => e.ScheduledClasses)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CourseType>()
                .HasMany(e => e.CourseTypeDetails)
                .WithRequired(e => e.CourseType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<Enrollment>()
                .Property(e => e.Paid)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Enrollment>()
                .Property(e => e.Discount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Enrollment>()
                .Property(e => e.MTSfee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Enrollment>()
                .Property(e => e.Amountdue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Enrollment>()
                .Property(e => e.mgrConfirmation)
                .IsUnicode(false);

            modelBuilder.Entity<Enrollment>()
                .Property(e => e.conarchived)
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

            modelBuilder.Entity<insCategory>()
                .Property(e => e.insCategory1)
                .IsUnicode(false);

            modelBuilder.Entity<insCertification>()
                .Property(e => e.insCertification1)
                .IsUnicode(false);

            modelBuilder.Entity<insSkill>()
                .Property(e => e.insSkill1)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.InstructorID)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.insIndependent)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.insReferredBy)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.Keywords)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.resumeText)
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
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.coursewareNotes)
                .IsUnicode(false);

            modelBuilder.Entity<instructorCert>()
                .Property(e => e.insCertification)
                .IsUnicode(false);

            modelBuilder.Entity<instructorCert>()
                .Property(e => e.instructorID)
                .IsUnicode(false);

            modelBuilder.Entity<InstructorNote>()
                .Property(e => e.InstructorID)
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
                .Property(e => e.toDoFor)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.ScheduledClasses)
                .WithRequired(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.PayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Promo>()
                .Property(e => e.promoTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Promo>()
                .Property(e => e.promoText)
                .IsUnicode(false);

            modelBuilder.Entity<Promo>()
                .Property(e => e.promorules)
                .IsUnicode(false);

            modelBuilder.Entity<Promo>()
                .Property(e => e.MajorPromo)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.Question1)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.SurveyQuestions)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ScheduledClass>()
                .Property(e => e.startTime)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledClass>()
                .Property(e => e.endTime)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledClass>()
                .Property(e => e.Price)
                .HasPrecision(10, 4);

            modelBuilder.Entity<ScheduledClass>()
                .Property(e => e.MarketRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<ScheduledClass>()
                .Property(e => e.ispublic)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledClass>()
                .Property(e => e.KTCSRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<ScheduledClass>()
                .Property(e => e.KTCScourse)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledClass>()
                .Property(e => e.startDateconfirmed)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledClass>()
                .Property(e => e.bookOrderMade)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledClass>()
                .Property(e => e.insTestReminder)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledClass>()
                .Property(e => e.bookOrderRecieved)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledClass>()
                .Property(e => e.insconfirmed)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledClass>()
                .Property(e => e.locconfirmed)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledClass>()
                .Property(e => e.InstructorID)
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

            modelBuilder.Entity<student>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.stuInternationalCode)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.BillInternationalCode)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.OtherCompany)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.OtherReferredBy)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.OtherManager)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.OtherManagerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.mailList)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.blockReminder)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.other)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.stuarchived)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .HasMany(e => e.Enrollments)
                .WithRequired(e => e.student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<student>()
                .HasMany(e => e.WaitLists)
                .WithRequired(e => e.student)
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

            modelBuilder.Entity<subCategory>()
                .Property(e => e.subCategory1)
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
                .HasMany(e => e.vendors)
                .WithRequired(e => e.VendorType)
                .WillCascadeOnDelete(false);
        }
    }
}
