using System;
using System.Collections.Generic;
using System.Text;

namespace TaskScheduler
{
    public interface IDailyTask
    {
        //DailyTask(string today = "20191213");

        bool AddTask(string eventName, DateTime startTime, DateTime endTime);
        List<Event> EventService();
        bool DeleteTask(string eventName, DateTime startTime, DateTime endTim);
      
    }
}
