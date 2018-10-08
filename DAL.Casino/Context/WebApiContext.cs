using Microsoft.EntityFrameworkCore;
using Models.Casino.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Casino.Context
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
