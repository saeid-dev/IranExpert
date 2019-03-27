using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IranExpert.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required (ErrorMessageResourceType = typeof(Resources.ValidationResource),ErrorMessageResourceName = "EmailRequiredValidation")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessageResourceType = typeof(Resources.ValidationResource), ErrorMessageResourceName = "EmailFormatValidation")]
        public string Email { get; set; }

        [Required (ErrorMessageResourceType = typeof(Resources.ValidationResource), ErrorMessageResourceName = "PasswordRequiredValidation")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Resources.ValidationResource), ErrorMessageResourceName = "EmailRequiredValidation")]
        [EmailAddress(ErrorMessageResourceType = typeof(Resources.ValidationResource), ErrorMessageResourceName = "EmailFormatValidation")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.ValidationResource), ErrorMessageResourceName = "PasswordRequiredValidation")]
        [StringLength(100, ErrorMessageResourceType = typeof(Resources.ValidationResource), ErrorMessageResourceName = "PasswordFormatValidation")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password",ErrorMessageResourceType = typeof(Resources.ValidationResource), ErrorMessageResourceName = "PasswordAndConfirmation")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessageResourceType = typeof(Resources.ValidationResource), ErrorMessageResourceName = "PasswordFormatValidation")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessageResourceType = typeof(Resources.ValidationResource), ErrorMessageResourceName = "PasswordAndConfirmation")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}