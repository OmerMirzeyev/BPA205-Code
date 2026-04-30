using PronionSimulation.Models.Base;

namespace PronionSimulation.Models
{
    public class Tags : BaseEntity
    {

        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
