using AutoMapper;
using BookStoreApi.DTOs;
using BookStoreApi.Models;

namespace BookStoreApi.Utilities.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {

            #region User
            CreateMap<User, UserDTO>().ReverseMap();
            #endregion



        }

    }
}
