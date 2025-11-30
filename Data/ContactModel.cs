using System.ComponentModel.DataAnnotations;		

namespace MyCvSite.Data
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Ism kiriting")]
        [StringLength(50, ErrorMessage = "Ism 50 ta belgidan oshmasligi kerak")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email kiriting")]
        [EmailAddress(ErrorMessage = "To'g'ri email manzil kiriting")]
        public string Email { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "Mavzu 100 ta belgidan oshmasligi kerak")]
        public string Subject { get; set; } = string.Empty;

        [Required(ErrorMessage = "Xabar matnini kiriting")]
        [StringLength(1000, ErrorMessage = "Xabar 1000 ta belgidan oshmasligi kerak")]
        public string Message { get; set; } = string.Empty;
    }
}
