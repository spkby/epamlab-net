using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Dish
    {
        [Key] [Required] public int DishId { get; set; }

        [DisplayName("Dishname")]
        [RegularExpression(@"[\w| ]*", ErrorMessage = "Error Dishname")]
        [Required(ErrorMessage = "Empty Dishname", AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string Dishname { get; set; }

        [DisplayName("Description")]
        [RegularExpression(@"[\w| ]*", ErrorMessage = "Error Description")]
        [Required(ErrorMessage = "Empty Description", AllowEmptyStrings = false)]
        [MaxLength(255)]
        public string Desc { get; set; }

        [DisplayName("Price")]
        [RegularExpression(@"[0-9]+", ErrorMessage = "Error Price")]
        [Required(ErrorMessage = "Empty Price")]
        public int Price { get; set; }

        [Required] [DisplayName("Course")] public int Course { get; set; }
    }
}
