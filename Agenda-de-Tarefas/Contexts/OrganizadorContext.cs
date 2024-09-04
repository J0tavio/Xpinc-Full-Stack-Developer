using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agenda_de_Tarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda_de_Tarefas.Contexts
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> TarefasDbSet { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Tarefa>()
        //    .Property(t => t.Status)
        //    .HasConversion(
        //        v => v.ToString(), // Converte o enum para string ao salvar
        //        v => Enum.Parse<EnumStatusTarefa>(v) // Converte a string para enum ao carregar
        //        );
        // }
    }
}