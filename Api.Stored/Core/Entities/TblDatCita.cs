using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Stored.Core.Entities
{
    [Table(name: "TblDatCita", Schema ="CitasMedicas")]
    public class TblDatCita
    {
        public int FiIdCita { get; set; }
        public short FiAnio { get; set; }
        public byte FiMes { get; set; }
        public short FiIdMedico { get; set; }
        public int FiIdPaciente { get; set; }
        public DateTime FdFechaAtencion { get; set; }
        public TimeSpan FtInicioAtencion { get; set; }
        public TimeSpan FtFinAtencion { get; set; }
        public string FcEstado { get; set; }
        public string FcObservaciones { get; set; }
        public bool FcActivo { get; set; }
        public DateTime? FdFechaRegistro { get; set; }
        public DateTime? FdFechaModificacion { get; set; }
        public string FcUsuarioRegistro { get; set; }
        public string FcUsuarioModificacion { get; set; }
        public bool? FlActivo { get; set; }

        public virtual TblCatMedico TblCatMedico { get; set; }
        public virtual TblCatPaciente TblCatPaciente { get; set; }
        public virtual ICollection<TblDatRetrasoCita> TblDatRetrasoCita { get; set; }
    }
}
