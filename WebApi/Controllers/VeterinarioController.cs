using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Interfaces;
using Core.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTOs;
using WebApi.Helpers;
using WebApi.Helpers.Pager;

namespace WebApi.Controllers
{
    public class VeterinarioController : BaseApiController
    {
        public VeterinarioController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        [HttpPost("varios")]
        public async Task<ActionResult> PostVeterinarios(VeterinarioCrteationDTO[] veterinariosDto)
        {
            foreach(var vet in veterinariosDto)
            {
                var usuarioABuscar = await _unitOfWork.Usuarios.Find(u =>u.Id == vet.ID_Usuario);
                if(usuarioABuscar.Count() != 0)
                {
                    return BadRequest(new RespuestaDTO
                    {
                        success = false,
                        message ="Este id corresponde a otro usuario que  ya existe, porfavor cree un nuevo usuario",
                        result =""
                    });
                }

            }
            var veterinarios = _mapper.Map<Veterinario[]>(veterinariosDto);
            _unitOfWork.Veterinarios.AddRange(veterinarios);
            await _unitOfWork.SaveAsync();

            return Ok(new RespuestaDTO
            {
                success = true,
                message = "Ok",
                result = veterinarios
            });
        }
        [HttpGet("especialidad-Cirujano")]
         [Authorize(Roles ="Admin")]
        public async Task<ActionResult> GetVeterinariosCirujanos([FromQuery] Params veterinariosParams)
        {
            var veterinarios =await  _unitOfWork.Veterinarios.GetAllAsync(veterinariosParams.PageIndex,veterinariosParams.PageSize,"cirujano");

            var paginacionVeterinarios = new Pager<Veterinario>(veterinarios.registros, veterinarios.totalRegistros, veterinariosParams.PageIndex, veterinariosParams.PageSize, "cirujano");
            return Ok(paginacionVeterinarios);

            // var response = await _unitOfWork.Veterinarios.Find(v =>v.Especialidad.ToLower() == "cirujano");
            // if(response is null)
            // {
            //     return NotFound(new RespuestaDTO
            //     {
            //         success = false,
            //         message = "No se encontaron datos con esta especificacion",
            //         result = ""
            //     });
            // }
            // return Ok(new RespuestaDTO
            // {
            //     success = true,
            //     message = "Ok",
            //     result = _mapper.Map<VeterinarioDTO[]>(response)

            // });
        }
    }
}