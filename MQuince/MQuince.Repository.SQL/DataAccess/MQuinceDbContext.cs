
using Microsoft.EntityFrameworkCore;
using MQuince.Repository.SQL.PersistenceEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MQuince.Repository.SQL.DataAccess
{
    public class MQuinceDbContext : DbContext
    {
        public DbSet<FeedbackPersistence> Feedbacks { get; set; }
        public DbSet<UserPersistence> Users { get; set; }

        public MQuinceDbContext(DbContextOptions options) : base(options) { }

        public MQuinceDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=MQuinceDB;Integrated Security=True");
        }

    }
}
