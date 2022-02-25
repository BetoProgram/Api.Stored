using Api.Stored.Application.Dtos.Citas;
using Api.Stored.Core.Repository;
using Dapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Stored.Application.Citas.Commands
{
    public class GenerarCitasCommand: ConRequestCitasDto,IRequest
    {
        public class GenerarCitasHandler : IRequestHandler<GenerarCitasCommand>
        {
            private readonly IDapperRepositoryBase<ConRequestCitasDto> _dapperResponseBase;

            public GenerarCitasHandler(IDapperRepositoryBase<ConRequestCitasDto> dapperResponseBase)
            {
                _dapperResponseBase = dapperResponseBase;
            }
            public async Task<Unit> Handle(GenerarCitasCommand request, CancellationToken cancellationToken)
            {
                var p = new DynamicParameters();

                p.Add("@fiAnio", request.fiAnio);
                p.Add("@fiMes", request.fiMes);
                p.Add("@fiIdCita", request.fiIdCita);
                p.Add("@fiMedico", request.fiIdMedico);
                p.Add("@fiPaciente", request.fiIdPaciente);
                p.Add("@fdFechaAtencion", request.fdFechaAtencion);
                p.Add("@ftInicioAtencion", request.ftInicioAtencion);
                p.Add("@ftFinAtencion", request.ftFinAtencion);
                p.Add("@fcEstado", request.fcEstado);
                p.Add("@fcObservaciones", request.fcObservaciones);
                p.Add("@fcUsuarioRegistro", request.fcUsuarioRegistro);
                p.Add("@fcUsuarioModificacion", request.fcUsuarioModificacion);
                p.Add("@flActivo", request.flActivo);

                await _dapperResponseBase.Execute("CitasMedicas.UspInsCitas",p, System.Data.CommandType.StoredProcedure);

                return Unit.Value;
                
            }
        }
    }
}
