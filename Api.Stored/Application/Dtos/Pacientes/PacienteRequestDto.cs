using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Stored.Application.Dtos.Pacientes
{
    public class PacienteRequestDto : BaseAudit
    {
        public int FiIdPaciente { get; set; }
        [Required(ErrorMessage ="El campo nombre es requerido")]
        public string FcNombres { get; set; }
        [Required(ErrorMessage = "El campo apellidos es requerido")]
        public string FcApellidos { get; set; }
        [Required(ErrorMessage = "El campo dirección es requerido")]
        public string FcDireccion { get; set; }
        [Required(ErrorMessage = "El campo telefono es requerido")]
        public string FcTelefono { get; set; }
        [Required(ErrorMessage = "El campo genero es requerido")]
        public string FcSexo { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage ="El campo email es invalido")]
        public string FcEmail { get; set; }
        [Required(ErrorMessage = "El campo fecha de nacimiento es requerido")]
        public DateTime? FdFechaNacimiento { get; set; }
    }
}
