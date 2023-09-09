namespace GenericControllerAPI.Entities
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        List<Book> Books { get; set; } = new List<Book>();
    }
}
