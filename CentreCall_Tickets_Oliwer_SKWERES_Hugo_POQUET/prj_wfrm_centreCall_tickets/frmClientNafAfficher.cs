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
    public partial class frmClientNafAfficher : Form
    {
        public frmClientNafAfficher()
        {
            InitializeComponent();
        }

        private void frmClientNafAfficher_Load(object sender, EventArgs e)
        {
            // Message d'erreur si aucun fichier n'est chargé
            if (tab.nbCodesNaf == 0)
            {
                MessageBox.Show("Aucun code NAF", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(tab.nbClients == 0)
            {
                MessageBox.Show("Aucun client", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Selection des codes NAF qui sont utilisé. Si l'un d'entre eux ne figure pas dans le fichier CSV,
                // il ne sera pas afficher dans la combo box
                bool existe = false;
                for (int i = 0; i < tab.nbCodesNaf; i++)
                {
                    for(int j = 0; j < tab.nbClients; j++)
                    {
                        if (tab.codeNaf[i].code.ToString() == tab.client[j].codeNaf.ToString().Substring(0, 2))
                        {
                            existe = true;
                        }
                    }
                    if(existe)
                    {
                        cbCodeNaf.Items.Add(tab.codeNaf[i].code.ToString() + " - " + tab.codeNaf[i].intitule.ToString());
                    }
                    existe = false;
                }
            }
        }

        private void cbCodeNaf_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvNafClient.Items.Clear();
            for (int i = 0; i < tab.nbClients; i++)
            {
                // Affichage des clients en fonction du code NAF choisi
                if (cbCodeNaf.Text.Substring(0,2) == tab.client[i].codeNaf.ToString())
                {
                    lvNafClient.Items.Add(new ListViewItem(new String[] { tab.client[i].numero.ToString(), tab.client[i].raisonSociale.ToString() }));

                }
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
