using Veterinaria.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Veterinaria.Application.Contracts.Contexts
{
    public interface IVeterinariaDbContext
    {
        DbSet<Veterinario> Veterinarios { get; set; }
        DbSet<Paciente> Pacientes { get; set; }
        DbSet<Cita> Citas { get; set; }

        void SaveChanges();
    }
}
