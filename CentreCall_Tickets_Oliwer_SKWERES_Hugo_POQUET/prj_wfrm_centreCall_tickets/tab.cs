using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_wfrm_centreCall_tickets
{
    class tab
    {
        //=========== Structure et tableau des centres d'appel ======================
        public struct sCentreAppel
        {
            public int numero;             //n° du centre d'appel
            public string ville;           //ville
        }

        public static sCentreAppel[] centreAppel = new sCentreAppel[10];
        public static int nbCentresAppel;

        //=========== Structure et tableau des codes NAF ======================
        public struct sCodeNaf
        {
            public int code;                //code NAF
            public string intitule;         //intitulé de l'activité
        }

        public static sCodeNaf[] codeNaf = new sCodeNaf[100];
        public static int nbCodesNaf;

        //=========== Structure et tableau des techniciens ======================
        public struct sTech
        {
            public int numero;              //numéro du technicien
            public string nom;              //nom du technicien
            public string prenom;           //prenom du technicien
            public Single tauxHoraire;      //taux horaire du technicien
        }

        public static sTech[] tech = new sTech[20];
        public static int nbTech;

        //=========== Structure et tableau des clients ======================
        public struct sClient
        {
            public int numero;             //n° du client
            public string raisonSociale;   //raison sociale
            public int centreAppel;        //n° du centre d'appel
            public int codeNaf;            //code NAF
            public DateTime dateContrat;   //date de signature du contrat
            public int duree;              //durée du contrat en nombre de mois
            public Single montantContrat;  //montant du contrat
            public Single montantTickets;  //montant des tickets d'intervention
        }

        public static sClient[] client = new sClient[50];
        public static int nbClients;

        //=========== Structure et tableau des tickets ======================
        public struct sTicket
        {
            public int numero;                  //n° du ticket
            public DateTime dateOuverture;      //date d'ouverture du ticket
            public int numClient;               //n° du client
            public string objet;                //objet du ticket
            public Boolean cloture;             //ticket clôturé ? true ou false
            public DateTime dateCloture;        //date de clôture si ticket clôturé
            public Single nbHeures;             //nombre d'heures facturées
            public int numTech;                 //n° du technicien ayant pris en charge le ticket
        }

        public static sTicket[] ticket = new sTicket[50];
        public static int nbTickets;
    }
}
