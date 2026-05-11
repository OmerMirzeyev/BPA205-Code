using EF_Core_Task.Models.Base;

namespace EF_core_task.Models
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get;set; }
    }
}