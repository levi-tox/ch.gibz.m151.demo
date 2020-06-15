using System.ComponentModel.DataAnnotations;

namespace ch.gibz.m151.demo.api.Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}