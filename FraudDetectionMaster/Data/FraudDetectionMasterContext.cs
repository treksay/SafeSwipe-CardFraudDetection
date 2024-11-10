using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using FraudDetectionMaster.Models;

namespace FraudDetectionMaster.Data;

public class FraudDetectionMasterContext : DbContext
    {
         public FraudDetectionMasterContext(DbContextOptions<FraudDetectionMasterContext> options) : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-G6H10CB\SQLEXPRESS;Database=FraudDetect;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

    }

