using System;
using System.Collections.Generic;

namespace TaskScheduler
{
    class DailyTask : IDailyTask
    {
        private List<Event> _tasks = new List<Event>();
        private DateTime _today = DateTime.MinValue;    
        
       
        public DailyTask(string today = "2019/12/13")
        {
            var tz = TimeZoneInfo.GetSystemTimeZones();
            TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");

            DateTime t = DateTime.MinValue;
            _today = (DateTime.TryParse(today, out t)) ? t : t;

        }

        public bool AddTask(string eventName, DateTime startTime, DateTime endTime) {
            _tasks.Add(new Event(eventName, startTime, endTime));
            return true;
        }

        public List<Event> EventService()
        {
            return _tasks;
        }
      
    
        public bool DeleteTask(string eventName, DateTime startTime, DateTime endTim)
        {
            _tasks.Remove(new Event(eventName, startTime, endTim));
            return true;
        }

      
    }
}
