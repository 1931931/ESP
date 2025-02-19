using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAdmin.Model
{
    public class TarifDynamique
    {
        public int Id { get; set; }
        public int JourDebut { get; set; }
        public int HeureDebut { get; set; }
        public int JourFin { get; set; }
        public int HeureFin { get; set; }
        public int TarifId { get; set; }
        public Tarif? Tarif { get; set; }
        public bool AncreHoraire { get; set; }
        public bool AncreDemiJour { get; set; }
        public bool AncrePleinJour { get; set; }

        public TarifDynamique()
        {

        }
        public TarifDynamique(int jourDebut, int heureDebut, int jourFin, int heureFin, Tarif tarif, bool ancreHoraire, bool ancreDemiJour, bool ancrePleinJour)
        {
            JourDebut = jourDebut;
            HeureDebut = heureDebut;
            JourFin = jourFin;
            HeureFin = heureFin;
            Tarif = tarif;
            AncreHoraire = ancreHoraire;
            AncreDemiJour = ancreDemiJour;
            AncrePleinJour = ancrePleinJour;

        }
    }

}
