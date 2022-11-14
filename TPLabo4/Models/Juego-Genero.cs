namespace TPLabo4.Models
{
    public class Juego_Genero
    {
        public int juegoId { get; set; }
        public Juego juego { get; set; }
        public int generoId { get; set; }
        public Genero genero { get; set; }
    }
}
