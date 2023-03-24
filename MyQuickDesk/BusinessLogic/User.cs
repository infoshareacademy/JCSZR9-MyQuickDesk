using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuickDesk.BussinessLogic
{
    public class User
    {
        [Name("Id")]
        public string Id { get; set; }

        [Name("Login")]
        public string Login { get; set; }

        [Name("Password")]
        public string Password { get; set; }

        [Name("Type")]
        public string Type { get; set; }
    }


}
