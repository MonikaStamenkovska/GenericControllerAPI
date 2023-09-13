using AutoMapper;
using GenericControllerAPI.DTOs;
using GenericControllerAPI.Entities;

namespace GenericControllerAPI.Services
{
    public class AuthorService : BaseCrudService<AuthorDTO, Author>, IAuthorService
    {
        public AuthorService(AppDbContext db, IMapper mapper) : base(db, mapper)
        {
        }
    }
}
