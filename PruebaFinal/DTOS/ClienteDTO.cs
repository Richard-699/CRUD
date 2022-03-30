using PruebaFinal.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaFinal.DTOS
{
    public class ClienteDTO
    {
        [Key]
        public int Id_Cliente { get; set; }
        [Display(Name = "Nombre")]
        [Required (ErrorMessage="El nombre es un campo obligatorio.")]
        [StringLength (50)]
        public string Nombre { get; set; }
        [Display(Name = "Tipo_Identidad")]
        [Required(ErrorMessage= "El tipo de identidad es requerido.")]
        [StringLength(50)]
        public string Tipo_Identidad { get; set; }
        [Display(Name = "Id_Pais")]
        [Required(ErrorMessage = "Debe seleccionar un país obligatoriamente.")]
        [ForeignKey("Pais")]
        public int Id_Pais { get; set; }
        public virtual Pais Pais { get; set; }
    }
}
