using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Stored.Core.Entities
{
    [Table(name: "TblCatEspecialidades", Schema = "CitasMedicas")]
    public class TblCatEspecialidades
    {
        public byte FiIdEspecialidad { get; set; }
        public string FcNombre { get; set; }
        public string FcDescripcion { get; set; }
        public DateTime? FdFechaRegistro { get; set; }
        public DateTime? FdFechaModificacion { get; set; }
        public string FcUsuarioRegistro { get; set; }
        public string FcUsuarioModificacion { get; set; }
        public bool? FlActivo { get; set; }

        public virtual ICollection<TblIntMedicosEspecialidades> TblIntMedicosEspecialidades { get; set; }
    }
}
