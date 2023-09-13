using GenericControllerAPI.DTOs;
using GenericControllerAPI.Entities;
using GenericControllerAPI.Services;

namespace GenericControllerAPI.Controllers
{
    public class BookController : BaseCrudController<IBookService, BookDTO, Book>
    {
        public BookController(IBookService baseCrudService) : base(baseCrudService)
        {
        }
    }
}
