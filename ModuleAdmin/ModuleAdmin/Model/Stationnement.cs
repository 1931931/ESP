using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAdmin.Model
{
    public class Stationnement
    {
        public int Id { get; set; }
        public int NbPlaces { get; set; }
        public Stationnement() { }
        public Stationnement(int nbPlaces)
        {
            NbPlaces = nbPlaces;
        }
    }
}
