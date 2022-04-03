using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaFinal.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoIdentidad { get; set; }
        public Pais Pais { get; set; }
        public int IdPais { get; set; }
    }
}
