using System.ComponentModel.DataAnnotations;

namespace Studio27SalonOfBeauty.Models.ViewModels.AccountViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
