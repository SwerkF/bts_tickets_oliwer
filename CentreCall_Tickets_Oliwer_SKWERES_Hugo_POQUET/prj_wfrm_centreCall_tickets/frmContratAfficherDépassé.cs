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
    public partial class frmContratAfficherDépassé : Form
    {
        public frmContratAfficherDépassé()
        {
            InitializeComponent();
        }

        private void frmContratAfficherDépassé_Load(object sender, EventArgs e)
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
                    //Initalisation des montants contrat et ticket
                    float mtnContrat = tab.client[i].montantContrat;
                    float mtnTicket = tab.client[i].montantTickets;
                    
                    if (mtnTicket > mtnContrat)
                    {
                        
                        float dépassement = -1 * (tab.client[i].montantContrat - tab.client[i].montantTickets); // Conversion en nombre positif
                        ListViewItem lv1 = new ListViewItem();
                        lv1.Text = tab.client[i].numero.ToString();
                        lv1.SubItems.Add(tab.client[i].raisonSociale.ToString());
                        lv1.SubItems.Add(tab.client[i].montantContrat.ToString());
                        lv1.SubItems.Add(tab.client[i].montantTickets.ToString());
                        lv1.SubItems.Add(Math.Round(dépassement, 2).ToString());
                        lvDépassement.Items.Add(lv1); // Ajout des éléments dans la listview
                    }


                }

            }
        }
    }
}
