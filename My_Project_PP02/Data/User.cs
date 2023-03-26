using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Project_PP02.Data
{   
    public static class ProgramData
    {
        public static string AdminCode = "0000";
    }


    public static class User
    {
        public static int UserID;
        public static string UserLogin;
        public static string UserPassword;
        public static Roles Role = Roles.Client;
        public static  int RoleID;

    }

    public enum Roles
    {
        Admin = 0,
        Client = 1,
        Client2 = 2
    }
}
