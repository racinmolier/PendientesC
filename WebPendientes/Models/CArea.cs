using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebPendientes.Models
{
    public class CArea
    {
        public byte ID { get; set; }
        public string NombreArea { get; set; }
        [Required]
        public string ApellidoPaternoResponsable { get; set; }
        [Required]
        public string ApellidoMaternoResponsable { get; set; }
        [Required]
        public string NombreResponsable { get; set; }
        [Required]
        public DateTime FechaModificacion { get; set; }
   
    }
}