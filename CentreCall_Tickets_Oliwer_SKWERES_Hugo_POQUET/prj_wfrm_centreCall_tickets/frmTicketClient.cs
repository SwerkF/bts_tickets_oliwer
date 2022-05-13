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
    public partial class frmTicketClient : Form
    {
        string numero;

        public frmTicketClient()
        {
            InitializeComponent();
        }
        private void cbClient_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lvTicket.Items.Clear();

            numero = cbClient.Text.Substring(0, cbClient.Text.IndexOf(' '));

            for (int i = 0; i < tab.nbClients; i++)
            {
                if (numero == tab.ticket[i].numClient.ToString())
                {
                    lvTicket.Items.Add(new ListViewItem(new String[] { tab.ticket[i].numero.ToString(),
                        tab.ticket[i].dateOuverture.ToShortDateString(),
                        tab.ticket[i].objet.ToString(),
                        tab.ticket[i].cloture.ToString(),
                        tab.ticket[i].dateCloture.ToShortDateString(),
                        tab.ticket[i].nbHeures.ToString(),
                        tab.ticket[i].numTech.ToString() }));
                }
            }
        }

        private void frmTicketClient_Load(object sender, EventArgs e)
        {
            if (tab.nbClients == 0)
            {
                MessageBox.Show("Aucun client", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool existe = false;
                for (int i = 0; i < tab.nbClients; i++)
                {
                    for (int j = 0; j < tab.nbTickets; j++)
                    {
                        if (tab.client[i].numero.ToString() == tab.ticket[j].numClient.ToString())
                        {
                            existe = true;
                        }
                    }
                    if (existe)
                    {
                        cbClient.Items.Add(tab.client[i].numero.ToString() + " - " + tab.client[i].raisonSociale);
                    }
                    existe = false;
                }
            }
        }
    }
}
