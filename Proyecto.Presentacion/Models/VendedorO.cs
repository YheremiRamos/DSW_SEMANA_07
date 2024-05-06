using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.Presentacion.Models
{
    public class VendedorO
    {


        [DisplayName("CODIGO")]
        public int ide_ven { get; set; }

        [DisplayName("NOMBRES")]
        [Required(ErrorMessage = "NOMBRE DEL VENDEDOR")]
        public string nom_ven { get; set; }

 
        [DisplayName("APELLIDOS")]
        [Required(ErrorMessage = "APELLIDOS DEL VENDEDOR")]
        public string ape_ven { get; set; }

        [DisplayName("SUELDO")]
        [Required(ErrorMessage = "SUELDO DEL VENDEDOR")]
        public double sue_ven { get; set; }

        [DisplayName("FECHA_DE_INGRESO")]
        [Required(ErrorMessage = "FECHA DE INGRESO")]
        public DateTime fec_ing { get; set; }


        [DisplayName("DISTRITO")]
        [Required(ErrorMessage = "DISTRITO DEL VENDEDOR")]
        public int ide_dis { get; set; }
    }
}
