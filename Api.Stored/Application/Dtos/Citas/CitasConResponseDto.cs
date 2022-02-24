using System;

namespace Api.Stored.Application.Dtos.Citas
{
    public class CitasConResponseDto
    {
        public short fiIdCita { get; set; }
        public byte fiAnio { get; set; }
        public byte fiMes { get; set; }
        public short fiIdMedico { get; set; }
        public short fiIdPaciente { get; set; }
        public string fcNombreMedico { get; set; }
        public string fcNombrePaciente { get; set; }
        public DateTime fdFechaAtencion { get; set; }
        public TimeSpan ftInicioAtencion { get; set; }
        public TimeSpan ftFinAtencion { get; set; }
        public string fcEstado { get; set; }
        public string fnNoCita { get; set; }
    }
}
