using IBMYoung.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBMYoung.Infrastructure
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
            
        }

        public DbSet<Usuario> usuario { get; set; }

        public DbSet<Tarefa> tarefa { get; set; }

        public DbSet<Instituicao> instituicao { get; set; }

        public DbSet<Questao> questao { get; set; }

        public DbSet<Alternativa> alternativa { get; set; }

        public DbSet<Boletim> boletim { get; set; }

        public DbSet<Topico> topico { get; set; }

        public DbSet<Replica> replica { get; set; }

        public DbSet<Funcionario> funcionario { get; set; }

        public DbSet<Aprendiz> aprendiz { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
