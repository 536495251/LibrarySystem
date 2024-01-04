using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemVersion2
{
    public class Admin
    {
        public string AdminAccount { get; set; }
        public string AdminPassword { get; set; }
        public Admin(string AdminAccount, string AdminPassword)
        {
            this.AdminAccount = AdminAccount;
            this.AdminPassword = AdminPassword;
        }
        public Admin() { }

    }
}
