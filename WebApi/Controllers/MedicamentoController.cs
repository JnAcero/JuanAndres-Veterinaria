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
    public class MedicamentoController : BaseApiController
    {
        public MedicamentoController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        [HttpPost("varios")]
        public async Task<ActionResult> PostMedicamentos(MedicamentoCreationDTO[] medsDto)
        {
            var medicamentos = _mapper.Map<Medicamento[]>(medsDto);
            _unitOfWork.Medicamentos.AddRange(medicamentos);
            await _unitOfWork.SaveAsync();

            return Ok(new RespuestaDTO
            {
                success = true,
                message = "Ok",
                result = medicamentos
            });
        }

        [HttpGet("Laboratorios-Genfar")]
        [Authorize]
        public async Task<ActionResult> MedicamentosDeGenfar([FromQuery] Params medicamentosParams)
        {
            var medicamentos = await _unitOfWork.Medicamentos.GetAllAsync(medicamentosParams.PageIndex, medicamentosParams.PageSize, "genfar");

            var paginacionMedicamentos = new Pager<Medicamento>(medicamentos.registros, medicamentos.totalRegistros, medicamentosParams.PageIndex, medicamentosParams.PageSize, "genfar");
            return Ok(paginacionMedicamentos);
        }
        [HttpGet("precioMayorA-50000")]
         [Authorize]
        public async Task<ActionResult> MedsPrecioMayorA50000()
        {
            var response = await _unitOfWork.Medicamentos.Find(m => m.Precio > 50000);


            if (response.Count() == 0)
            {
                return NotFound(new RespuestaDTO
                {
                    success = false,
                    message = "No existen registros con esta descripcion",
                    result = ""

                });
            }

            return Ok(new RespuestaDTO
            {
                success = true,
                message = "Ok",
                result = response.Select(r =>new{
                    r.Id,
                    r.Nombre,
                    r.Precio,
                    r.ID_Laboratorio

                })
            });
        }


    }
}