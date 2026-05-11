using PronionAndAdmin_Task.Models.Base;

namespace PronionAndAdmin_Task.Models
{
    public class Review : BaseEntity
    {
        public string UserName { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}