using Microsoft.AspNetCore.Identity;

namespace ENG_learning_website.Models
{
    public class AplicationUser: IdentityUser
    {
        public bool Subscription { get; set; }

    }
}
