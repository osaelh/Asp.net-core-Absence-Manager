using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AbsenceManager.Models;

namespace AbsenceManager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
      
        public virtual DbSet<Student> Students { get; set; }
        public DbSet<AbsenceHistory> AbsenceHistories { get; set; }
        public DbSet<AbsenceType> AbsenceTypes { get; set; }
        public DbSet<AbsenceAllocation> AbsenceAllocations { get; set; }
        public DbSet<AbsenceManager.Models.StudentViewModel> StudentViewModel { get; set; }
        public DbSet<AbsenceManager.Models.DetailsAbsenceTypeViewModel> DetailsAbsenceTypeViewModel { get; set; }
        public DbSet<AbsenceManager.Models.EditAbsenceAllocationViewModel> EditAbsenceAllocationViewModel { get; set; }

    }
}
