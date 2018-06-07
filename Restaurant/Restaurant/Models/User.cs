using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    public class User
    {
        [Key]
        [Required]
        public int UserID { get; set; }

        [DisplayName("Username")]
        [RegularExpression(@"[\w| ]*", ErrorMessage = "Error Username")]
        [Required(ErrorMessage = "Empty Username", AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string Name { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Empty Password", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [MaxLength(20)]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords is not match")]
        [NotMapped]
        public string PasswordCnfm { get; set; }

        [Required]
        [DisplayName("roleId")]
        public int RoleId { get; set; }

        [DisplayName("Role")]
        [NotMapped]
        public virtual Role Role { get; set; }
    }
}