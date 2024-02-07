using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notion_HERITAGE
{
    internal class Permanent : Enseigant
    {

        public double SalaireQ2S { get; set; }
        public Permanent(string nom, string prenom, string ddn, string cours,double salaireq2s) : base(nom, prenom, ddn, cours)
        {
           SalaireQ2S = salaireq2s;

        }

        public override bool Equals(object? obj)
        {
            /*
            if (obj == null) return false;
            //
            Enseigant es = (Enseigant)obj;
            //
            if (!(obj is Enseigant)) { return false; }

            */
            Permanent tp = obj as Permanent; //return NULL
            if (tp == null) return false;
            return base.Equals(tp) && this.SalaireQ2S == tp.SalaireQ2S;

        }
        public override string ToString()
        {
            return base.ToString() + "\n" + "Cours Enseigner : " + this.Cours + "\n" + "\n" + "Salaire bi-mensuels "
            + this.SalaireQ2S + " $"; 
        }
        public override string CreerLogin()
        {
            return base.CreerLogin();
        }

    }
}
