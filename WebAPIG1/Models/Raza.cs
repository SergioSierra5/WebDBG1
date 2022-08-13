using System.ComponentModel.DataAnnotations;

namespace WebAPIG1.Models
{
    public class Raza
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(40)]
        public string Nombre { get; set; }


    }
}
