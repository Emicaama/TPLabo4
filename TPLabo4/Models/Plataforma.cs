using System.ComponentModel.DataAnnotations;

namespace TPLabo4.Models
{
    public class Plataforma
    {
        [Key]
        public int Id { get; set; }
        public string plataformaFotoUrl { get; set; }
        public string nombrePlataforma { get; set; }

    }
}
