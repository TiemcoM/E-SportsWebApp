using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using E_Sports_WebApp.Models;

namespace E_Sports_WebApp.Data
{
    public class E_Sports_WebAppContext : DbContext
    {
        public E_Sports_WebAppContext (DbContextOptions<E_Sports_WebAppContext> options)
            : base(options)
        {
        }

        public DbSet<E_Sports_WebApp.Models.Team> Team { get; set; } = default!;
        public DbSet<E_Sports_WebApp.Models.Player> Player { get; set; } = default!;
    }
}
