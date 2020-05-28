using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcoStand.Models {
    public class Artigos {
        public Artigos() {
            ListaRecursos = new HashSet<Recursos>();
            ListaFavUtilizador = new HashSet<Favoritos>();
            }

        /// <summary>
        /// Chave Primária do Artigo
        /// </summary>
        [Key] 
        public int IdArtigo { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Preco { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public string Contacto { get; set; }

        /// <summary>
        /// Artigo será validado por um administrador da página
        /// </summary>
        public bool Validado { get; set; }

        /// <summary>
        /// Chave Forasteira que indica a que dono pertence este artigo
        /// </summary>
         [ForeignKey(nameof(Dono))]
        public int DonoFK { get; set; }
        public virtual Utilizadores Dono { get; set; }

        /// <summary>
        /// Chave Forasteira que indica a que categoria pertence o artigo
        /// </summary>
        [ForeignKey("Categoria")]
        public int CategoriaFK { get; set; }
        public virtual Categorias Categoria { get; set; }

        /// <summary>
        /// Lista de recursos de um artigo
        /// </summary>
        public virtual ICollection<Recursos> ListaRecursos { get; set; }

        /// <summary>
        /// Lista de favoritos entre User e artigo (M-N)????
        /// </summary>
        public virtual ICollection<Favoritos> ListaFavUtilizador { get; set; }

        }
   }
