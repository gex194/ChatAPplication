using ChatApplication.Models;
using System.Collections.Generic;

namespace ChatApplication.ViewModels
{
    public class ChatViewModel
    {
        public string UserName { get; set; }

        public List<LogModel> ChatLogs { get; set; }
    }
}