using System.ComponentModel.DataAnnotations;

namespace eTickets.Data.ViewModel
{
    public class RegisterVM
    {
        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Họ tên is required")]
        public string FullName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email không được trống")]
        public string EmailAddress { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu là bắt buộc.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có ít nhất 8 ký tự.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
        ErrorMessage = "Mật khẩu phải có ít nhất một chữ cái viết hoa, một chữ cái viết thường, một số và một ký tự đặc biệt.")]
        public string Password { get; set; }

        [Display(Name = "Xác nhận mật khẩu")]
        [Required(ErrorMessage = "Phải nhập lại mật khẩu")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Nhập lại mật khẩu không khớp")]
        public string ConfirmPassword { get; set; }
    }
}
