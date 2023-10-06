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
    public class EspecieController : BaseApiController
    {
        public EspecieController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        [HttpPost("varios")]
        public async Task<ActionResult> PostEspecies(EspecieCreationDTO[] especiesDto)
        {
             var especies = _mapper.Map<Especie[]>(especiesDto);
            _unitOfWork.Especies.AddRange(especies);
            await _unitOfWork.SaveAsync();

            return Ok(new RespuestaDTO
            {
                success = true,
                message = "Ok",
                result = especies
            });

        }
    }
}