namespace GenericControllerAPI.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public int PagesCount { get; set; }
        public Author Author { get; set; }
        public Guid AuthorId { get; set; }
    }
}
