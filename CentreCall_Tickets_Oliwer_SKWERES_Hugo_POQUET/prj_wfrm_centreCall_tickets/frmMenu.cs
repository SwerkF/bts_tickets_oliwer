using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prj_wfrm_centreCall_tickets
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        string repertoireFichiers = "../../../fichiers/";

        //====================== GESTION DES CLIENTS =================================================

        // Chargement des données
        // Retour d'un message avec le nombre de clients chargés dans le tableau
        private string chargerTableauClient()
        {
            try
            {
                //Chargement ddu fichier dans le tableau associé
                Stream nomFichier = new FileStream(repertoireFichiers + "client.csv", FileMode.Open);
                StreamReader fichier = new StreamReader(nomFichier, Encoding.GetEncoding(1252));
                //lecture 1ère ligne du fichier sans stocker les données : ligne des titres
                string ligne = fichier.ReadLine();

                //on démarre à l'indice 0 du tableau pour stocker les données
                int i = 0;
                //lecture des lignes du fichier jusqu'à ce qu'on trouve la fin de fichier
                while (!fichier.EndOfStream)
                {
                    //la ligne du fichier est placée dans une chaine de caractères
                    ligne = fichier.ReadLine();
                    //on extrait chaque information en utilisant le séparateur ;
                    //chaque information est placée dans le tableau colonnes
                    string[] colonnes = ligne.Split(';');
                    //8 colonnes numérotées de 0 à 7 pour le fichier client
                    tab.client[i].numero = int.Parse(colonnes[0]);
                    tab.client[i].raisonSociale = colonnes[1];
                    tab.client[i].centreAppel = int.Parse(colonnes[2]);
                    tab.client[i].codeNaf = int.Parse(colonnes[3]);
                    tab.client[i].dateContrat = DateTime.Parse(colonnes[4]);
                    tab.client[i].duree = int.Parse(colonnes[5]);
                    tab.client[i].montantContrat = Single.Parse(colonnes[6]);
                    tab.client[i].montantTickets = Single.Parse(colonnes[7]);

                    //ligne suivante 
                    i++;
                }
                //fermeture du fichier
                fichier.Close();
                tab.nbClients = i;
                return tab.nbClients + " clients ont été chargés.";
            }
            catch
            {
                MessageBox.Show("Erreur dans le chargement des clients", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        // Sauvegarde des données
        // Retour d'un message avec le nombre de clients enregistrés dans le fichier
        private string sauverTableauClient()
        {
            try
            {
                //Export du tableau dans le fichier
                Stream nomFichier = new FileStream(repertoireFichiers + "client.csv", FileMode.Create);
                StreamWriter fichier = new StreamWriter(nomFichier, Encoding.GetEncoding(1252));
                //écriture 1ère ligne du fichier : ligne des titres
                string ligne = "N°client;RaisonSociale;centreAppel;codeNAF;DateContrat;DureeMois;MontantContrat;MontantTickets";
                fichier.WriteLine(ligne);

                //boucle de lecture des données technicien
                for (int i = 0; i < tab.nbClients; i++)
                {
                    //formatage de la ligne
                    ligne = tab.client[i].numero
                          + ";" + tab.client[i].raisonSociale
                          + ";" + tab.client[i].centreAppel 
                          + ";" + tab.client[i].codeNaf
                          + ";" + tab.client[i].dateContrat.ToShortDateString()
                          + ";" + tab.client[i].duree
                          + ";" + tab.client[i].montantContrat
                          + ";" + tab.client[i].montantTickets;

                    //écriture de la ligne dans le fichier
                    fichier.WriteLine(ligne);
                }
                //fermeture du fichier
                fichier.Close();
                return tab.nbClients + " clients ont été sauvegardés.";
            }
            catch
            {
                MessageBox.Show("Erreur dans la sauvegarde des clients", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        //====================== GESTION DES CENTRES D'APPEL =================================================
        // Chargement des données
        // Retour d'un message avec le nombre de centres d'appels chargés dans le tableau
        private string chargerTableauCentreAppel()
        {
            try
            {
                //Chargement du fichier dans le tableau associé
                Stream nomFichier = new FileStream(repertoireFichiers + "centreAppel.csv", FileMode.Open);
                StreamReader fichier = new StreamReader(nomFichier, Encoding.GetEncoding(1252));
                //lecture 1ère ligne du fichier sans stocker les données : ligne des titres
                string ligne = fichier.ReadLine();

                //on démarre à l'indice 0 du tableau pour stocker les données
                int i = 0;
                //lecture des lignes du fichier jusqu'à ce qu'on trouve la fin de fichier
                while (!fichier.EndOfStream)
                {
                    //la ligne du fichier est placée dans une chaine de caractères
                    ligne = fichier.ReadLine();
                    //on extrait chaque information en utilisant le séparateur ;
                    //chaque information est placée dans le tableau colonnes
                    string[] colonnes = ligne.Split(';');
                    //2 colonnes numérotées de 0 à 1 pour le fichier centre appel
                    tab.centreAppel[i].numero = int.Parse(colonnes[0]);
                    tab.centreAppel[i].ville = colonnes[1];

                    //ligne suivante
                    i++;
                }
                //fermeture du fichier
                fichier.Close();
                tab.nbCentresAppel = i;
                return tab.nbCentresAppel + " centres d'appels ont été chargés.";
            }
            catch
            {
                MessageBox.Show("Erreur dans le chargement des clients", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        // Sauvegarde des données
        // Retour d'un message avec le nombre de centre d'appels enregistrés dans le fichier
        private string sauverTableauCentreAppel()
        {
            try
            {
                //Export du tableau dans le fichier
                Stream nomFichier = new FileStream(repertoireFichiers + "centreAppel.csv", FileMode.Create);
                StreamWriter fichier = new StreamWriter(nomFichier, Encoding.GetEncoding(1252));
                //écriture 1ère ligne du fichier : ligne des titres
                string ligne = "numCentre;Ville";
                fichier.WriteLine(ligne);

                //boucle de lecture des données technicien
                for (int i = 0; i < tab.nbCentresAppel; i++)
                {
                    //formatage de la ligne
                    ligne = tab.centreAppel[i].numero
                          + ";" + tab.centreAppel[i].ville;

                    //écriture de la ligne dans le fichier
                    fichier.WriteLine(ligne);
                }
                //fermeture du fichier
                fichier.Close();
                return tab.nbCentresAppel + " centres d'appels ont été sauvegardés.";
            }
            catch
            {
                MessageBox.Show("Erreur dans la sauvegarde des centres d'appels", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        //====================== GESTION DES CODES NAF =================================================
        // Chargement des données
        // Retour d'un message avec le nombre de codes NAF chargés dans le tableau
        private string chargerTableauCodeNaf()
        {
            try
            {
                //Chargement du fichier dans le tableau associé
                Stream nomFichier = new FileStream(repertoireFichiers + "codeNaf.csv", FileMode.Open);
                StreamReader fichier = new StreamReader(nomFichier, Encoding.GetEncoding(1252));
                //lecture 1ère ligne du fichier sans stocker les données : ligne des titres
                string ligne = fichier.ReadLine();

                //on démarre à l'indice 0 du tableau pour stocker les données
                int i = 0;
                //lecture des lignes du fichier jusqu'à ce qu'on trouve la fin de fichier
                while (!fichier.EndOfStream)
                {
                    //la ligne du fichier est placée dans une chaine de caractères
                    ligne = fichier.ReadLine();
                    //on extrait chaque information en utilisant le séparateur ;
                    //chaque information est placée dans le tableau colonnes
                    string[] colonnes = ligne.Split(';');
                    //2 colonnes numérotées de 0 à 1 pour le fichier code Naf
                    tab.codeNaf[i].code = int.Parse(colonnes[0]);
                    tab.codeNaf[i].intitule = colonnes[1];

                    //ligne suivante
                    i++;
                }
                //fermeture du fichier
                fichier.Close();
                tab.nbCodesNaf = i;
                return tab.nbCodesNaf + " codes NAF ont été chargés.";
            }
            catch
            {
                MessageBox.Show("Erreur dans le chargement des codes NAF", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        // Sauvegarde des données
        // Retour d'un message avec le nombre de codes NAF enregistrés dans le fichier
        private string sauverTableauCodeNaf()
        {
            try
            {
                //Export du tableau dans le fichier
                Stream nomFichier = new FileStream(repertoireFichiers + "codeNaf.csv", FileMode.Create);
                StreamWriter fichier = new StreamWriter(nomFichier, Encoding.GetEncoding(1252));
                //écriture 1ère ligne du fichier : ligne des titres
                string ligne = "Code NAF;Intitulé";
                fichier.WriteLine(ligne);

                //boucle de lecture des données technicien
                for (int i = 0; i < tab.nbCodesNaf; i++)
                {
                    //formatage de la ligne
                    ligne = tab.codeNaf[i].code
                          + ";" + tab.codeNaf[i].intitule;

                    //écriture de la ligne dans le fichier
                    fichier.WriteLine(ligne);
                }
                //fermeture du fichier
                fichier.Close();
                return tab.nbCodesNaf + " codes NAF ont été sauvegardés.";
            }
            catch
            {
                MessageBox.Show("Erreur dans la sauvegarde des codes NAF", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        //====================== GESTION DES TECHNICIENS =================================================
        // Chargement des données
        // Retour d'un message avec le nombre de techniciens chargés dans le tableau
        private string chargerTableauTechnicien()
        {
            try
            {
                //Chargement du fichier dans le tableau associé
                Stream nomFichier = new FileStream(repertoireFichiers + "technicien.csv", FileMode.Open);
                StreamReader fichier = new StreamReader(nomFichier, Encoding.GetEncoding(1252));
                //lecture 1ère ligne du fichier sans stocker les données : ligne des titres
                string ligne = fichier.ReadLine();

                //on démarre à l'indice 0 du tableau pour stocker les données
                int i = 0;
                //lecture des lignes du fichier jusqu'à ce qu'on trouve la fin de fichier
                while (!fichier.EndOfStream)
                {
                    //la ligne du fichier est placée dans une chaine de caractères
                    ligne = fichier.ReadLine();
                    //on extrait chaque information en utilisant le séparateur ;
                    //chaque information est placée dans le tableau colonnes
                    string[] colonnes = ligne.Split(';');
                    //2 colonnes numérotées de 0 à 3 pour le fichier technicien
                    tab.tech[i].numero = int.Parse(colonnes[0]);
                    tab.tech[i].nom = colonnes[1];
                    tab.tech[i].prenom = colonnes[2];
                    tab.tech[i].tauxHoraire = Single.Parse(colonnes[3]);

                    //ligne suivante
                    i++;
                }
                //fermeture du fichier
                fichier.Close();
                tab.nbTech = i;
                return tab.nbTech + " techniciens ont été chargés.";
            }
            catch
            {
                MessageBox.Show("Erreur dans le chargement des techniciens", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        // Sauvegarde des données
        // Retour d'un message avec le nombre de techniciens enregistrés dans le fichier
        private string sauverTableauTechnicien()
        {
            try
            {
                //Export du tableau dans le fichier
                Stream nomFichier = new FileStream(repertoireFichiers + "technicien.csv", FileMode.Create);
                StreamWriter fichier = new StreamWriter(nomFichier, Encoding.GetEncoding(1252));
                //écriture 1ère ligne du fichier : ligne des titres
                string ligne = "numéro;nom;prénom;taux horaire";
                fichier.WriteLine(ligne);

                //boucle de lecture des données technicien
                for (int i = 0; i < tab.nbTech; i++)
                {
                    //formatage de la ligne
                    ligne = tab.tech[i].numero 
                          + ";" + tab.tech[i].nom 
                          + ";" + tab.tech[i].prenom 
                          + ";" + tab.tech[i].tauxHoraire ;

                    //écriture de la ligne dans le fichier
                    fichier.WriteLine(ligne);
                }
                //fermeture du fichier
                fichier.Close();
                return tab.nbTech + " techniciens ont été sauvegardés.";
            }
            catch
            {
                MessageBox.Show("Erreur dans la sauvegarde des techniciens", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        //====================== GESTION DES TICKETS D'INTERVENTION=================================================
        // Chargement des données
        // Retour d'un message avec le nombre de tickets chargés dans le tableau
        private string chargerTableauTicket()
        {
            try
            {
                //Chargement du fichier dans le tableau associé
                Stream nomFichier = new FileStream(repertoireFichiers + "ticket.csv", FileMode.Open);
                StreamReader fichier = new StreamReader(nomFichier, Encoding.GetEncoding(1252));
                //lecture 1ère ligne du fichier sans stocker les données : ligne des titres
                string ligne = fichier.ReadLine();

                //on démarre à l'indice 0 du tableau pour stocker les données
                int i = 0;
                //lecture des lignes du fichier jusqu'à ce qu'on trouve la fin de fichier
                while (!fichier.EndOfStream)
                {
                    //la ligne du fichier est placée dans une chaine de caractères
                    ligne = fichier.ReadLine();
                    //on extrait chaque information en utilisant le séparateur ;
                    //chaque information est placée dans le tableau colonnes
                    string[] colonnes = ligne.Split(';');
                    //2 colonnes numérotées de 0 à 8 pour le fichier ticket
                    tab.ticket[i].numero = int.Parse(colonnes[0]);
                    tab.ticket[i].dateOuverture = DateTime.Parse(colonnes[1]);
                    tab.ticket[i].numClient = int.Parse(colonnes[2]);
                    tab.ticket[i].objet = colonnes[3];

                    //--> si le ticket est clôturé, on charge un booléen 
                    // + date de clôture, nombre d'heures de l'intervention 
                    //et technicien ayant pris en charge l'intervention
                    // --> Sinon date, nombre et technicien prennent la MinValue
                    if (colonnes[4].ToUpper() == "OUI")
                    {
                        tab.ticket[i].cloture = true;
                        tab.ticket[i].dateCloture = DateTime.Parse(colonnes[5]);
                        tab.ticket[i].nbHeures = Single.Parse(colonnes[6]);
                        tab.ticket[i].numTech = int.Parse(colonnes[7]);
                    }
                    else
                    {
                        tab.ticket[i].cloture = false;
                        tab.ticket[i].dateCloture = DateTime.MinValue;
                        tab.ticket[i].nbHeures = Single.MinValue;
                        tab.ticket[i].numTech = int.MinValue;
                    }
                    
                    //ligne suivante
                    i++;
                }
                //fermeture du fichier
                fichier.Close();
                tab.nbTickets = i;
                return tab.nbTickets + " tickets d'intervention ont été chargés.";
            }
            catch
            {
                MessageBox.Show("Erreur dans le chargement des tickets d'intervention", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        // Sauvegarde des données
        // Retour d'un message avec le nombre de tickets enregistrés dans le fichier
        private string sauverTableauTicket()
        {
            try
            {
                //Export du tableau dans le fichier
                Stream nomFichier = new FileStream(repertoireFichiers + "ticket.csv", FileMode.Create);
                StreamWriter fichier = new StreamWriter(nomFichier, Encoding.GetEncoding(1252));
                //écriture 1ère ligne du fichier : ligne des titres
                string ligne = "N°intervention;dateTicket;n°client;objetTicket;Clôturé ?;DateCloture;nbHeures;n°Tech";
                fichier.WriteLine(ligne);

                //boucle de lecture des données technicien
                for (int i = 0; i < tab.nbTickets; i++)
                {
                    //formatage de la ligne
                    ligne = tab.ticket[i].numero
                          + ";" + tab.ticket[i].dateOuverture.ToShortDateString()
                          + ";" + tab.ticket[i].numClient
                          + ";" + tab.ticket[i].objet;

                    //Ticket clôturé ? --> information OUI ou NON dans le fichier
                    //                     et pas de date de clôture, ni nombre d'heures, ni technicien
                    if (tab.ticket[i].cloture)
                    {
                        ligne += ";" + "OUI" 
                            + ";" + tab.ticket[i].dateCloture.ToShortDateString()
                            + ";" + tab.ticket[i].nbHeures
                            + ";" + tab.ticket[i].numTech;
                    }
                    else
                    {
                        ligne += ";" + "NON"
                            + ";" 
                            + ";"
                            + ";";
                    }

                    //écriture de la ligne dans le fichier
                    fichier.WriteLine(ligne);
                }
                //fermeture du fichier
                fichier.Close();
                return tab.nbTickets + " tickets ont été sauvegardés.";
            }
            catch
            {
                MessageBox.Show("Erreur dans la sauvegarde des tickets", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        private void mnuFichierOuvrir_Click(object sender, EventArgs e)
        {
            //Chargement des données dans les tableaux
            String message = "";
            message += "\n" + chargerTableauCentreAppel();
            message += "\n" + chargerTableauCodeNaf();
            message += "\n" + chargerTableauTechnicien();
            message += "\n" + chargerTableauClient();
            message += "\n" + chargerTableauTicket();

            MessageBox.Show(message, "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuFichierEnregistrer_Click(object sender, EventArgs e)
        {
            //Sauvegarde des données dans les fichiers
            String message = "";
            message += "\n" + sauverTableauCentreAppel();
            message += "\n" + sauverTableauCodeNaf();
            message += "\n" + sauverTableauTechnicien();
            message += "\n" + sauverTableauClient();
            message += "\n" + sauverTableauTicket();

            MessageBox.Show(message, "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuCentreAppelAfficherTous_Click(object sender, EventArgs e)
        {
            //création de la fenêtre demandée
            frmCentreAfficherTous laFenetre = new frmCentreAfficherTous();
            //cette nouvelle fenêtre est une fenêtre fille du menu MDI
            laFenetre.MdiParent = this;
            //ouverture de la fenêtre en plein écran
            laFenetre.WindowState = FormWindowState.Maximized;
            laFenetre.Show();
        }

        private void mnuClientAfficherTous_Click(object sender, EventArgs e)
        {
            //création de la fenêtre demandée
            frmClientAfficherTous laFenetre = new frmClientAfficherTous();
            //cette nouvelle fenêtre est une fenêtre fille du menu MDI
            laFenetre.MdiParent = this;
            //ouverture de la fenêtre en plein écran
            laFenetre.WindowState = FormWindowState.Maximized;
            laFenetre.Show();
        }

        private void mnuCodeNafAfficherTous_Click(object sender, EventArgs e)
        {
            //création de la fenêtre demandée
            frmNafAfficherTous laFenetre = new frmNafAfficherTous();
            //cette nouvelle fenêtre est une fenêtre fille du menu MDI
            laFenetre.MdiParent = this;
            //ouverture de la fenêtre en plein écran
            laFenetre.WindowState = FormWindowState.Maximized;
            laFenetre.Show();
        }

        private void mnuTechnicienAfficherTous_Click(object sender, EventArgs e)
        {
            //création de la fenêtre demandée
            frmTechnicienAfficherTous laFenetre = new frmTechnicienAfficherTous();
            //cette nouvelle fenêtre est une fenêtre fille du menu MDI
            laFenetre.MdiParent = this;
            //ouverture de la fenêtre en plein écran
            laFenetre.WindowState = FormWindowState.Maximized;
            laFenetre.Show();
        }

        private void mnuTicketAfficherTous_Click(object sender, EventArgs e)
        {
            //création de la fenêtre demandée
            frmTicketAfficherTous laFenetre = new frmTicketAfficherTous();
            //cette nouvelle fenêtre est une fenêtre fille du menu MDI
            laFenetre.MdiParent = this;
            //ouverture de la fenêtre en plein écran
            laFenetre.WindowState = FormWindowState.Maximized;
            laFenetre.Show();
        }
        //#######################################
        private void clientParNafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //création de la fenêtre demandée
            frmClientNafAfficher laFenetre = new frmClientNafAfficher();
            //cette nouvelle fenêtre est une fenêtre fille du menu MDI
            laFenetre.MdiParent = this;
            //ouverture de la fenêtre en plein écran
            laFenetre.WindowState = FormWindowState.Maximized;
            laFenetre.Show();
        }

        private void clientParCentreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //création de la fenêtre demandée
            frmClientCentreAfficher laFenetre = new frmClientCentreAfficher();
            //cette nouvelle fenêtre est une fenêtre fille du menu MDI
            laFenetre.MdiParent = this;
            //ouverture de la fenêtre en plein écran
            laFenetre.WindowState = FormWindowState.Maximized;
            laFenetre.Show();
        }

        private void contratExpiréToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //création de la fenêtre demandée
            frmContratAfficherExpiré laFenetre = new frmContratAfficherExpiré();
            //cette nouvelle fenêtre est une fenêtre fille du menu MDI
            laFenetre.MdiParent = this;
            //ouverture de la fenêtre en plein écran
            laFenetre.WindowState = FormWindowState.Maximized;
            laFenetre.Show();
        }

        private void contratDépasséToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //création de la fenêtre demandée
            frmContratAfficherDépassé laFenetre = new frmContratAfficherDépassé();
            //cette nouvelle fenêtre est une fenêtre fille du menu MDI
            laFenetre.MdiParent = this;
            //ouverture de la fenêtre en plein écran
            laFenetre.WindowState = FormWindowState.Maximized;
            laFenetre.Show();
        }

        private void ticketNonClôturéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //création de la fenêtre demandée
            frmTicketsAfficherNonCloturés laFenetre = new frmTicketsAfficherNonCloturés();
            //cette nouvelle fenêtre est une fenêtre fille du menu MDI
            laFenetre.MdiParent = this;
            //ouverture de la fenêtre en plein écran
            laFenetre.WindowState = FormWindowState.Maximized;
            laFenetre.Show();
        }
        private void mnuTicketAfficherClient_Click(object sender, EventArgs e)
        {
            //création de la fenêtre demandée
            frmTicketClient laFenetre = new frmTicketClient();
            //cette nouvelle fenêtre est une fenêtre fille du menu MDI
            laFenetre.MdiParent = this;
            //ouverture de la fenêtre en plein écran
            laFenetre.WindowState = FormWindowState.Maximized;
            laFenetre.Show();
        }

        private void ticketParClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //création de la fenêtre demandée
            frmStatTicketClient laFenetre = new frmStatTicketClient();
            //cette nouvelle fenêtre est une fenêtre fille du menu MDI
            laFenetre.MdiParent = this;
            //ouverture de la fenêtre en plein écran
            laFenetre.WindowState = FormWindowState.Maximized;
            laFenetre.Show();
        }

        private void ticketsParCentreDappelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //création de la fenêtre demandée
            frmStatTicketCentre laFenetre = new frmStatTicketCentre();
            //cette nouvelle fenêtre est une fenêtre fille du menu MDI
            laFenetre.MdiParent = this;
            //ouverture de la fenêtre en plein écran
            laFenetre.WindowState = FormWindowState.Maximized;
            laFenetre.Show();
        }

        private void ticketClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //création de la fenêtre demandée
            frmTicketClient laFenetre = new frmTicketClient();
            //cette nouvelle fenêtre est une fenêtre fille du menu MDI
            laFenetre.MdiParent = this;
            //ouverture de la fenêtre en plein écran
            laFenetre.WindowState = FormWindowState.Maximized;
            laFenetre.Show();
        }

        private void nouveauToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //création de la fenêtre demandée
            frmNouveauTicket laFenetre = new frmNouveauTicket();
            //cette nouvelle fenêtre est une fenêtre fille du menu MDI
            laFenetre.MdiParent = this;
            //ouverture de la fenêtre en plein écran
            laFenetre.WindowState = FormWindowState.Maximized;
            laFenetre.Show();
        }
    }
}
