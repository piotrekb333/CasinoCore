using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Casino.DtoModels
{
    public class ArticleDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
