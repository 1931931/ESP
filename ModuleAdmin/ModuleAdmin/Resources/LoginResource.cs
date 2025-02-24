using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuleAdmin.Model;
using ModuleAdmin.Data.Context;

namespace ModuleAdmin.Resources
{
    public class LoginResource
    {
        public static (bool loginOk, Admin? admin) LoginCheck(string courriel, string mdp, ModuleAdminContext context)
        {
            Admin? admin = context.Admin.FirstOrDefault(t => t.Courriel == courriel && t.Actif == true);


            if (admin != null)
            {
                //TODO : Enlever le comment quand je pourrai créer un compte
                //if (BCrypt.Net.BCrypt.Verify(mdp, admin.MotDePasse))
                    return (true, admin);
            }
            return (false, null);
        }
    }
}