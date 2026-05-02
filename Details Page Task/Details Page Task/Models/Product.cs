using Details_Page_Task.Models.Base;

namespace Details_Page_Task.Models
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
