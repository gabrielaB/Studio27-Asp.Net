using System.ComponentModel.DataAnnotations;

namespace Studio27SalonOfBeauty.Models.ViewModels.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Microsoft.Build.Framework.Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
