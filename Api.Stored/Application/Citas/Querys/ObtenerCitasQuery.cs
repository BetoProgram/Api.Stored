using Api.Stored.Application.Dtos.Citas;
using Api.Stored.Core.Repository;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Stored.Application.Citas.Querys
{
    public class ObtenerCitasQuery:IRequest<List<CitasConResponseDto>>
    {
        public class ObtenerCitasHandler : IRequestHandler<ObtenerCitasQuery, List<CitasConResponseDto>>
        {
            private readonly IDapperRepositoryBase<CitasConResponseDto> _dapperRepositoryBase;

            public ObtenerCitasHandler(IDapperRepositoryBase<CitasConResponseDto> dapperRepositoryBase)
            {
                _dapperRepositoryBase = dapperRepositoryBase;
            }
            public async Task<List<CitasConResponseDto>> Handle(ObtenerCitasQuery request, CancellationToken cancellationToken)
            {
                var citas = await _dapperRepositoryBase.Query("CitasMedicas.UspConCitas", null, System.Data.CommandType.StoredProcedure);
                return citas.ToList();
            }
        }
    }
}
