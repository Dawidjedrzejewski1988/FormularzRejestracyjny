using System.ComponentModel.DataAnnotations;

public class Dane
{
    [Required(ErrorMessage = "Proszę podaj Imię")]
    [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki")]
    public string Imie { get; set; }

    [Required(ErrorMessage = "Proszę podaj Nazwisko")]
    [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki")]
    public string Nazwisko { get; set; }

    [Required(ErrorMessage = "Proszę podaj Email")]
    [EmailAddress(ErrorMessage = "Niepoprawny adres email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Proszę podaj Hasło")]
    [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Hasło musi zawierać co najmniej jedną dużą literę, małą literę oraz cyfrę")]
    public string Haslo { get; set; }

    [Compare("Haslo", ErrorMessage = "Hasła muszą się zgadzać")]
    public string PotwierdzenieHasla { get; set; }

    [Phone(ErrorMessage = "Niepoprawny numer telefonu")]
    public string NrTelefonu { get; set; }

    [Range(10, 80, ErrorMessage = "Wiek musi być w przedziale 10-80 lat")]
    public int Wiek { get; set; }

    [Required(ErrorMessage = "Proszę wybierz miasto")]
    public string Miasto { get; set; }
}
