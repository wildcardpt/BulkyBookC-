using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBook_Razor.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30)]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage = "Value is out of range 0-100")]
        public int DisplayOrder { get; set; }
    }
}
