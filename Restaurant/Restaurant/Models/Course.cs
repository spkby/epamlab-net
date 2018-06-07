using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Course
    {
        [Key]
        [Required]
        public int CourseId { get; set; }
        
        [DisplayName("Coursename")]
        [RegularExpression(@"[\w| ]*", ErrorMessage = "Error Coursename")]
        [Required(ErrorMessage = "Empty Coursename", AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string CourseName { get; set; }

        public virtual ICollection<Dish> Dishes { get; set; }
    }
}