using Simulation_2.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simulation_2.Models
{
    public class Slider : BaseEntity
    {
        [Required(ErrorMessage = "Title is required.")]
        [
            StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters..."),
            MinLength(3, ErrorMessage = "Title cannot be at least 3 characterc...")
        ]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        [
           StringLength(150, ErrorMessage = "Description cannot be longer than 150 characters..."),
           MinLength(10, ErrorMessage = "Description cannot be at least 10 characters...")
       ]
        public string Description { get; set; }
        [Required(ErrorMessage = "ImageUrl is required.")]
        public string? ImageUrl { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
