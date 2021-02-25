﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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

    }
}
