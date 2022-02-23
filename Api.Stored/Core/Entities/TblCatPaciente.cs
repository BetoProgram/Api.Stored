using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Stored.Core.Entities
{
    [Table(name: "TblCatPaciente", Schema = "CitasMedicas")]
    public class TblCatPaciente
    {
        public int FiIdPaciente { get; set; }
        public string FcNombres { get; set; }
        public string FcApellidos { get; set; }
        public string FcDireccion { get; set; }
        public string FcTelefono { get; set; }
        public string FcSexo { get; set; }
        public string FcEmail { get; set; }
        public DateTime? FdFechaNacimiento { get; set; }
        public DateTime? FcFechaRegistro { get; set; }
        public DateTime? FdFechaModificacion { get; set; }
        public string FcUsuarioRegistro { get; set; }
        public string FcUsuarioModificacion { get; set; }
        public bool? FlActivo { get; set; }
        public virtual ICollection<TblDatCita> TblDatCita { get; set; }
    }
}
