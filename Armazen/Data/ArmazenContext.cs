using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Armazen.Models;

namespace Armazen.Data
{
    public class ArmazenContext : DbContext
    {
        public ArmazenContext (DbContextOptions<ArmazenContext> options)
            : base(options)
        {
        }

        public DbSet<Armazen.Models.Deposito> Deposito { get; set; }
    }
}
