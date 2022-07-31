using System.ComponentModel.DataAnnotations;

namespace WebDBG1.Areas.Identity
{
    public class Persona
    {


        [Key]

        public int ID { get; set; }

        [MaxLength(40)]

        public string? Nombre { get; set; }

        [MaxLength(40)]

        public string? Direccion { get; set; }

        [MaxLength(40)]
        [Display(Name = "Dirección")]

        public string? CiudadID { get; set; }

        [MaxLength(40)]

        public string? Telefono { get; set; }

        [MaxLength(40)]


        public string? Email { get; set; }

        [Display(Name = "Fecha Nacimiento")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy /MM/dd hh:mm}", ApplyFormatInEditMode = false)]

        public DateTime Fecha_Nacimiento { get; set; }

        public int MyProperty { get; set; }

    }
}
