﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Casino.DtoModels
{
    public class NewsletterDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
