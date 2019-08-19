using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatApplication.Models
{
    public class LogModel
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string UserMessage { get; set; }

        public string Time { get; set; }
    }
}