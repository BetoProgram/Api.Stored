using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Stored.Application.Dtos
{
    public class BaseAudit
    {
        public DateTime? FdFechaRegistro { get; set; }
        public DateTime? FdFechaModificacion { get; set; }
        public string FcUsuarioRegistro { get; set; }
        public string FcUsuarioModificacion { get; set; }
        public bool? FlActivo { get; set; }
    }
}
