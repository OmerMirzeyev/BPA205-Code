using EF_Core_Task.Models.Base;

namespace EF_Core_Task.Models
{
    public class Slider : BaseEntity
    {
        public string Text { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }

}
