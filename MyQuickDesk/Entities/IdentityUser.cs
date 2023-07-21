using Microsoft.AspNetCore.Identity;


namespace MyQuickDesk.Entities
{
    public class IdentityUser
    {
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }
    }

}
