using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaFinal.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoIdentidad { get; set; }
        public Pais? Pais { get; set; }
        public int PaisId  { get; set; }
        public Ciudades? ciudades { get; set; }
        public int? CiudadesId { get; set; }
    }
}
