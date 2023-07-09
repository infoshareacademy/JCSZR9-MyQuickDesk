namespace MyQuickDesk.DAL.ApplicationUser
{
    public class CurrentUser
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; }

        public CurrentUser(Guid id, string email, IEnumerable<string> roles)
        {
            Id = id;
            Email = email;
            Roles = roles;
        }

        public bool IsAdmin(string role) => Roles.Contains(role);
    }
}