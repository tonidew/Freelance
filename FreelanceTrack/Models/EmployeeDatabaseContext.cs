﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FreelanceTrack.Models
{
    public class EmployeeDatabaseContext : DbContext
{
    public DbSet<Freelancer> Freelancer { get; set; }
    public DbSet<Assignment> Assignment { get; set; }
    public DbSet<Invoice> Invoice { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //this incorporates the tables you need
            //can configure more than this, could do anything you want

            modelBuilder.Entity<Freelancer>()
                .ToTable("Freelancer")
                .HasKey(c => c.FreelancerId);

            modelBuilder.Entity<Assignment>()
               .ToTable("Assignment")
               .HasKey(c => c.AssignmentId);

            modelBuilder.Entity<Invoice>()
                .ToTable("Invoice")
                .HasKey(c => c.InvoiceId);
        }
}
}