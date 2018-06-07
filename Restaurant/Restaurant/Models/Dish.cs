using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    public class Dish
    {
        [Key]
        [Required]
        public int DishId { get; set; }
        
        [DisplayName("Dishname")]
        [RegularExpression(@"[\w| ]*", ErrorMessage = "Error Dishname")]
        [Required(ErrorMessage = "Empty Dishname", AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string Dishname { get; set; }
        
        [DisplayName("Description")]
        [RegularExpression(@"[\w| ]*", ErrorMessage = "Error Description")]
        [Required(ErrorMessage = "Empty Description", AllowEmptyStrings = false)]
        [MaxLength(255)]    
        public string desc { get; set;}
        
        [DisplayName("Price")]
        [RegularExpression(@"[\d| ]*", ErrorMessage = "Error Price")]
        [Required(ErrorMessage = "Empty Price", AllowEmptyStrings = false)]
        [MaxLength(255)]    
        public int price { get; set;}
        
        [Required]
        [DisplayName("CourseId")]
        public int CourseId { get; set; }

        [DisplayName("Course")]
        [NotMapped]
        public virtual Course Course { get; set; }

        public Dish(string Dishname, string desc, int price)
        {
            this.Dishname = Dishname;
            this.desc = desc;
            this.price = price;
        }
    }
}