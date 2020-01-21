using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext (DbContextOptions options) : base(options)
        {
          
        }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            base.OnModelCreating(modelBuilder);
            
           /* modelBuilder.Entity<Product>()

                .Property(sample => sample.price)

                .HasColumnType("decimal(13, 4)");*/

        }



        public DbSet<Account> Accounts { get; set; }
    }
}
