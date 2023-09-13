using GenericControllerAPI.DTOs;
using GenericControllerAPI.Entities;
using GenericControllerAPI.Services;

namespace GenericControllerAPI.Controllers
{
    public class AuthorController : BaseCrudController<IAuthorService, AuthorDTO, Author>
    {
        public AuthorController(IAuthorService baseCrudService) : base(baseCrudService)
        {
        }
    }
}
