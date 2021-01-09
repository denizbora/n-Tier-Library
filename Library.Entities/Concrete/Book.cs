using Library.Entities.Abstract;

namespace Library.Entities.Concrete
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public override string ToString() =>
            $"{Id,-5} {Title,-35} {Description,-15}{CategoryId,-5}";
    }
}
