using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Role
    {
        [Key]
        [Required]
        public int RoleId { get; set; }
        
        [DisplayName("Rolename")]
        [RegularExpression(@"[\w| ]*", ErrorMessage = "Error Rolename")]
        [Required(ErrorMessage = "Empty Rolename", AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}