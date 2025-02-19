using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAdmin.Model
{
    public class Tarif
    {
        public int Id { get; set; }
        public double TPS { get; set; }
        public double TVQ { get; set; }
        public double TarifHoraire { get; set; }
        public double TarifDemiJour { get; set; }
        public double TarifPleinJour { get; set; }
        public bool Actif { get; set; }

        public Tarif()
        {

        }

        public Tarif(double tPS, double tVQ, double tarifHoraire, double tarifDemiJour, double tarifPleinJour)
        {
            TPS = tPS;
            TVQ = tVQ;
            TarifHoraire = tarifHoraire;
            TarifDemiJour = tarifDemiJour;
            TarifPleinJour = tarifPleinJour;
            Actif = true;
        }
    }
}
