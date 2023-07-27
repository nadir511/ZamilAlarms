using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZamilAlarms.Database;
using ZamilAlarms.Database.StoredProcedure;

namespace ZamilAlarms
{
    public class GetAlarmList
    {
        private readonly OmniConnectDB _db;

        public GetAlarmList(OmniConnectDB omniConnectDB)
        {
            _db = omniConnectDB;
        }
        [FunctionName("GetAlarmList")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var parameters = new[]
                           {
                           new SqlParameter("@siteId", 779),
                           new SqlParameter("@startDate", DateTime.UtcNow.AddDays(-1)),
                           new SqlParameter("@EndDate", DateTime.UtcNow),
                           };
            var alarmsList = await _db.PerfectDataAlarmsTrigrrings
                          .FromSqlRaw("exec PerfectDataAlarmsTrigrring @siteId,@startDate,@EndDate", parameters).ToListAsync();
            List<AlarmsListVM> Obj = new List<AlarmsListVM>();
            Obj = alarmsList.Select(x => new AlarmsListVM
            {
                DataAlarmName = x.DataAlarm_Name,
                AalarmStatus = x.AS_Title,
                AlarmPriority = x.AlarmPriority_Title,
                AlarmState = x.State_Title,
                SetPoint = x.Value,
                TagValue = x.Current_Value,
                ReadingTime = x.Reading_Time,
                isActive = x.isActive
            }).ToList();

            return new OkObjectResult(Obj);
        }
    }
}
