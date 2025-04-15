// Codigo do Arquivo 
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

        // Sobrecarga do método OnModelCreating para configurar o modelo a partir da IdentityDbContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Chama o método OnModelCreating da classe base
            base.OnModelCreating(modelBuilder);
            //Configurar a ciração de tabelas adicionais aqui 
        }
    }
}
