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
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    public class MascotaController : BaseApiController
    {
        public MascotaController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        [HttpPost("varios")]
        public async Task<ActionResult> PostMascotas(MascotaCreationDTO[] mascotaDto)
        {
            var mascotas = _mapper.Map<Mascota[]>(mascotaDto);
            _unitOfWork.Mascotas.AddRange(mascotas);
            await _unitOfWork.SaveAsync();

            return Ok(new RespuestaDTO
            {
                success = true,
                message = "Ok",
                result = mascotas
            });
        }
        [MapToApiVersion("1.1")]
        [HttpGet("especie-felina")]
        
        public async Task<ActionResult> GetMascotasFelinas([FromQuery] Params mascotasParams)
        {
             var mascotas =await  _unitOfWork.Mascotas.GetAllAsync(mascotasParams.PageIndex,mascotasParams.PageSize,"felina");
           
            var paginacionmascotas = new Pager<Mascota>(mascotas.registros, mascotas.totalRegistros, mascotasParams.PageIndex, mascotasParams.PageSize, "felina");
            return Ok(paginacionmascotas);

        }
        [HttpGet("MascotasVacunadasPrimerTimestre2023")]
        [Authorize(Roles ="Admin")]
        public async Task<ActionResult> GetMascotasVCacunadasPrimerTimestre2023()
        {
            var response = _unitOfWork.Mascotas.MascotasVCacunadasPrimerTimestre2023();

            return Ok(response);
            
        }
    }


}