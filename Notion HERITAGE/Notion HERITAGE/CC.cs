using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notion_HERITAGE
{
    internal class CC : Enseigant
    {
        public int Nbh { get; set; }
        public double PrixHeures{ get; set; }
        public CC(string nom, string prenom, string ddn, string cours, int nbh, double prixheure) : base(nom, prenom, ddn, cours)
        {
            Nbh = nbh;
            PrixHeures = prixheure;

        }

        public override bool Equals(object? obj)
        {
            
            CC cc = obj as CC; //return NULL
            if (cc == null) return false;
            return base.Equals(cc) && this.Nbh == cc.Nbh && this.PrixHeures == cc.PrixHeures;

        }
        public override string ToString()
        {
            return base.ToString() + "\n" + "Cours Enseigner : " + this.Cours + "\n" + "Nombres d'heures: " + this.Nbh + "\n" + "Salaire a l'heure "
            + this.PrixHeures + " $/h";                    ;
        }
        public override string CreerLogin()
        {
            return base.CreerLogin();
        }


    }
}
