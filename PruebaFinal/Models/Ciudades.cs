namespace PruebaFinal.Models
{
    public class Ciudades
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Pais? Pais { get; set; }
        public int PaisId { get; set; }
    }
}
