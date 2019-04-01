using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using IranExpert.Models;
using IranExpert.Dto;


namespace IranExpert.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<City, CityDto>();
            Mapper.CreateMap<CityDto, City>();

            Mapper.CreateMap<Status, StatusDto>();
            Mapper.CreateMap<StatusDto, Status>();

            Mapper.CreateMap<Degree, DegreeDto>();
            Mapper.CreateMap<DegreeDto,Degree>();

            Mapper.CreateMap<University,UniversityDto>();
            Mapper.CreateMap<UniversityDto, University>();

            Mapper.CreateMap<Country,CountryDto>();
            Mapper.CreateMap<CountryDto,Country>();

            Mapper.CreateMap<Profiles, ProfilesDto>();

            // Dto to Domain
            Mapper.CreateMap<ProfilesDto, Profiles>().ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<ProfilesDto, Profiles>();
        }
    }
}