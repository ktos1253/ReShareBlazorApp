using Microsoft.AspNetCore.Identity;

namespace ReShareBlazorApp.Date
{
    public class User : IdentityUser<int>
    {

        public DateTime CreateAt { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
    }
}
