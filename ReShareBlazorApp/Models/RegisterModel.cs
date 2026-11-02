using System.ComponentModel.DataAnnotations;

namespace ReShareBlazorApp.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Podaj nazwe użytownika.")]
        [MinLength(8, ErrorMessage = "Nazwa uzytkownika musi miec minimum 8 znakow.")]
        [MaxLength(24,ErrorMessage =" Nazwa użytkownika nie moze miec wiecej niż 24 znaki")]
        public string Username { get; set; } = "";
        [Required(ErrorMessage = "Podaj adres email!")]
        [EmailAddress(ErrorMessage = "Nieprawidłowy adres e-mail.")]
        public string Email { get; set; } = "";
        [Required(ErrorMessage = "Podaj hasło.")]
        [MinLength(8,ErrorMessage ="Hasło musi miec minimum 8 znakow.")]
        public string Password { get; set; } = "";
        [Required(ErrorMessage = "Potwierdź hasło.")]
        [Compare(nameof(Password),ErrorMessage = "Hasła nie są identyczne")]
        public string ConfirmPassword { get; set; } = "";
        [Range(typeof(bool),"true","true", ErrorMessage = "Musisz zaakceptwac regulamin.")]
        public bool AcceptTerms { get; set; } 

    }
}
