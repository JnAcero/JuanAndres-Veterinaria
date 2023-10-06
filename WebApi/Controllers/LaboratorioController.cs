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
    public class LaboratorioController : BaseApiController
    {
        public LaboratorioController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        [HttpPost("varios")]
        public async Task<ActionResult> PostLabs(LaboratorioCrteationDTO[] labsDto)
        {
            var labs = _mapper.Map<Laboratorio[]>(labsDto);
            _unitOfWork.Laboratorios.AddRange(labs);
            await _unitOfWork.SaveAsync();

            return Ok(new RespuestaDTO
            {
                success = true,
                message = "Ok",
                result = labs
            });
        }
    }
}