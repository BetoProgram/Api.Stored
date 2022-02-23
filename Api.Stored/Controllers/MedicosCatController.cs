using Api.Stored.Application.Dtos.Medicos;
using Api.Stored.Core.Entities;
using Api.Stored.Core.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Stored.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MedicosCatController : ControllerBase
    {
        private readonly IRepositoryBase<TblCatMedico> _repositoryBase;
        private readonly IMapper _mapper;

        public MedicosCatController(IRepositoryBase<TblCatMedico> repositoryBase, IMapper mapper)
        {
            _repositoryBase = repositoryBase;
            _mapper = mapper;
        }
        // GET: api/<MedicosController>
        [HttpGet]
        public IEnumerable<MedicoResponseDto> Get()
        {
            var medicos = _repositoryBase.FindAll();
            var medicosMap = _mapper.Map<List<MedicoResponseDto>>(medicos);
            return medicosMap;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MedicoResponseDto>> Get(int id)
        {
            var medico = await _repositoryBase.FindBy(x => x.FiIdMedico == id);
            var medicoMap = _mapper.Map<MedicoResponseDto>(medico);
            return Ok(medicoMap);
        }

        // POST api/<MedicosController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] MedicoRequestDto model)
        {
            string userName = User.FindFirst(ClaimTypes.Name)?.Value;
            var medico = _mapper.Map<TblCatMedico>(model);
            medico.FcUsuarioRegistro = userName;
            await _repositoryBase.CreateAsync(medico);
            return Ok();
        }

        // PUT api/<MedicosController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] MedicoRequestDto model)
        {
            string userName = User.FindFirst(ClaimTypes.Name)?.Value;
            var medicoEncontrado = await _repositoryBase.FindBy(x => x.FiIdMedico == id);

            if (medicoEncontrado != null)
            {
                return BadRequest(new { mensaje = "El medico ingresado no existe" });
            }

            medicoEncontrado.FdFechaModificacion = DateTime.Now;
            medicoEncontrado.FcUsuarioModificacion = userName;

            medicoEncontrado = _mapper.Map<TblCatMedico>(model);

            await _repositoryBase.UpdateAsync(medicoEncontrado);

            return Ok();

        }


        // DELETE api/<MedicosController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var medicoEncontrado = await _repositoryBase.FindBy(x => x.FiIdMedico == id);

            if (medicoEncontrado != null)
            {
                return BadRequest(new { mensaje = "El medico ingresado no existe" });
            }

            await _repositoryBase.DeleteAsync(medicoEncontrado);

            return Ok();
        }
    }
}
