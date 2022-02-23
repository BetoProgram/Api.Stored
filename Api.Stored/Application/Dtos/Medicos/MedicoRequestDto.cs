using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Stored.Application.Dtos.Medicos
{
    public class MedicoRequestDto:BaseAudit
    {
        public short FiIdMedico { get; set; }
        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string FcNombres { get; set; }
        [Required(ErrorMessage = "El campo apellidos es requerido")]
        public string FcApellidos { get; set; }
        [Required(ErrorMessage = "El campo cedula es requerido")]
        public string FcClaveCedula { get; set; }
        [Required(ErrorMessage = "El campo dirección es requerido")]
        public string FcDireccion { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "El campo email es invalido")]
        public string FcEmail { get; set; }
        public string FcTelefono1 { get; set; }
        public string FcTelefono2 { get; set; }
        [Required(ErrorMessage = "El campo genero es requerido")]
        public string FcSexo { get; set; }
    }
}
