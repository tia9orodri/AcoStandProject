using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AcoStand.Models {
    public class Categorias {

        /// <summary>
        /// Chave Primaria da Categoria
        /// </summary>
        [Key]
        public int IdCategoria { get; set; }

       
        [Required]
        public string Designacao { get; set; }
        }


   // public virtual ICollection<Artigo> ListaArtigos { get; set; }
    }
