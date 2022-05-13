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
    public partial class frmClientCentreAfficher : Form
    {
        public frmClientCentreAfficher()
        {
            InitializeComponent();
        }

        private void frmClientCentreAfficher_Load(object sender, EventArgs e)
        {
            // Message d'erreur si aucun fichier n'est chargé
            if (tab.nbCentresAppel == 0)
            {
                MessageBox.Show("Aucun centre d'appel", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tab.nbClients == 0)
            {
                MessageBox.Show("Aucun client", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Selection des centres d'appel qui sont utilisé. Si l'un d'entre eux ne figure pas dans le fichier CSV,
                // il ne sera pas afficher dans la combo box
                bool existe = false;
                
                for (int i = 0; i < tab.nbCentresAppel; i++)
                {
                    for (int j = 0; j < tab.nbClients; j++)
                    {
                        if (tab.centreAppel[i].numero.ToString() == tab.client[j].centreAppel.ToString())
                        {
                            existe = true;
                        }
                    }
                    if (existe)
                    {
                        cbCentreAppel.Items.Add(tab.centreAppel[i].numero.ToString() + " - " + tab.centreAppel[i].ville.ToString());
                    }
                    existe = false;
                }
            }
        }

        private void cbCentreAppel_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Affichage des clients en fonction du centre d'appel choisi
            lvCentreAppel.Items.Clear();
            for (int i = 0; i < tab.nbClients; i++)
            {

                if (cbCentreAppel.Text.Substring(0,1) == tab.client[i].centreAppel.ToString())
                {
                    lvCentreAppel.Items.Add(new ListViewItem(new String[] { tab.client[i].numero.ToString(), tab.client[i].raisonSociale.ToString() }));

                }

            }
        }
    }
}
