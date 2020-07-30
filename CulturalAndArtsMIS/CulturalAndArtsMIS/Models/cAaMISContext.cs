using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturalAndArtsMIS.Models
{
    public class cAaMISContext : DbContext
    {
        public cAaMISContext()
            : base("cAaMISContext")
        {
            Database.SetInitializer<cAaMISContext>(new cAaDbInitializer());
        }

        public DbSet<YearListOfEvents> YearListOfEvents { get; set; }
        public DbSet<StudentProfile> StudentProfile { get; set; }
        public DbSet<UserAccount> UserAccount { get; set; }
        public DbSet<ExternalRequest> ExternalRequest { get; set; }

        public DbSet<Setting> Setting { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<YearListOfEvents>().HasKey(k => k.yearListOfEvents_ID)
                .Property(p => p.yearListOfEvents_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<StudentProfile>().HasKey(k => k.studentProfile_ID)
              .Property(p => p.studentProfile_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<UserAccount>().HasKey(k => k.ua_ID)
              .Property(p => p.ua_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ExternalRequest>().HasKey(k => k.er_ID)
              .Property(p => p.er_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Setting>().HasKey(k => k.setting_ID)
             .Property(p => p.setting_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }
    }
}
