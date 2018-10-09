using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Casino.Entities
{
    public class Newsletter
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
