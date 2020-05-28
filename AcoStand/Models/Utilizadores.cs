using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AcoStand.Models {
    /// <summary>
    /// Classe que representa um utilizador do sistema
    /// </summary>
    public class Utilizadores {

        public Utilizadores() {
            ListaArtigos = new HashSet<Artigos>();
            ListaFavoritos = new HashSet<Favoritos>();
            }
        /// <summary>
        /// Chave primaria do utilizador
        /// </summary>
        [Key]
        public int IdUtilizador { get; set; }

        [Required]
        public string Nome { get; set; }

        /// <summary>
        /// Username do utilizador
        /// </summary>
        public string Username { get; set; }

        [Required]
        public string Localidade { get; set; }

        [Required]
        //[StringLength(9)] - M ou F?
        public string Sexo { get; set; }

        [Required]
        public DateTime DataNasc { get; set; }

        /// <summary>
        /// Lista de artigos de um utilizador
        /// </summary>
        public virtual ICollection<Artigos> ListaArtigos { get; set; }

        /// <summary>
        /// Lista de Favoritos de um Utilizador
        /// </summary>
        public virtual ICollection<Favoritos> ListaFavoritos { get; set; } 



        }
    }
