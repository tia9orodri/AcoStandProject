using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AcoStand.Models;
using Microsoft.AspNetCore.Identity;

namespace AcoStand.Data {





    public class ApplicationDbContext : IdentityDbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
            }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id="A",
                    Name="Administrator",
                    NormalizedName="Administrator".ToUpper()
                },

                new IdentityRole
                {
                    Id = "U",
                    Name = "User",
                    NormalizedName = "User".ToUpper()
                }
                );


        }



        public virtual DbSet<Artigos> Artigos { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Favoritos> Favoritos { get; set; }
        public virtual DbSet<Recursos> Recursos { get; set; }
        public virtual DbSet<Utilizadores> Utilizadores { get; set; }
        }


    }
