using PruebaFinal.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaFinal.DTOS
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        [Required (ErrorMessage="El nombre es un campo obligatorio.")]
        [StringLength (50)]
        public string Nombre { get; set; }
        [Display(Name = "TipoIdentidad")]
        [Required(ErrorMessage= "El tipo de identidad es requerido.")]
        [StringLength(50)]
        public string TipoIdentidad { get; set; }
        public int IdPais { get; set; }
        public List<Pais> Paises { get; set; }
        public List<Cliente> clientes { get; set; }   
    }
}
