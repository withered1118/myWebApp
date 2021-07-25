using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myWebApp.Models;

    public class myWebContext : DbContext
    {
        public myWebContext (DbContextOptions<myWebContext> options)
            : base(options)
        {
        }

        public DbSet<myWebApp.Models.Article> Article { get; set; }
    }
