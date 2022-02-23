using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Stored.Application.Dtos.Pacientes
{
    public class PacientesResponseDto
    {
        public int FiIdPaciente { get; set; }
        public string FcNombres { get; set; }
        public string FcApellidos { get; set; }
        public string FcDireccion { get; set; }
        public string FcTelefono { get; set; }
        public string FcSexo { get; set; }
        public string FcEmail { get; set; }
        public DateTime? FdFechaNacimiento { get; set; }
        public bool? FlActivo { get; set; }
    }
}
