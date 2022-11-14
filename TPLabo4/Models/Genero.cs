using System.ComponentModel.DataAnnotations;

namespace TPLabo4.Models
{
    public class Genero
    {
        [Key]
        public int Id { get; set; }
        public string nombreGenero { get; set; }
        public string descripcion { get; set; }

        //Relaciones
        public List<Juego_Genero> Juegos_Generos { get; set; }
    }
}
