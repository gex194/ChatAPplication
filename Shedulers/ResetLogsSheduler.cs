using ChatApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Web;

namespace ChatApplication.Shedulers
{
    public class ResetLogsSheduler
    {
        static Timer timer;
        public static void schedule_Timer()
        {
            Console.WriteLine("### [ClearLog]:Timer Started ###");

            DateTime nowTime = DateTime.Now;
            DateTime scheduledTime = new DateTime(nowTime.Year, nowTime.Month, nowTime.Day, 9, 0, 0, 0);
            if (nowTime > scheduledTime)
            {
                scheduledTime = scheduledTime.AddDays(1);
            }

            double tickTime = (double)(scheduledTime - DateTime.Now).TotalMilliseconds;
            timer = new Timer(tickTime);
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Start();
        }

        public static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("### [ClearLog]:Timer Stopped ### \n");
            timer.Stop();
            Console.WriteLine("### Clearing ChatLogs... ### \n\n");
            DbLogService.ResetLog();
            Console.WriteLine("### [ClearLog]:Task Finished ### \n\n");
            schedule_Timer();
        }
    }
}