using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Interfaces;
using Core.models;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTOs;

namespace WebApi.Controllers
{
    public class CitaController : BaseApiController
    {
        public CitaController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        [HttpPost]
        public async Task<ActionResult> PostCita(CitaCreationDTO citaDto)
        {
            var cita = _mapper.Map<Cita>(citaDto);
            _unitOfWork.Citas.Add(cita);
            await _unitOfWork.SaveAsync();
            return Ok(new RespuestaDTO
            {
                success = true,
                message = "Ok",
                result = cita
            });

        }

    }
}