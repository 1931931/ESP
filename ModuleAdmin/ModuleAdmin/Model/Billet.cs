using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAdmin.Model
{
    public class Billet
    {
        public int Id { get; set; }
        public DateTime HeureEntree { get; set; }
        public DateTime HeurePaiement { get; set; }
        public bool PatientParti { get; set; }
        public int TarifId { get; set; }
        public Tarif ? Tarif { get; set; }
        public double SommePayee { get; set; }
        public double TaxesPayees { get; set; }
        public int NiveauTarif { get; set; }

        public Billet()
        {

        }
        public Billet(DateTime heureEntree, DateTime heurePaiement, bool patientParti, Tarif tarif, double sommePayee, double taxesPayees, int niveauTarif)
        {
            HeureEntree = heureEntree;
            HeurePaiement = heurePaiement;
            PatientParti = patientParti;
            Tarif = tarif;
            SommePayee = sommePayee;
            TaxesPayees = taxesPayees;
            NiveauTarif = niveauTarif;
        }
    }
}
