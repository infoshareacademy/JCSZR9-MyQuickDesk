using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuickDesk.BussinessLogic
{
    class User
    {
        internal static string type;

        public string Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
    }
}
