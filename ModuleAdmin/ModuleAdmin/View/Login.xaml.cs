using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ModuleAdmin.ViewModel;
using Microsoft.EntityFrameworkCore;
using ModuleAdmin.Data.Context;
using ModuleAdmin.Model;


namespace ModuleAdmin.View
{
    /// <summary>
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private readonly ModuleAdminContext _context;
        new string[] _args;

        public Login()
        {
            InitializeComponent();
            ModuleAdminFactory factory = new ModuleAdminFactory();
            _context = factory.CreateDbContext(_args);
            DataContext = new LoginVM(_context);
        }

        private async void Connexion_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is LoginVM viewModel)
            {
                try
                {
                    Admin? admin = await viewModel.Login();

                    if (admin != null)
                        OuvrirPagePrincipale(admin);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("La connexion a échoué. Détails : " + ex.Message);
                }
            }
        }
        private void OuvrirPagePrincipale(Admin admin)
        {
            //PagePrincipale pagePrincipale = new PagePrincipale(_context, admin);
            PagePrincipale pagePrincipale = new PagePrincipale();
            pagePrincipale.Show();

            this.Hide();
        }

        private void PasswordBox(object sender, RoutedEventArgs e)
        {
            if (DataContext is LoginVM viewModel)
            {
                viewModel.Mdp = ((PasswordBox)sender).Password;
            }
        }

        private string _realPassword = string.Empty;

        private void PasswordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                int caretIndex = textBox.CaretIndex;

                if (textBox.Text.Length > _realPassword.Length)
                {
                    _realPassword += textBox.Text.Substring(_realPassword.Length);
                }
                else if (textBox.Text.Length < _realPassword.Length)
                {
                    _realPassword = _realPassword.Substring(0, textBox.Text.Length);
                }

                textBox.Text = new string('•', _realPassword.Length);
                textBox.CaretIndex = caretIndex;

                if (DataContext is LoginVM viewModel)
                {
                    viewModel.Mdp = _realPassword;
                }
            }
        }

    }
}
