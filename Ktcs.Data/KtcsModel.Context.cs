﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ktcs.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KtcsEntities : DbContext
    {
        public KtcsEntities()
            : base("name=KtcsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<area> areas { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AType> ATypes { get; set; }
        public virtual DbSet<BasePrice> BasePrices { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<BrandCategory> BrandCategories { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ClassRequest> ClassRequests { get; set; }
        public virtual DbSet<ComContact> ComContacts { get; set; }
        public virtual DbSet<ComContactNote> ComContactNotes { get; set; }
        public virtual DbSet<company> companies { get; set; }
        public virtual DbSet<contact> contacts { get; set; }
        public virtual DbSet<ContactNote> ContactNotes { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Course_CourseTypeDetail> Course_CourseTypeDetail { get; set; }
        public virtual DbSet<CourseType> CourseTypes { get; set; }
        public virtual DbSet<CourseTypeDetail> CourseTypeDetails { get; set; }
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
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<ReferredBy> ReferredBies { get; set; }
        public virtual DbSet<ScheduledClass> ScheduledClasses { get; set; }
        public virtual DbSet<SectionType> SectionTypes { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<StudentDistribution> StudentDistributions { get; set; }
        public virtual DbSet<StudentNote> StudentNotes { get; set; }
        public virtual DbSet<StudentNote2> StudentNote2 { get; set; }
        public virtual DbSet<subCategory> subCategories { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<SurveyQuestion> SurveyQuestions { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<TopicCategory> TopicCategories { get; set; }
        public virtual DbSet<vendor> vendors { get; set; }
        public virtual DbSet<VendorType> VendorTypes { get; set; }
        public virtual DbSet<WaitList> WaitLists { get; set; }
        public virtual DbSet<Authority> Authorities { get; set; }
        public virtual DbSet<DeliveryFormat> DeliveryFormats { get; set; }
    }
}
