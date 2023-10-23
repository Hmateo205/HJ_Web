using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HJ_Web.Models;

namespace HJ_Web.Data
{
    public class HJ_WebContext : DbContext
    {
        public HJ_WebContext (DbContextOptions<HJ_WebContext> options)
            : base(options)
        {
        }

        public DbSet<HJ_Web.Models.Burger> Burger { get; set; } = default!;
    }
}
