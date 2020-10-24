using AutoMapper;
using WebApiForAngular.Entity.Concrete;
using WebApiForAngular.Entity.Dtos;

namespace WebApiForAngular.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<EmployeeAddDto, Employee>();
            CreateMap<Employee, EmployeeAddDto>();

            CreateMap<Employee, EmployeeUpdateDto>();
            CreateMap<EmployeeUpdateDto, Employee>();

            CreateMap<Department, DepartmentAddDto>();
            CreateMap<DepartmentAddDto, Department>();

            CreateMap<Department, DepartmentUpdateDto>();
            CreateMap<DepartmentUpdateDto, Department>();

            
        }
    }
}
