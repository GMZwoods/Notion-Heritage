using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Notion_HERITAGE
{
    internal class Enseigant : Personne 
    {
        public string Cours { get; set; }

        public Enseigant(string nom, string prenom, string ddn, string cours) : base (nom,prenom ,ddn)
        {
            Cours = cours;

        }

        // // Redefinition de la methodes Equals() AKA POLYMORPHISME 
        /// <summary>
        /// 1. OBJ FDOIT ETRE NON NULL 2. //OBJ DOIT ETRE DE MEME TYPE QUE LA CLASSE (Cast) 3. // IMPLEMENTER LE CRITERES DEGALITE 
        /// Peut cause le lancement dexception.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            /*
            if (obj == null) return false;
            //
            Enseigant es = (Enseigant)obj;
            //
            if (!(obj is Enseigant)) { return false; }

            */
            Enseigant es = obj as Enseigant; //return NULL
            if (es == null) return false;


            return base.Equals(es) && this.Cours == es.Cours;

        }
        public override string ToString()
        {
            return base.ToString()+ "\n" + "Cours Enseigner : " + this.Cours + "\n";
        }
        public override string CreerLogin()
        {
            return base.CreerLogin() + Cours[0];
        }
    }
}
