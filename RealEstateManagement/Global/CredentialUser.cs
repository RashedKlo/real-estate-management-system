using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagement.Global
{
   
  public  class CredentialUser
    {
        public string password { get; set; }
        public string userName { get; set; }
        public bool IsRememberMe { get; set; }
        public CredentialUser()
        {
            this.password = string.Empty;
            this.userName = string.Empty;
            this.IsRememberMe = false;
        }
        public CredentialUser(string userName,string password,bool remmeberme)
        {
            this.userName = userName;
            this.password = password;
            this.IsRememberMe = remmeberme;
        }

    }
}
