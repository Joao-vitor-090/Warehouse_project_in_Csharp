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

        public DbSet<Deposito> Deposito { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<RegistroDeVenda> RegistroDeVendas { get; set; }
        
    }
}
