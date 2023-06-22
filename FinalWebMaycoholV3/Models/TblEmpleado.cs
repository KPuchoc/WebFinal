using System;
using System.Collections.Generic;

namespace FinalWebMaycoholV3.Models
{
    public partial class TblEmpleado
    {
        public TblEmpleado()
        {
            TblVenta = new HashSet<TblVentum>();
        }

        public int Idempleado { get; set; }
        public string EmpNumSegSocial { get; set; } = null!;
        public string EmpApellidoPaterno { get; set; } = null!;
        public string? EmpApellidoMaterno { get; set; }
        public string EmpNombres { get; set; } = null!;
        public decimal EmpSueldo { get; set; }

        public virtual ICollection<TblVentum> TblVenta { get; set; }
    }
}
