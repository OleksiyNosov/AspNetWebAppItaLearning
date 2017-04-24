using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp
{
    public class MvcDbContext : DbContext
    {
        public MvcDbContext() : base("dbconnection")
        {
            
        }

        public DbSet<PostData> Users { get; set; }
    }
}