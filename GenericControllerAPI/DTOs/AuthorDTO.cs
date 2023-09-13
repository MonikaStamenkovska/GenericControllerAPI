using GenericControllerAPI.Entities;

namespace GenericControllerAPI.DTOs
{
    public class AuthorDTO : BaseEntityDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        List<Book> Books { get; set; } = new List<Book>();
    }
}
