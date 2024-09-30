using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Categories.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty; // Initialize to an empty string
        public int DisplayOrder { get; set; }

    }
}