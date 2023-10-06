using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;
using AutoMapper;
using Core.Interfaces;
using Core.models;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTOs;

namespace WebApi.Controllers
{
    public class PropietarioController : BaseApiController
    {
        public PropietarioController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        [HttpPost("varios")]
         public async Task<ActionResult> PostPropoietarios(PropietarioCreationDto[] propDto)
        {
            foreach(var prop in propDto)
            {
                var usuarioABuscar = await _unitOfWork.Usuarios.Find(u =>u.Id == prop.ID_Usuario);
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
            var propietarios = _mapper.Map<Propietario[]>(propDto);
            _unitOfWork.Propietarios.AddRange(propietarios);
            await _unitOfWork.SaveAsync();

            return Ok(new RespuestaDTO
            {
                success = true,
                message = "Ok",
                result = propietarios
            });
        }
        [HttpGet("propietariosYMascotas")]
        public async Task<ActionResult> GetPropietariosyMascotas()
        {
            var response = await _unitOfWork.Propietarios.GetPropietariosYMascotas();

            return Ok(new RespuestaDTO
            {
                success = true,
                message = "Ok",
                result = response
            });
        }



    }
}