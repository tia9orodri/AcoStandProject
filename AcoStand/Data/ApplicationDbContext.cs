using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AcoStand.Models;
using Microsoft.AspNetCore.Identity;

namespace AcoStand.Data {

    /// <summary>
    /// Classe que representa a Base de Dados
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext {


        /// <summary>
        /// Constutor da classe
        /// serve para ligar esta classe a BD
        /// </summary>
        /// <param name="db"></param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> db) : base(db) { }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);


            //Adição de Roles
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "A", Name = "Administrator", NormalizedName = "Administrator".ToUpper() },
                new IdentityRole { Id = "U", Name = "User", NormalizedName = "User".ToUpper() });

            //user


            // insert DB seed
            builder.Entity<Utilizadores>().HasData(
               new Utilizadores { IdUtilizador = 1, Username = "Fred", Nome = "Fred", Localidade = "Golegã", Sexo = "Masculino", DataNasc = new DateTime(1998, 6, 2) },
               new Utilizadores { IdUtilizador = 2, Username = "Tiago", Nome = "Tiago", Localidade = "Torres Novas", Sexo = "Masculino", DataNasc = new DateTime(1996, 6, 28) }
            );


            //Adicionar Artigos
            builder.Entity<Artigos>().HasData(
                new Artigos { IdArtigo = 1, Titulo = "Audi A4", Preco = "25,000", Descricao = "Carro como novo, inspeção em dia", Contacto = "a@aa.aa", Validado = true, DonoFK = 1, CategoriaFK = 1 },
                new Artigos { IdArtigo = 2, Titulo = "BMW Q5", Preco = "30,000", Descricao = "Carro como novo, inspeção em dia", Contacto = "a@aa.aa", Validado = true, DonoFK = 1, CategoriaFK = 1 },
                new Artigos { IdArtigo = 3, Titulo = "Opel xx", Preco = "10,000", Descricao = "Carro como novo, inspeção em dia", Contacto = "a@aa.aa", Validado = true, DonoFK = 1, CategoriaFK = 1 },
                new Artigos { IdArtigo = 4, Titulo = "Opel yy", Preco = "13,000", Descricao = "Carro como novo, inspeção em dia", Contacto = "a@aa.aa", Validado = true, DonoFK = 1, CategoriaFK = 1 },
                new Artigos { IdArtigo = 5, Titulo = "Ford", Preco = "8,000", Descricao = "Carro como novo, inspeção em dia", Contacto = "a@aa.aa", Validado = true, DonoFK = 1, CategoriaFK = 1 },
                new Artigos { IdArtigo = 6, Titulo = "Nissan x", Preco = "27,000", Descricao = "Carro como novo, inspeção em dia", Contacto = "a@aa.aa", Validado = true, DonoFK = 1, CategoriaFK = 1 }
                );

            //Adicionar Categorias
            builder.Entity<Categorias>().HasData(
                new Categorias { IdCategoria = 1, Designacao = "Carros" },
                new Categorias { IdCategoria = 2, Designacao = "Peças" },
                new Categorias { IdCategoria = 3, Designacao = "Pneus" }
                );

            //Adicionar Imagens
            builder.Entity<Recursos>().HasData(
                new Recursos { IdRecursos = 1, Designacao = "AudiA4", Tipo = "imagem", ArtigoFK = 1 },
                new Recursos { IdRecursos = 2, Designacao = "BMWQ5", Tipo = "imagem", ArtigoFK = 2 },
                new Recursos { IdRecursos = 3, Designacao = "OpelXX", Tipo = "imagem", ArtigoFK = 3 },
                new Recursos { IdRecursos = 4, Designacao = "OpelYY", Tipo = "imagem", ArtigoFK = 4 },
                new Recursos { IdRecursos = 5, Designacao = "Ford", Tipo = "imagem", ArtigoFK = 5 },
                new Recursos { IdRecursos = 6, Designacao = "Nissan", Tipo = "imagem", ArtigoFK = 6 }
                );

        }

        //adicionar as tableas a BD
        public virtual DbSet<Artigos> Artigos { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Favoritos> Favoritos { get; set; }
        public virtual DbSet<Recursos> Recursos { get; set; }
        public virtual DbSet<Utilizadores> Utilizadores { get; set; }

    }


}
