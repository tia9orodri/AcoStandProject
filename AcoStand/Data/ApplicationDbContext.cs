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

            //######UTILIZADORES######
            builder.Entity<IdentityUser>().HasData(
                    new IdentityUser { }
                );


            // insert DB seed
            builder.Entity<Utilizadores>().HasData(
               new Utilizadores { IdUtilizador = 1, Username = "Fred", Nome = "Fred", Localidade = "Golegã", Sexo = "Masculino", DataNasc = new DateTime(1998, 6, 2) },
               new Utilizadores { IdUtilizador = 2, Username = "Tiago", Nome = "Tiago", Localidade = "Torres Novas", Sexo = "Masculino", DataNasc = new DateTime(1996, 6, 28) }
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
