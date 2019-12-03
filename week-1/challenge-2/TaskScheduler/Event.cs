using System;
using System.Collections.Generic;
using System.Text;

namespace TaskScheduler
{
    public class Event : IEvent
    {
        string eventName { get; set; }

        DateTime startTime { get; set; }

        DateTime endTime { get; set; }

        public Event(string name, DateTime start, DateTime end)
        {
            eventName = name;
            startTime = start;
            endTime = end;
        }

        public override string ToString()
        {
            return "Lucy is timet to {this.eventName}";
        }
    }
}
