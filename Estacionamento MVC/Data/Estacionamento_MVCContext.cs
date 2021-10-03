using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Estacionamento_MVC.Models;

namespace Estacionamento_MVC.Data
{
    public class Estacionamento_MVCContext : DbContext
    {
        public Estacionamento_MVCContext (DbContextOptions<Estacionamento_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Estacionamento_MVC.Models.Propietario> Propietario { get; set; }
    }
}
