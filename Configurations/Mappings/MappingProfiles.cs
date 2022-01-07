using AutoMapper;
using EmployeeCapibilityDemonstration.Models;
using EmployeeCapibilityDemonstration.ViewModels.Category;
using EmployeeCapibilityDemonstration.ViewModels.Employee;
using EmployeeCapibilityDemonstration.ViewModels.Method;

namespace EmployeeCapibilityDemonstration.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Employee, EmployeeListViewModel>().ReverseMap();
            CreateMap<Employee, EmployeeDetailsViewModel>().ReverseMap();
            CreateMap<Employee, MethodViewModel>().ReverseMap();
            CreateMap<Method, MethodViewModel>().ReverseMap();
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            

        }
    }
}
