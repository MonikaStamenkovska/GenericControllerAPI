using AutoMapper;
using GenericControllerAPI.DTOs;
using GenericControllerAPI.Entities;

namespace GenericControllerAPI.Services
{
    public class BookService : BaseCrudService<BookDTO, Book>, IBookService
    {
        public BookService(AppDbContext db, IMapper mapper) : base(db, mapper)
        {
        }
    }
}
