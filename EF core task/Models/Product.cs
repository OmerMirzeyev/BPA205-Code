namespace EF_core_task.Models
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }

    }
}
