using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestauranteEtec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteEtec.Data
{
    public class Contexto : IdentityDbContext<ApplicationUser>
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Relato> Relatos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Identity
            modelBuilder.Entity<ApplicationUser>(entity =>
            { 
                entity.ToTable(name: "User");
            });
            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
            #endregion

            #region Cargo Seed
            modelBuilder.Entity<Cargo>().HasData(
                new Cargo()
                {
                    Id = 1,
                    Nome = "CEO, Cofundador"
                },
                new Cargo()
                {
                    Id = 2,
                    Nome = "Cozinheiro Chefe"
                },
                new Cargo()
                {
                    Id = 3,
                    Nome = "Chefe de Cozinha"
                }
            );
            #endregion

            #region Funcionario Seed
            modelBuilder.Entity<Funcionario>().HasData(
                new Funcionario()
                {
                    Id = 1,
                    Nome = "John Gustavo",
                    Texto = "I am ambitious workaholic, but apart from that, pretty simple person.",
                    CargoId = 1,
                    ExibirHome = true,
                    OrdemExibicao = 1,
                    Foto = "images/funcionarios/chef-4.jpg"
                },
                new Funcionario()
                {
                    Id = 2,
                    Nome = "Michelle Fraulen",
                    Texto = "I am ambitious workaholic, but apart from that, pretty simple person.",
                    CargoId = 2,
                    ExibirHome = true,
                    OrdemExibicao = 2,
                    Foto = "images/funcionarios/chef-2.jpg"
                },
                new Funcionario()
                {
                    Id = 3,
                    Nome = "Alfred Smith",
                    Texto = "I am ambitious workaholic, but apart from that, pretty simple person.",
                    CargoId = 3,
                    ExibirHome = true,
                    OrdemExibicao = 3,
                    Foto = "images/funcionarios/chef-3.jpg"
                },
                new Funcionario()
                {
                    Id = 4,
                    Nome = "Antonio Santibanez",
                    Texto = "I am ambitious workaholic, but apart from that, pretty simple person.",
                    CargoId = 3,
                    ExibirHome = true,
                    OrdemExibicao = 4,
                    Foto = "images/funcionarios/chef-1.jpg"
                }
            );
            #endregion

            #region Categoria Seed
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria()
                {
                    Id = 1,
                    Nome = "Entradas"
                },
                new Categoria()
                {
                    Id = 2,
                    Nome = "Prato Principal"
                },
                new Categoria()
                {
                    Id = 3,
                    Nome = "Sobremesa"
                },
                new Categoria()
                {
                    Id = 4,
                    Nome = "Bebidas"
                }
            );
            #endregion
        }

    }
}
