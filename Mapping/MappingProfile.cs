using AngularWithCore.Controllers.Resources;
using AngularWithCore.Models;
using AutoMapper;

namespace AngularWithCore.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResources>();
            CreateMap<Model,ModelResources>();
        }
    }
    
}