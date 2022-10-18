using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtApp.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {


            new UserModel() { Username = "irem", Password = "12345", Role = "Avukat" },
            new UserModel() { Username = "berkay", Password = "MyPass_w0rd", Role = "TBBKullanicisi" },
            new UserModel() { Username = "hussain", Password = "MyPass_w0rd", Role = "Stajyer" }
         };
       }
}

// {"Username":"berkay", "Password":"MyPass_w0rd"}