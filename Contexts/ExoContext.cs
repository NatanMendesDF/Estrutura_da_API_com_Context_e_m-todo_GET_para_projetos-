using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }
        public ExoContext(DbContextOptions<ExoContext> options) : base (options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                // Essa String de conexão depende da SUA máquina.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;" + "Database=ExoApi;Trusted_Connection=True;");

                // Exemplo 1 de string da conexão:
                // User ID=sa;Password=admin;Server=Localhost;Database=ExoApi;-
                // + Trusted_Connection=False;
            }
        }

        public DbSet<Projeto> Projetos {get; set;}


    }


}