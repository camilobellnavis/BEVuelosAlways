using BEVuelosAlways.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEVuelosAlways
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Vuelo> Vuelo { get; set; }
        public DbSet<Login> Login { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
    }
}
