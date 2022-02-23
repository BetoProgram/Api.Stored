using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Stored.Core.Entities
{
    [Table(name: "TblIntMedicosEspecialidades", Schema = "CitasMedicas")]
    public class TblIntMedicosEspecialidades
    {
        public int FiIdMedEspecialidades { get; set; }
        public short FiIdMedico { get; set; }
        public byte FiIdEspecialidad { get; set; }
        public bool? FlActivo { get; set; }
        public DateTime? FdFechaRegistro { get; set; }

        public virtual TblCatEspecialidades TblCatEspecialidades { get; set; }
        public virtual TblCatMedico TblCatMedico { get; set; }
    }
}
