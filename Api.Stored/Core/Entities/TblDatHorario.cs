using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Stored.Core.Entities
{
    [Table(name: "TblDatHorario", Schema = "CitasMedicas")]
    public class TblDatHorario
    {
        public short FiIdHorario { get; set; }
        public short FiIdMedico { get; set; }
        public DateTime FdFechaAtencion { get; set; }
        public TimeSpan FtInicioAtencion { get; set; }
        public TimeSpan FtFinAtencion { get; set; }
        public DateTime? FdFechaRegistro { get; set; }
        public DateTime? FdFechaModificacion { get; set; }
        public string FcUsuarioRegistro { get; set; }
        public string FcUsuarioModificacion { get; set; }
        public bool? FlActivo { get; set; }

        public virtual TblCatMedico TblCatMedico { get; set; }
    }
}
