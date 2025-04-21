﻿using System.ComponentModel.DataAnnotations;

namespace Hospital.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email adress is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
