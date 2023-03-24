using AutoMapper;
using School.Api.DTOs;
using School.Infrastructure.BusinessObjects;
using StudentBO = School.Infrastructure.BusinessObjects.Student;
using StudentEO = School.Infrastructure.Entities.Student;
namespace School.API.Profiles
{
    public class ApiProfile : Profile
    {
        public ApiProfile()
        {
            CreateMap<StudentDTO, StudentBO>().ReverseMap();
            CreateMap<StudentBO, StudentEO>().ReverseMap();
        }
    }
}
