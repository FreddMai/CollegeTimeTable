﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PRPJECT4NEW
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Classes_SM1> Classes_SM1 { get; set; }
        public virtual DbSet<Classes_SM2> Classes_SM2 { get; set; }
        public virtual DbSet<Course_detail> Course_detail { get; set; }
        public virtual DbSet<cours> courses { get; set; }
        public virtual DbSet<Lecture_Course> Lecture_Course { get; set; }
        public virtual DbSet<Scholarship> Scholarships { get; set; }
        public virtual DbSet<Student_Courses> Student_Courses { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<DF_requests> DF_requests { get; set; }
        public virtual DbSet<Teaching_Stuff> Teaching_Stuff { get; set; }
        public virtual DbSet<Student_special_Exam> Student_special_Exam { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Student_special_Exam> Student_special_Exam { get; set; }
        public virtual DbSet<Conference> Conferences { get; set; }
    }
}
