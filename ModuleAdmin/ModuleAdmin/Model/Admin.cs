using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAdmin.Model
{
    public class Admin
    {
        public int Id { get; set; }
        public string IdHopital { get; set; }
        public string Courriel { get; set; }
        public string MotDePasse { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public bool Actif { get; set; }
        public bool DansStationnement { get; set; }

        public Admin() { }
        public Admin(string idHopital, string courriel, string motDePasse, string nom, string prenom)
        {
            Id = 0;
            IdHopital = idHopital;
            Courriel = courriel;
            MotDePasse = motDePasse;
            Nom = nom;
            Prenom = prenom;
            Actif = true;
            DansStationnement = false;
        }
    }
}
