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
            
            
            CreateMap<EmployeeMethod, MethodViewModel>().ReverseMap();
            CreateMap<EmployeeMethod, EmployeeDetailsViewModel>().ReverseMap();
            CreateMap<Category, CategoryViewModel>().ReverseMap();

            CreateMap<Method, MethodViewModel>()
                // Method -> MethodViewModel
                .ForMember(m => m.EmployeeDetails, opt => opt.MapFrom(m => m.EmployeeMethods
                            .Select(em => em.Employee)))
                .ReverseMap() // MethodViewModel -> Method
                .PreserveReferences()
                .ForMember(em => em.EmployeeMethods, opt => opt.MapFrom(m => m.EmployeeDetails
                                                     .Select(e => new
                                                     {
                                                         e.Id,
                                                         Employee = e,
                                                         m.MethodId,
                                                         Method = m
                                                     })));
               
        }
    }
}
