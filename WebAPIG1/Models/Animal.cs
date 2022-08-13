using System.ComponentModel.DataAnnotations;

namespace WebAPIG1.Models
{
    public class Animal
    {
        [Key]
        public int ID{ get; set; }

        [MaxLength(40)]
        public string Nombre { get; set; }

        

        public string RazaID { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int TipoAnimalID { get; set; }

        public TipoAnimal TipoAnimal { get; set; }

        public Raza Raza { get; set; }


    }
}
