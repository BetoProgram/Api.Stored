using System;

namespace Api.Stored.Application.Dtos.Citas
{
    public class ConRequestCitasDto
    {
		public int fiIdCita { get; set; }
		public short fiAnio { get; set; }
		public byte fiMes { get; set; }
		public short fiIdMedico { get; set; }
		public int fiIdPaciente { get; set; }
		public DateTime fdFechaAtencion { get; set; }
		public TimeSpan ftInicioAtencion { get; set; }
		public TimeSpan ftFinAtencion { get; set; }
		public string fcEstado { get; set; }
		public string fcObservaciones { get; set; }
		public DateTime fdFechaRegistro { get; set; }
		public DateTime fdFechaModificacion { get; set; }
		public string fcUsuarioRegistro { get; set; }
		public string fcUsuarioModificacion { get; set; }
		public bool flActivo { get; set; }
	}
}
