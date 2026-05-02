using Details_Page_Task.Models.Base;

namespace Details_Page_Task.Models
{
    public class Review : BaseEntity
    {
        public string UserName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Product Product { get; set; }

    }
}
