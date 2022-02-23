using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Stored.Application.Dtos.Medicos
{
    public class MedicoResponseDto
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
        public bool? FlActivo { get; set; }
    }
}
