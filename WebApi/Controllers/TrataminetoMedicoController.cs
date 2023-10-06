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
    public class TrataminetoMedicoController : BaseApiController
    {
        public TrataminetoMedicoController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        [HttpPost]
         public async Task<ActionResult> PostTratMedico(TratMedicoCreationDTO tratMedicoDto)
        {
            var tratMedico = _mapper.Map<TratamientoMedico>(tratMedicoDto);
            _unitOfWork.TratamientostoMedicos.Add(tratMedico);
            await _unitOfWork.SaveAsync();
            return Ok(new RespuestaDTO
            {
                success = true,
                message = "Ok",
                result = tratMedico
            });

        }

    }
}