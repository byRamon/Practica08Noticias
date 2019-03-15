using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica08Noticias.Models
{
    public class Categorias
    {
        public int CategoriasID { get; set; }
        [Required(ErrorMessage ="Se debe ingresar la Categoria")]
        public string Nombre { get; set; }
        public virtual ICollection<Noticias> Noticias { get; set; }
    }
}
