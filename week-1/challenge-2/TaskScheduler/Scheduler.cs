using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using System.Threading;

namespace TaskScheduler
{
    public class Scheduler
    {
        private static IDailyTask _dailyWork = new DailyTask();

        public static void InitScheduler() {
            _dailyWork.AddTask("start the coffee, set out 4 cups",  ToDateTime("2019/12/13 8:00:00"), ToDateTime("2019/12/13 8:24:00"));            
            _dailyWork.AddTask("pour two cups", ToDateTime("2019/12/13 8:25:00"), ToDateTime("2019/12/13 8:30:00"));
            _dailyWork.AddTask("light the candles", ToDateTime("2019/12/13 8:30:00"), ToDateTime("2019/12/13 8:35:00"));
            _dailyWork.AddTask("deliver the coffee to Mom and Dad", ToDateTime("2019/12/13 8:35:00"), ToDateTime("2019/12/13 8:38:00"));
            _dailyWork.AddTask("return to kitchen, fill two more cupss", ToDateTime("2019/12/13 8:39"), ToDateTime("2019/12/13 8:40"));
            _dailyWork.AddTask("relight the candles", ToDateTime("2019/12/13 8:40"), ToDateTime("2019/12/13 8:44"));
            _dailyWork.AddTask("deliver the coffee to Sister and Brothers", ToDateTime("2019/12/13 8:45"), ToDateTime("2019/12/13 8:49"));
            _dailyWork.AddTask("return to kitchen, take a break!", ToDateTime("2019/12/13 8:49:00"), ToDateTime("2019/12/13 :00"));            
        }


        public static void RunTime()
        {
            var tasks = _dailyWork.EventService();

            foreach (var d in tasks)
            {
                Thread.Sleep(200);
                Notify(d);
            }
        }

        public static void Notify(Event e)
        {
            //-POST Mode
            const string accountSid = "AC1fde856585479c11702d299c1a6800a1";
            const string authToken = "your_auth_token";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: e.ToString(),
                from: new Twilio.Types.PhoneNumber("+15854926296"),
                to: new Twilio.Types.PhoneNumber("+15854926296")
            );

            Console.WriteLine(message.Sid);
        }

        private static DateTime ToDateTime(string v)
        {
            DateTime r = DateTime.MinValue;
            DateTime.TryParse(v, out r);
            return r;
        }
    }
}
