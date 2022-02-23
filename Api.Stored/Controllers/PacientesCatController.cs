using Api.Stored.Application.Dtos.Pacientes;
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
    public class PacientesCatController : ControllerBase
    {
        private readonly IRepositoryBase<TblCatPaciente> _repositoryBase;
        private readonly IMapper _mapper;

        public PacientesCatController(IRepositoryBase<TblCatPaciente> repositoryBase, IMapper mapper)
        {
            _repositoryBase = repositoryBase;
            _mapper = mapper;
        }
        // GET: api/<PacientesCatController>
        [HttpGet]
        public IEnumerable<PacientesResponseDto> Get()
        {
            var pacientes = _repositoryBase.FindAll();
            var pacientesMap = _mapper.Map<List<PacientesResponseDto>>(pacientes);
            return pacientesMap;
        }

        // GET api/<PacientesCatController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PacientesResponseDto>> Get(int id)
        {
            var paciente = await _repositoryBase.FindBy(x => x.FiIdPaciente == id);
            var pacienteMap = _mapper.Map<PacientesResponseDto>(paciente);
            return Ok(pacienteMap);
        }

        // POST api/<PacientesCatController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PacienteRequestDto model)
        {
            string userName = User.FindFirst(ClaimTypes.Name)?.Value;
            var paciente = _mapper.Map<TblCatPaciente>(model);
            paciente.FcUsuarioRegistro = userName;
            await _repositoryBase.CreateAsync(paciente);
            return Ok();
        }

        // PUT api/<PacientesCatController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] PacienteRequestDto model)
        {
            string userName = User.FindFirst(ClaimTypes.Name)?.Value;

            var pacienteEncontrado = await _repositoryBase.FindBy(x => x.FiIdPaciente == id);

            if (pacienteEncontrado != null)
            {
                return BadRequest(new { mensaje = "El paciente ingresado no existe" });
            }

            pacienteEncontrado.FdFechaModificacion = DateTime.Now;
            pacienteEncontrado.FcUsuarioModificacion = userName;

            pacienteEncontrado = _mapper.Map<TblCatPaciente>(model);

           await _repositoryBase.UpdateAsync(pacienteEncontrado);

           return Ok();

        }

        // DELETE api/<PacientesCatController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var pacienteEncontrado = await _repositoryBase.FindBy(x => x.FiIdPaciente == id);

            if (pacienteEncontrado != null)
            {
                return BadRequest(new { mensaje = "El paciente ingresado no existe" });
            }

            await _repositoryBase.DeleteAsync(pacienteEncontrado);

            return Ok();
        }
    }
}
