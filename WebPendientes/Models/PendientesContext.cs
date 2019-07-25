using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebPendientes.Models
{
    public class PendientesContext :DbContext
    {
        public DbSet<CArea> Areas { get; set; }
        public DbSet<CUnidad>  Unidades{ get; set; }
        public DbSet<CProceso> Procesos { get; set; }
        public DbSet<CPendiente> Pendientes { get; set; }

    }
}