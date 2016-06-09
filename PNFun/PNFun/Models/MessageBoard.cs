using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PNFun.Models
{
    public class MessageBoard
    {
        public int ID { get; set; }
        [Required]
        [MaxLength (64)]
        public string Title { get; set; }
        [DataType(DataType.MultilineText)]
        public Message OriginalMessage { get; set; }
        public string UserName { get; set; }
        public int UserID { get; set; }
    }

    public class Message
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(64)]
        public string Title { get; set; }
        [DataType(DataType.MultilineText)]
        public string MessageText { get; set; }
        public string UserName { get; set; }
        public int UserID { get; set; }

        public List<Reply> replies { get; set; }
    }

    public class Reply
    {
        public int ID { get; set; }
        public string replyText { get; set; }
        public List<Reply> replies { get; set; }
        public string UserName { get; set; }
        public int UserID { get; set; }
    }
}