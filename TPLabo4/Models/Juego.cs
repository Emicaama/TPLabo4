using System.ComponentModel.DataAnnotations;

namespace TPLabo4.Models
{
    public class Juego
    {
        [Key]
        public int Id { get; set; }
        public string juegoFotoUrl { get; set; }
        public string nombreJuego { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public DateTime fechaPublicacion { get; set; }

        //Relaciones
        public List<Juego_Genero> Juegos_Generos { get; set; }
    }
}
