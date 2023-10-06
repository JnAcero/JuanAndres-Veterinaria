using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.models;
using WebApi.DTOs;

namespace WebApi.Profiles
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Veterinario,VeterinarioCrteationDTO>().ReverseMap();
            CreateMap<Veterinario,VeterinarioDTO>().ReverseMap();

            CreateMap<Medicamento,MedicamentoCreationDTO>().ReverseMap();

            CreateMap<Rol,RolCreationDTO>().ReverseMap();

            CreateMap<Laboratorio,LaboratorioCrteationDTO>().ReverseMap();

            CreateMap<Mascota,MascotaCreationDTO>().ReverseMap();

            CreateMap<Propietario,PropietarioCreationDto>().ReverseMap();

            CreateMap<Especie,EspecieCreationDTO>().ReverseMap();

            CreateMap<Raza,RazaCreationDTO>().ReverseMap();
            
            CreateMap<Mascota,MascotaDTO>().ReverseMap();
        }
    }
}