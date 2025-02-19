using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAdmin.Model
{
    public class Employe
    {
        public int Id { get; set; }
        public string IdHopital { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public bool Actif { get; set; }
        public bool DansStationnement { get; set; }

        public Employe() { }

        public Employe(string idHopital, string nom, string prenom, bool actif, bool dansStationnement)
        {
            IdHopital = idHopital;
            Nom = nom;
            Prenom = prenom;
            Actif = actif;
            DansStationnement = dansStationnement;

        }

    }
}
