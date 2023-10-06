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
    public class RolController : BaseApiController
    {
        public RolController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        
         [HttpPost("varios")]
        public async Task<ActionResult> PostVeterinarios(RolCreationDTO[] rolesDto)
        {
            var roles = _mapper.Map<Rol[]>(rolesDto);
            _unitOfWork.Roles.AddRange(roles);
            await _unitOfWork.SaveAsync();

            return Ok(new RespuestaDTO
            {
                success = true,
                message = "Ok",
                result = roles
            });
        }
    }
}