using EF_Core_Task.Models.Base;

namespace EF_Core_Task.Models
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
