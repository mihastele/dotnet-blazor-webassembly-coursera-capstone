using System.ComponentModel.DataAnnotations;

namespace BlazorIndependetWebAssemblyNoAndroid.Models
{
    public class RegistrationModel
    {
        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
    }
}
