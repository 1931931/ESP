using ModuleAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ModuleAdmin.Data.Context;
using ModuleAdmin.Resources;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using Microsoft.AspNetCore.HttpsPolicy;
using CommunityToolkit.Mvvm.Input;

namespace ModuleAdmin.ViewModel
{
    public partial class LoginVM : ObservableObject
    {
        private readonly ModuleAdminContext _context;

        [ObservableProperty]
        private Admin _admin;

        [ObservableProperty]
        private bool _isLoading;

        [ObservableProperty]
        private string _errorMessage;

        [ObservableProperty]
        private string _courriel;

        [ObservableProperty]
        private string _mdp;

        public LoginVM(ModuleAdminContext context)
        {
            _context = context;
            _admin = new Admin();
            _errorMessage = "";

        }

        public async Task<Admin?> Login()
        {
            Admin admin;

            if (string.IsNullOrEmpty(Courriel) || string.IsNullOrEmpty(Mdp))
            {
                ErrorMessage = "Les champs doivent tous être remplis.";
            }
            else
            {
                IsLoading = true;
                ErrorMessage = string.Empty;

                try
                {
                    var (loginOk, adminConnecte) = await Task.Run(() => LoginResource.LoginCheck(Courriel, Mdp, _context));

                    if (loginOk && adminConnecte != null)
                    {
                        _admin = adminConnecte;

                        admin = adminConnecte;
                         
                        return admin;
                    }
                    else
                    {
                        ErrorMessage = "Identifiants incorrects ou compte inactif.";

                    }
                }
                catch
                {
                    ErrorMessage = "Une erreur s'est produite lors de la connexion.";
                }
                finally
                {
                    IsLoading = false;
                }
            }

            return null;
        }
    }
}
