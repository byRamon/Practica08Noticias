using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica08Noticias.Models
{
    public class Noticias
    {
        [Key]
        public int NoticiaID { get; set; }
        [Required(ErrorMessage = "Debe ingresar el titulo")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Debe ingresar el Contenido"), DataType(DataType.MultilineText)]
        public string Contenido { get; set; }
        public DateTime FechaPublicacion { get; set; }

        [ForeignKey("Categoria")]
        public int CategoriaID { get; set; }
        public virtual Categorias Categoria { get; set; }
    }
}
