using System;
using System.Threading.Tasks;
using System.Timers;
using System.Web;
using Castle.Core.Logging;
using ChatApplication.Hubs;
using ChatApplication.Services;
using ChatApplication.Shedulers;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace ChatApplication.Hubs
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Login")
            });
            DbLogService.ResetLog(); // For testing purposes, comment it if you want to clear messages using timer
            ResetLogsSheduler.schedule_Timer();
        }
    }
}
