using Microsoft.AspNetCore.Identity;

namespace MyQuickDesk.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }
    }

}
