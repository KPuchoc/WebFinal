using System;
using System.Collections.Generic;

namespace FinalWebMaycoholV3.Models
{
    public partial class TblProducto
    {
        public string Idproducto { get; set; } = null!;
        public string ProNombre { get; set; } = null!;
        public decimal ProPrecioVenta { get; set; }
        public int ProStock { get; set; }
        public string? Ruc { get; set; }
        public string? Idcategoria { get; set; }

        public virtual TblCategorium? IdcategoriaNavigation { get; set; }
        public virtual TblProveedor? RucNavigation { get; set; }
    }
}
