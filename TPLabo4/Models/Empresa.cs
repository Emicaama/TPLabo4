using System.ComponentModel.DataAnnotations;

namespace TPLabo4.Models
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }
        public string empresaFotoUrl { get; set; }
        public string nombreEmpresa { get; set; }
        public string descripcion { get; set; }

        //relaciones
        public List<Juego> Juegos { get; set; }
    }
}
