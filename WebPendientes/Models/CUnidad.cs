using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebPendientes.Models
{
    public class CUnidad
    {
        public int Id { get; set; }
        [Required]
        [StringLength(3)]
        public string Siglas { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int Telefono { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime FechaModificacion { get; set; }

    }
}