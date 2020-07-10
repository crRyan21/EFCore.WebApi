using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class PacienteContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Doutor> Doutores { get; set; }
        public DbSet<DoutorPaciente> DoutorPacientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=sa132;Persist Security Info=True;User ID=sa;Initial Catalog=Hospital;Data Source=LAB08DESK115429\\SQLEXPRESS");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoutorPaciente>(entity => {
                entity.HasKey(e => new { e.DoutorId, e.PacienteId });
            });
        }
    }
}
