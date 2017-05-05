using System.ComponentModel.DataAnnotations;

namespace Studio27SalonOfBeauty.Models.ViewModels.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
