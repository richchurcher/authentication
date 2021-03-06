using Microsoft.AspNetCore.Identity;

namespace Codidact.Authentication.Domain.Entities
{
    public class ApplicationUser : IdentityUser<long>
    {
        public string DisplayName { get; set; }
    }
}
