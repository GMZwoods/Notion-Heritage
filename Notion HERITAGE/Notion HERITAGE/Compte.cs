using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_et_compte
{
    public class Compte
    {
       
        
            public double Solde { get; set; }
            public int Code { get; set; }
            public Client Titutlaire { get; set; }  // Type 
        
        public Compte(double solde , int code, Client titulaire)  
        {
            Solde = solde;
            Code = code;    
            Titutlaire = titulaire;
        
        }
        //methode pour augmenter le solde nommé credit 
        public void Credit(double montant) 
        {
            Solde += montant;// vérifier que le montant est positif 
        }
        public void Credit(double montant, Compte compte) // surchage 
        {
            //crediter compte
            Credit(montant);
            compte.debit(montant);

        }


        // methode debit pour diminu le solde 
        public void debit (double montant) { Solde -= montant; }
        public void debit(double montant, Compte compte) 
        {
            debit(montant); 
            compte.Credit(montant);
        }
        public void Afficher()
        {   Console.WriteLine("Votre Solde"+Solde);
            Console.WriteLine("Votre code" +Code);
            Console.WriteLine("");

        }

    }
}
