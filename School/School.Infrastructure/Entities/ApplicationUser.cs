using Microsoft.AspNetCore.Identity;
using System;

namespace School.Infrastructure.Entities
{
    public class ApplicationUser : IEntity<Guid>
    {
        public Guid ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
