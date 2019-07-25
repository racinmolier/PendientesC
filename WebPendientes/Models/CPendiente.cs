using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPendientes.Models
{
    public class CPendiente
    {
        public int Id { get; set; }
        public CArea carea { get; set; }
        public CProceso cproceso { get; set; }
        public CUnidad cunidad { get; set; }
    }
}