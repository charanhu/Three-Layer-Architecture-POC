using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class User
    {
        public string UserName{ get; set;}
        public string Password{ get; set;}

        public bool checkUserDetails()
        {
            DataTable dt = UserProvider.CheckUserDetails(UserName, Password);
            return (Convert.ToUInt32(dt.Rows[0]["UserCount"]) > 0);
        }
    }
}
