using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    class UserProfile
    {
        #region Fields
        //private string password; // just don't...
        #endregion

        #region Props
        public string UserName { get; private set; }
        public string Email { get; private set; }
        private protected string Password { get; set; } // I must be violating some convention with this.
        #endregion

        #region Constructor
        public UserProfile(string userName, string email = null, string password = "admin1234")
        {
            UserName = userName.Replace(" ", "");
            if (email is null)
            {
                Email = $"{UserName}@this_is_a_real_company.com";
            } else
            {
                Email = email;
            }
            Password = password;
        }

        #endregion

        #region Methods
        public bool SetPassword(string oldPassWord, string newPassword)
        {
            if (oldPassWord == Password && !(newPassword is null))
            {
                Password = newPassword;
                return true;
            } else
            {
                return false;
            }
        }

        public void SetEmail(string newEmail)
        {
            Email = newEmail;
        }

        public override string ToString()
        {
            return $"{UserName} {Email}";
        }
        #endregion
    }
}
