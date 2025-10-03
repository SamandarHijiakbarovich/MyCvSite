using System.ComponentModel.DataAnnotations;		

namespace MyCvSite.Data
{
public class ContactModel
{
[Required(ErrorMessage = "Ismingizni kiritish shart.")]
public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email manzilini kiritish shart.")]
    [EmailAddress(ErrorMessage = "Yaroqli email manzilini kiriting.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Xabar matnini kiritish shart.")]
    [StringLength(500, MinimumLength = 10, ErrorMessage = "Xabar 10 dan 500 belgiga ega bo'lishi kerak.")]
    public string Message { get; set; } = string.Empty;
}
}