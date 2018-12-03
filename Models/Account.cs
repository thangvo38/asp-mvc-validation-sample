using System;
using System.ComponentModel.DataAnnotations;

namespace MvcTest.Models
{
    public class Account
    {
        [Required]
        [MinLength(3)]
        [MaxLength(6)]
        public string Username {get; set;}

        [Required]
        [MinLength(6)]
        [MaxLength(6)]
        public string Password {get; set;}

        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email {get; set;}
        
    }
}