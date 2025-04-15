// Codigo do Arquivo 

using apiEscola.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIEscola.Data
{
    public class APIEscolaContext : IdentityDbContext //Herança do IdentityDbContext para autenticação
    {
        public APIEscolaContext(DbContextOptions<APIEscolaContext> options) : base(options)
        {
        }
        //Propriedade DbSet para cada tabela
        public DbSet<Aluno> Alunos { get; set; } //Tabela Alunos
        public DbSet<Curso> Cursos { get; set; } //Tabela Cursos
        public DbSet<Turma> Turmas { get; set; } //Tabela Turmas
        public DbSet<Matricula> Matriculas { get; set; }

        // Sobrecarga do método OnModelCreating para configurar o modelo a partir da IdentityDbContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Chama o método OnModelCreating da classe base
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Aluno>().ToTable("Alunos"); //Configura o nome da tabela Alunos no banco de dados
            modelBuilder.Entity<Curso>().ToTable("Cursos"); //Configura o nome da tabela Cursos no banco de dados
            modelBuilder.Entity<Turma>().ToTable("Turmas"); //Configura o nome da tabela Turmas no banco de dados
            modelBuilder.Entity<Matricula>().ToTable("Matriculas"); //Configura o nome da tabela turmas no banco de dados

            //Configurar a ciração de tabelas adicionais aqui 
        }
    }
}
