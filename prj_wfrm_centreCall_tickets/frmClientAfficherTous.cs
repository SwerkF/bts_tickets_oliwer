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
    public partial class frmClientAfficherTous : Form
    {
        public frmClientAfficherTous()
        {
            InitializeComponent();
        }

        private void frmClientAfficherTous_Load(object sender, EventArgs e)
        {
            if (tab.nbClients == 0)
            {
                MessageBox.Show("Aucun client", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double sommeContrat = 0;
                double sommeTicket = 0;
                double sommeMois = 0;
                //parcours du tableau des centres d'appel
                for (int i = 0; i < tab.nbClients; i++)
                {
                    //configuration d'une ligne de la liste
                    ListViewItem ligne = new ListViewItem();
                    //1ère colonne = n° du client
                    ligne.Text = tab.client[i].numero.ToString();
                    //2ème colonne = raison sociale du client
                    ligne.SubItems.Add(tab.client[i].raisonSociale);
                    //3ème colonne = centre d'appel duquel dépend le client
                    // --> on récupère le n° du centre d'appel
                    //     la ville du centre d'appel est dans le tableau centre
                    //     à l'indice n° du centre -1 
                    int iCentre = tab.client[i].centreAppel - 1;
                    ligne.SubItems.Add(tab.centreAppel[iCentre].ville);
                    //4ème colonne = intitulé activité NAF du client sur 50 caractères maximum
                    // --> on récupère le n° du code NAF
                    //     l'intitulé de l'activité est dans le tableau codeNaf
                    //     à l'indice n° du code -1 
                    int iNaf = tab.client[i].codeNaf - 1;
                    int lgIntitule = tab.codeNaf[iNaf].intitule.Length;
                    if (lgIntitule > 50) lgIntitule = 50;
                    ligne.SubItems.Add(tab.codeNaf[iNaf].intitule.Substring(0, lgIntitule));
                    //5ème colonne = date du dernier contrat au format court (jj/MM/AAAA)
                    ligne.SubItems.Add(tab.client[i].dateContrat.ToShortDateString());
                    //6ème colonne = durée du dernier contrat
                    ligne.SubItems.Add(tab.client[i].duree.ToString());
                    //7ème colonne = montant du dernier contrat au format monétaire
                    ligne.SubItems.Add(String.Format("{0:C}", tab.client[i].montantContrat));
                    //8ème colonne = montant cumulé des tickets imputés à ce contrat
                    ligne.SubItems.Add(String.Format("{0:C}", tab.client[i].montantTickets));

                    //ajout de la ligne dans la liste
                    lvClient.Items.Add(ligne);

                    // Dans la boucle for I
                    sommeContrat = sommeContrat + Convert.ToDouble(tab.client[i].montantContrat); // Ajout des montants des contrats

                    sommeTicket = sommeTicket + Convert.ToDouble(tab.client[i].montantTickets); // Ajouts des montants des tickets

                    sommeMois = sommeMois + Convert.ToDouble(tab.client[i].duree); // Ajout des la durée des contrats
                }
                sommeTicket = Math.Round(sommeTicket, 2); // Conversion de la somme des tickets à 2 nombres après la virgule
                sommeMois = Math.Round(((sommeMois / tab.nbClients)), 2); // Conversion de la durée des tickets à 2 nombres après la virgule
                sommeContrat = Math.Round(sommeContrat, 2); // Conversion de la somme des Contrats à 2 nombres après la virgule
                // Ecriture dans les textbox
                tbMoisTotal.Text = sommeMois.ToString() + " mois"; 
                tbValeurTotalTickets.Text = sommeTicket.ToString() + "€";
                tbValeurTotalContrat.Text = sommeContrat.ToString() + "€";
            }
        }
    }
}
