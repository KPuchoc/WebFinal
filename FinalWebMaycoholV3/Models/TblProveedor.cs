using System;
using System.Collections.Generic;

namespace FinalWebMaycoholV3.Models
{
    public partial class TblProveedor
    {
        public TblProveedor()
        {
            TblProductos = new HashSet<TblProducto>();
        }

        public string Ruc { get; set; } = null!;
        public string ProvNombre { get; set; } = null!;
        public string? ProvDireccion { get; set; }
        public string? ProvTelefono { get; set; }
        public string? ProvEmail { get; set; }

        public virtual ICollection<TblProducto> TblProductos { get; set; }
    }
}
