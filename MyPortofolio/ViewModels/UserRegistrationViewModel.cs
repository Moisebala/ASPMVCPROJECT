using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MyPortofolio.Models;

namespace MyPortofolio.ViewModels
{
    public class UserRegistrationViewModel
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Please provide a username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please provide a password")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password minimum 8 caraters long")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Please provide a Fullname")]
        public string Fullname { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
    }
}