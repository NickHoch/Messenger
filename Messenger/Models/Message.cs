using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Messenger.Models
{
    public class Message
    {
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string Content { get; set; }
    }
}