using AutoMapper;
using GenericControllerAPI.DTOs;
using GenericControllerAPI.Entities;

namespace GenericControllerAPI.Mapper
{
    public class MyProfile : Profile
    {
        public MyProfile()
        {
            CreateMap<AuthorDTO, Author>().ReverseMap();
            CreateMap<BookDTO, Book>().ReverseMap();
            CreateMap<BaseEntityDTO, BaseEntity>().ReverseMap();

        }
    }
}
