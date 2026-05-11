using PronionAndAdmin_Task.Models.Base;

namespace PronionAndAdmin_Task.Models
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}