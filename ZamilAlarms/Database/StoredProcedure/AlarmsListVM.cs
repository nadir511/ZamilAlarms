using System;

namespace ZamilAlarms.Database.StoredProcedure
{
    public class AlarmsListVM
    {
        public string DataAlarmName { get; set; }
        public string AalarmStatus { get; set; }
        public string AlarmPriority { get; set; }
        public string AlarmState { get; set; }
        public double? SetPoint { get; set; }
        public double? TagValue { get; set; }
        public DateTime? ReadingTime { get; set; }
        public int? isActive { get; set; }
    }
}
