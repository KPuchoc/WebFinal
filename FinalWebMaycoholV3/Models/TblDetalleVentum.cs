using System;
using System.Collections.Generic;

namespace FinalWebMaycoholV3.Models
{
    public partial class TblDetalleVentum
    {
        public string? Idventa { get; set; }
        public string? Idproducto { get; set; }
        public int DvenCantidad { get; set; }

        public virtual TblProducto? IdproductoNavigation { get; set; }
        public virtual TblVentum? IdventaNavigation { get; set; }
    }
}
