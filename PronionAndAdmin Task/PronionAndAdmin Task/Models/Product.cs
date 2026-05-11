using Microsoft.AspNetCore.Mvc.ViewEngines;
using PronionAndAdmin_Task.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace PronionAndAdmin_Task.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }
        public List<Category> Categories { get; set; }
        public List<Tag> Tags { get; set; }
        public string? ImageUrl { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public List<Review>? Reviews { get; set; }
    }
}
