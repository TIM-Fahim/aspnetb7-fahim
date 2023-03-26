using Microsoft.AspNetCore.Identity;
using System;

namespace School.Infrastructure.BusinessObjects
{
    public class ApplicationUser 
    {
        public Guid ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
