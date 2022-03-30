using System.ComponentModel.DataAnnotations;

namespace PruebaFinal.Models
{
    public class Pais
    {
        [Key]
        public int Id_Pais { get; set; } 
        public string Nombre_Pais { get; set; }    
        public virtual ICollection<Pais> Paises { get; set; } 

    }
}
