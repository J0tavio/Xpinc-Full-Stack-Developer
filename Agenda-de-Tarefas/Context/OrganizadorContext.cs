using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agenda_de_Tarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda_de_Tarefas.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> TarefasDbSet { get; set; }
    }
}