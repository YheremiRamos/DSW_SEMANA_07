﻿using System.ComponentModel;
namespace Proyecto.Presentacion.Models
{
    public class Vendedor
    {
        [DisplayName("CODIGO")]
        public int ide_ven { get; set; }

        [DisplayName("VENDEDOR")]
        public string ? nom_ven { get; set; }

        [DisplayName("SUELDO")]
        public double sue_ven { get; set; }
        
        [DisplayName("FECHA_DE_INGRESO")]
        public DateTime fec_ing { get; set; }

        [DisplayName("DISTRITO")]
        public string ? nom_dis { get; set; }


    }
}