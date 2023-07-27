using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZamilAlarms.Database.StoredProcedure
{
    public class PerfectDataAlarmsTrigrring
    {
        public int DAT_Id { get; set; }
        public int DataAlaramId { get; set; }
        public string DataAlarm_Name { get; set; }
        public string UserName { get; set; }
        public int AST_ID { get; set; }
        public Nullable<int> AS_Id { get; set; }
        public string AS_Title { get; set; }
        public string Description { get; set; }
        public Nullable<int> AlarmPriority_ID { get; set; }
        public string AlarmPriority_Title { get; set; }
        public Nullable<int> State_ID { get; set; }
        public string State_Title { get; set; }
        public Nullable<double> Value { get; set; }
        public Nullable<double> UpperValue { get; set; }
        public Nullable<double> LowerValue { get; set; }
        public Nullable<double> Current_Value { get; set; }
        public Nullable<System.DateTime> Reading_Time { get; set; }
        public Nullable<System.DateTime> ActionStartDate { get; set; }
        public Nullable<System.DateTime> ActionEndDate { get; set; }
        public Nullable<int> isActive { get; set; }

    }
}
