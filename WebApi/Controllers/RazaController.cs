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
    public class RazaController : BaseApiController
    {
        public RazaController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        [HttpPost("varios")]
        public async Task<ActionResult> PostRazas(RazaCreationDTO[] razaDto )
        {
             var razas = _mapper.Map<Raza[]>(razaDto);
            _unitOfWork.Razas.AddRange(razas);
            await _unitOfWork.SaveAsync();

            return Ok(new RespuestaDTO
            {
                success = true,
                message = "Ok",
                result = razas
            });

        }
    }
}