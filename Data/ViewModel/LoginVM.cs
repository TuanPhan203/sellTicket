using System.ComponentModel.DataAnnotations;

namespace eTickets.Data.ViewModel
{
    public class LoginVM
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email là bắt buộc")]
        public string EmailAddress { get; set; }
        [Display(Name = "Mật khẩu")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
