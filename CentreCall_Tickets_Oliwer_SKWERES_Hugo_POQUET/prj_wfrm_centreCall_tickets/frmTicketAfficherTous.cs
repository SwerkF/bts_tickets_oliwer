using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_wfrm_centreCall_tickets
{
    public partial class frmTicketAfficherTous : Form
    {
        public frmTicketAfficherTous()
        {
            InitializeComponent();
        }

        private void frmTicketAfficherTous_Load(object sender, EventArgs e)
        {
            if (tab.nbTickets == 0)
            {
                MessageBox.Show("Aucun ticket", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float somme = 0;
                int nbLigne = 0;

                //parcours du tableau des centres d'appel
                for (int i = 0; i < tab.nbTickets; i++)
                {
                    //configuration d'une ligne de la liste
                    ListViewItem ligne = new ListViewItem();
                    //1ère colonne = n° du ticket
                    ligne.Text = tab.ticket[i].numero.ToString();
                    //2ème colonne = date d'ouverture du ticket au format court (JJ/MM/AAA)
                    ligne.SubItems.Add(tab.ticket[i].dateOuverture.ToShortDateString());
                    //3ème colonne = raison sociale du client
                    // --> on récupère le n° du client
                    //     sa raison sociale est dans le tableau client
                    //     à l'indice n° du client -1 
                    int iClient = tab.ticket[i].numClient - 1;
                    ligne.SubItems.Add(tab.client[iClient].raisonSociale);
                    //4ème colonne = objet du ticket
                    ligne.SubItems.Add(tab.ticket[i].objet);
                    //5ème colonne = OUI ou NON ticket clôturé 
                    if (tab.ticket[i].cloture)
                        ligne.SubItems.Add("OUI");
                    else
                        ligne.SubItems.Add("NON");
                    //6ème colonne = date de clôture si ticket clôturé
                    if (tab.ticket[i].cloture) ligne.SubItems.Add(tab.ticket[i].dateCloture.ToShortDateString());
                    //7ème colonne = nombre d'heures du ticket si ticket clôturé
                    if (tab.ticket[i].cloture) ligne.SubItems.Add(String.Format("{0:N2}", tab.ticket[i].nbHeures));
                    //8ème colonne = nom du technicien si ticket clôturé
                    if (tab.ticket[i].cloture)
                    {
                        int iTech = tab.ticket[i].numTech - 1;
                        ligne.SubItems.Add(tab.tech[iTech].nom + " " + tab.tech[iTech].prenom);
                    }

                    //ajout de la ligne dans la liste
                    lvTicket.Items.Add(ligne);

                    if (tab.ticket[i].nbHeures != float.MinValue)
                    {
                        float nbHeures = tab.ticket[i].nbHeures;
                        somme = somme + nbHeures;

                        nbLigne += 1;
                    }
                }

                float nombreHeuresMoyen = somme / nbLigne;
                tbNombreHeures.Text = "Nombre d'heures moyen des techniciens : " + Math.Round(nombreHeuresMoyen, 2);
            }
        }
    }
}
