using DevSteamAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DevSteamAPI.Data
{
    public class DevSteamAPIContext : IdentityDbContext
    {
        //Metodo construtor
        public DevSteamAPIContext(DbContextOptions<DevSteamAPIContext> options)
            : base(options)
        { }

        //Definir as tabelas do banco de dados
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Jogo>().ToTable("Jogos");
            modelBuilder.Entity<Categoria>().ToTable("Categoria");
        }
        public DbSet<Carrinho> Carrinho { get; set; } = default!;
        public DbSet<ItemCarrinho> ItemCarrinho { get; set; } = default!;
    }
}
