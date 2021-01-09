using Library.Core.Abstract;

namespace Library.Core.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public override string ToString() =>
            $"{CategoryId,-5} {CategoryName,-35}";
    }
}
