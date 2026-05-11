using PronionAndAdmin_Task.Models.Base;

namespace PronionAndAdmin_Task.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}