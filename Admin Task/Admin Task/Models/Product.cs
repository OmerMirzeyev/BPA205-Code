using Admin_Task.Models.Base;

namespace Admin_Task.Models
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
    }
}
