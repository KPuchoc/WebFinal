using System;
using System.Collections.Generic;

namespace FinalWebMaycoholV3.Models
{
    public partial class TblVentum
    {
        public string Idventa { get; set; } = null!;
        public DateTime VenFecha { get; set; }
        public string? Dni { get; set; }
        public int? Idempleado { get; set; }

        public virtual TblCliente? DniNavigation { get; set; }
        public virtual TblEmpleado? IdempleadoNavigation { get; set; }
    }
}
