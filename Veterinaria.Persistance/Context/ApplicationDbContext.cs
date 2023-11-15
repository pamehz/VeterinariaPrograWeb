using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Veterinaria.Application.Contracts.Contexts;
using Veterinaria.Domain.Entities;

namespace Veterinaria.Persistence.Contexts
{
    public class VeterinariaDbContext : DbContext, IApplicationDbContext
    {
        public VeterinariaDbContext(DbContextOptions<VeterinariaDbContext> options)
            : base(options)
        {

        }

        public DbSet<Veterinario> Veterinarios { get; set; }

        public DbSet<Cita> Citas { get; set; }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}
