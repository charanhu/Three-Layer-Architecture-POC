using System.Collections.Generic;
using System.Data;

namespace DataAccessLayer
{
    //#regionClass    
    public class UserProvider
    {
        public static DataTable CheckUserDetails(string username, string password)
        { 
            Dictionary<string, string> UserDictionary = new Dictionary<string, string>();
            UserDictionary.Add("@userName", username);
            UserDictionary.Add("@password", password);
            return SqlHelper.GetTableFromSP("sp_CheckUserDetails", UserDictionary);      
       }        
    }
    //endregion
}
