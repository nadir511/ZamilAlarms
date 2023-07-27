using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using ZamilAlarms.Database.StoredProcedure;

namespace ZamilAlarms.Database
{
    public partial class OmniConnectDB : DbContext
    {
        public OmniConnectDB()
        {

        }
        public OmniConnectDB(DbContextOptions<OmniConnectDB> options)
        : base(options)
        {
        }
        #region|Tables|

        #endregion

        #region|Stored Procedures|
        public virtual DbSet<PerfectDataAlarmsTrigrring> PerfectDataAlarmsTrigrrings { get; set; } = null!;
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region|Stored Procedures|
            modelBuilder.Entity<PerfectDataAlarmsTrigrring>(entity =>
            {
                entity.HasNoKey();
            });
            #endregion
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
