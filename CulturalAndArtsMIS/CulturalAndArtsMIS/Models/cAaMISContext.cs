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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<YearListOfEvents>().HasKey(k => k.yearListOfEvents_ID)
                .Property(p => p.yearListOfEvents_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
