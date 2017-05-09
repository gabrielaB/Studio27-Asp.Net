using System.ComponentModel.DataAnnotations;


namespace Studio27SalonOfBeauty.Models.BindingModels
{
    public class SendMailBinding
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must provide your email."), EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string Subject { get; set; }

        [Required(ErrorMessage = "You must include a message.")]
        [DataType(DataType.Text)]
        [MaxLength(500)]
        [MinLength(20)]
        public string Message { get; set; }
    }
}
