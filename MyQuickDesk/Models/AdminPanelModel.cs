using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace MyQuickDesk.Models
{
    public class AdminPanelModel
    {
        public IdentityUser User { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public List<string> SelectedRoles { get; set; }
        public List<IdentityUser> Users { get; set; }
        public List<IdentityRole> Roles { get; set; }

        public Dictionary<string, List<string>> UserRoles { get; set; }
    }
}
