using Image_Upload_and_Slider_CRUD.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Image_Upload_and_Slider_CRUD.Models
{
    public class Slider : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

    }
}
