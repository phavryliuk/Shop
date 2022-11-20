using Shop.Data.Models;


namespace Shop.Data.interfaces
{
    public interface ICarsCategory
    {
        public IEnumerable<Category> AllCategories { get; }
    }
}
