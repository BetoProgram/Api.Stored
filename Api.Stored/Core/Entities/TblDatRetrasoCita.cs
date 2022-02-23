using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Stored.Core.Entities
{
    [Table(name: "TblDatRetrasoCita", Schema = "CitasMedicas")]
    public class TblDatRetrasoCita
    {
        public int FiIdCita { get; set; }
        public short FiAnio { get; set; }
        public byte FiMes { get; set; }
        public short FiIdRetraso { get; set; }
        public int FiIdMedico { get; set; }
        public int FiIdPaciente { get; set; }
        public DateTime FdFecha { get; set; }
        public TimeSpan FtInicio { get; set; }
        public TimeSpan FtFin { get; set; }
        public string FcObservaciones { get; set; }
        public DateTime? FdFechaRegistro { get; set; }
        public DateTime? FdFechaModificacion { get; set; }
        public string FcUsuarioRegistro { get; set; }
        public string FcUsuarioModificacion { get; set; }
        public bool? FlActivo { get; set; }

        public virtual TblDatCita TblDatCita { get; set; }
    }
}
