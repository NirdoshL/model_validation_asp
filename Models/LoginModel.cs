using System.ComponentModel.DataAnnotations;
public class LoginModel{
    [Required(ErrorMessage="Name field is required.")]
    [StringLength(12,MinimumLength =3,ErrorMessage ="UserName Should have 3-12 chars.")]
    [Display(Name = "Your Name")]
    public String? UserName {get;set;}
    [Required(ErrorMessage="Email field is required.")]
    [EmailAddress(ErrorMessage ="Invalid Email Address.")]
    [Display(Name = "Your Email")]
    public String? Email {get;set;}
    [Required(ErrorMessage="Password field is required.")]
    [StringLength(100,MinimumLength =8,ErrorMessage ="Password Must be between 8-100 characters")]
    [Display(Name = "Password")]
    public String? Password {get;set;}
}