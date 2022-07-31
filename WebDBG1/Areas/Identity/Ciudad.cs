using System.ComponentModel.DataAnnotations;

namespace WebDBG1.Areas.Identity
{
    public class Ciudad
    {
        public int ID { get; set; }

        [MaxLength(40)]

        public string? Nombre { get; set; }

    }
}
