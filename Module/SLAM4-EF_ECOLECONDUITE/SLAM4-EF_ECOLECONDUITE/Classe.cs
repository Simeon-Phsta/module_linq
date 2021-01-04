using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAM4_EF_ECOLECONDUITE
{
    public partial class LECON
    {
        private string commentaire;

        public string Commentaire { get => commentaire; set => commentaire = value; }

        public LECON(){}

        public LECON(string id, DateTime date, int heure, int duree, ELEVE el, VEHICULE ve)
        {
            this.id = id;
            this.dateLecon = date;
            this.heure = heure;
            this.duree = duree;
            this.effectueeO_N = false;
            this.unEleve = el;
            this.unVehicule = ve;
        }

        public void setEffectuee()
        {
            if (DateTime.Now > this.dateLecon)
            {
                this.effectueeO_N = true;
                this.unEleve.creditHoraire -= this.duree;
            }
        }
    }
}
