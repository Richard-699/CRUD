using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaFinal.Models
{
    public class Cliente
    {
        [Key]
        public int Id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Tipo_Identidad { get; set; }
        [ForeignKey("Pais")]
        public int Id_Pais { get; set; }
    }
}
