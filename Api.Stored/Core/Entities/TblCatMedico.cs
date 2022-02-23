using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Stored.Core.Entities
{
    [Table(name: "TblCatMedico", Schema = "CitasMedicas")]
    public class TblCatMedico
    {
        public short FiIdMedico { get; set; }
        public string FcNombres { get; set; }
        public string FcApellidos { get; set; }
        public string FcClaveCedula { get; set; }
        public string FcDireccion { get; set; }
        public string FcEmail { get; set; }
        public string FcTelefono1 { get; set; }
        public string FcTelefono2 { get; set; }
        public string FcSexo { get; set; }
        public DateTime? FdFechaRegistro { get; set; }
        public DateTime? FdFechaModificacion { get; set; }
        public string FcUsuarioRegistro { get; set; }
        public string FcUsuarioModificacion { get; set; }
        public bool? FlActivo { get; set; }

        public virtual ICollection<TblDatCita> TblDatCita { get; set; }
        public virtual ICollection<TblDatHorario> TblDatHorarios { get; set; }
        public virtual ICollection<TblIntMedicosEspecialidades> TblIntMedicosEspecialidades { get; set; }
    }
}
