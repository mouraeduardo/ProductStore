using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProductStore.Domain.Models;
using ProductStore.Resources;

namespace ProductStore.Util.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<User, UserResource>();
        }
    }
}
