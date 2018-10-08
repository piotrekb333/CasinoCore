using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Casino.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Email { get; set; }
    }
}
