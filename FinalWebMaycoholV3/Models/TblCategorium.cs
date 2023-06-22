using System;
using System.Collections.Generic;

namespace FinalWebMaycoholV3.Models
{
    public partial class TblCategorium
    {
        public TblCategorium()
        {
            TblProductos = new HashSet<TblProducto>();
        }

        public string Idcategoria { get; set; } = null!;
        public string CatNombre { get; set; } = null!;

        public virtual ICollection<TblProducto> TblProductos { get; set; }
    }
}
