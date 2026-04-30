using PronionSimulation.Models.Base;

namespace PronionSimulation.Models
{
    public class Review : BaseEntity
    {
        public string UserName { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Product Product { get; set; }


    }
}
