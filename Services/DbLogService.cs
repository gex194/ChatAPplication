using ChatApplication.Context;
using ChatApplication.Models;
using System.Collections.Generic;
using System.Linq;

namespace ChatApplication.Services
{
    public class DbLogService
    {

        public static void LogData(string name, string message, string time)
        {
            using (var context = new ChatContext())
            {
                var model = new LogModel()
                {
                    UserName = name,
                    UserMessage = message,
                    Time = time
                };

                context.Logs.Add(model);
                context.SaveChanges();
            }

        }

        public static List<LogModel> GetLogData()
        {
            List<LogModel> logs = new List<LogModel>();

            using (var context = new ChatContext())
            {
                logs.AddRange(context.Logs);
            }

            return logs;
        }

        public static void ResetLog ()
        {
            using ( var context = new ChatContext())
            {
                context.Logs.RemoveRange(context.Logs);
                context.SaveChanges();
            }
        }
    }
}