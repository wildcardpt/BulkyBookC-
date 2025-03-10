using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookC_.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(ModelConstants.TEXTFIELDLENGTH)]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(ModelConstants.RANGE_MIN,ModelConstants.RANGE_MAX,ErrorMessage = "Value is out of range 0-100")]
        public int DisplayOrder { get; set; }
    }
}
