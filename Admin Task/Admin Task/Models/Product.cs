using Admin_Task.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Admin_Task.Models
{
    public class Product : BaseEntity
    {
        //Title Validation
        [Required(ErrorMessage = "Title is required.")]
        [
            StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters..."),
            MinLength(3, ErrorMessage = "Title cannot be at least 3 characterc...")
        ]
        public string Title { get; set; }

        //ImageUrl Validation   
        [Required(ErrorMessage = "ImageUrl is required.")]
        public string ImageUrl { get; set; }

        //Category Validation
        [Required(ErrorMessage = "Category is required.")]
        [
            StringLength(50, ErrorMessage = "Category cannot be longer than 50 characters..."),
            MinLength(3, ErrorMessage = "Category cannot be at least 3 characterc...")
        ]
        public string Category { get; set; }
    }
}
