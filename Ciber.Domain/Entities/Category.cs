namespace Ciber.Domain.Entities
{
    public class Category
    {
        public Category() {
            Products = new HashSet<Product>();
        }       
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public ICollection<Product> Products { get; private set; }

    }
}