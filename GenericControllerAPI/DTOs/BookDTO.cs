using GenericControllerAPI.Entities;

namespace GenericControllerAPI.DTOs
{
    public class BookDTO : BaseEntityDTO
    {
        public string Name { get; set; }
        public int PagesCount { get; set; }
        public Author Author { get; set; }
        public Guid AuthorId { get; set; }
    }
}
