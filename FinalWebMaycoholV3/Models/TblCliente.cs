using System;
using System.Collections.Generic;

namespace FinalWebMaycoholV3.Models
{
    public partial class TblCliente
    {
        public TblCliente()
        {
            TblVenta = new HashSet<TblVentum>();
        }

        public string Dni { get; set; } = null!;
        public string CliApellidoPaterno { get; set; } = null!;
        public string? CliApellidoMaterno { get; set; }
        public string CliNombres { get; set; } = null!;
        public string CliSexo { get; set; } = null!;
        public DateTime CliFechaNacimiento { get; set; }
        public string? CliDireccion { get; set; }
        public string? CliTelefono { get; set; }
        public string? CliEmail { get; set; }

        public virtual ICollection<TblVentum> TblVenta { get; set; }
    }
}
