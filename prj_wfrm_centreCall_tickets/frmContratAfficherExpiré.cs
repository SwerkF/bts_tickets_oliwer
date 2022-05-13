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
    public partial class frmContratAfficherExpiré : Form
    {
        public frmContratAfficherExpiré()
        {
            InitializeComponent();
        }

        private void frmContratAfficherExpiré_Load(object sender, EventArgs e)
        {
            // Message d'erreur si aucun fichier n'est chargé
            if (tab.nbClients == 0)
            {
                MessageBox.Show("Aucun contrat chargé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                for (int i = 0; i < tab.nbClients; i++)
                {
                    //Initialisation des dates
                    DateTime dateExpire = DateTime.Now;
                    DateTime dateContrat = DateTime.Parse(tab.client[i].dateContrat.ToString());
                    DateTime dateExpiration = dateContrat.AddMonths(tab.client[i].duree); // Ajouts de la durée dans la date de départ

                    if(dateExpire > dateExpiration) // Si 
                    {
                        ListViewItem ligne = new ListViewItem();
                        ligne.Text = tab.client[i].numero.ToString();
                        ligne.SubItems.Add(tab.client[i].raisonSociale);
                        int iCentre = tab.client[i].centreAppel - 1;
                        ligne.SubItems.Add(tab.centreAppel[iCentre].ville);
                        int iNaf = tab.client[i].codeNaf - 1;
                        int lgIntitule = tab.codeNaf[iNaf].intitule.Length;
                        if (lgIntitule > 50) lgIntitule = 50;
                        ligne.SubItems.Add(tab.codeNaf[iNaf].intitule.Substring(0, lgIntitule));
                        ligne.SubItems.Add(tab.client[i].dateContrat.ToShortDateString());
                        ligne.SubItems.Add(tab.client[i].duree.ToString());
                        ligne.SubItems.Add(String.Format("{0:C}", tab.client[i].montantContrat));
                        ligne.SubItems.Add(String.Format("{0:C}", tab.client[i].montantTickets));
                        lvContratExpire.Items.Add(ligne); // Ajouts des contrats dans la listview
                    }
                   

                }

            }
        }
    }
}
