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
    public partial class frmStatTicketCentre : Form
    {
        public frmStatTicketCentre()
        {
            InitializeComponent();
        }

        private void frmStatTicketCentre_Load_1(object sender, EventArgs e)
        {
            if (tab.nbTickets == 0)
            {
                MessageBox.Show("Aucun ticket", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                //parcours du tableau des centres d'appel
                for (int k = 0; k < tab.nbCentresAppel; k++)
                {
                    //parcours list client
                    int nbTicketClient = 0;
                    //nb ticket à 0
                    for (int j = 0; j < tab.nbTickets; j++)
                    {
                        for (int i = 0; i < tab.nbClients; i++)
                        {
                            //parcours list tickets
                            if (tab.ticket[j].numClient == tab.client[i].numero && tab.client[i].centreAppel == tab.centreAppel[k].numero)
                            {
                                // Si num Client ticket est le meme que celui à ajt, on ajt + 1 au nombre de ticket
                                nbTicketClient++;
                            }
                        }
                    }

                    ListViewItem ligne = new ListViewItem();
                    ligne.Text = tab.centreAppel[k].ville;
                    ligne.SubItems.Add(nbTicketClient.ToString());

                    //ajout de la ligne dans la liste
                    lvStatTicketClient.Items.Add(ligne);
                }
            }
        }
    }
}
