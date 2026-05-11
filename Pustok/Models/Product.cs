using EF_Core_Task.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_core_task.Models
{
    public class Product : BaseEntity
    {
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        [Required(ErrorMessage = "Product title is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0, 1000000, ErrorMessage = "Price cannot be less than 0.")]
        public int Price { get; set; }
        
        public string? Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
