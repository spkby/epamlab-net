using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    public class Account
    {
        [Key]
        [Required]
        public int AccountId { get; set; }

        [DisplayName("Login")]
        [RegularExpression(@"[\w| ]*", ErrorMessage = "Error Login")]
        [Required(ErrorMessage = "Empty Login", AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string Login { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Empty Password", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [MaxLength(20)]
        public string Password { get; set; }

        [NotMapped]
        [DisplayName("Remember Me")]
        public bool RememberMe { get; set; }
    }
}