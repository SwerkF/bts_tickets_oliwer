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
    public partial class frmTicketsAfficherNonCloturés : Form
    {
        public frmTicketsAfficherNonCloturés()
        {
            InitializeComponent();
        }

        private void frmTicketsAfficherNonCloturés_Load(object sender, EventArgs e)
        {
            if (tab.nbTickets == 0)
            {
                MessageBox.Show("Aucun ticjket chargé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                for (int i = 0; i < tab.nbTickets; i++)
                {
                    if (tab.ticket[i].cloture == false)
                    {
                        ListViewItem lv1 = new ListViewItem();
                        lv1.Text = tab.ticket[i].numero.ToString();
                        lv1.SubItems.Add(tab.ticket[i].dateOuverture.ToString());
                        lv1.SubItems.Add(tab.ticket[i].numClient.ToString());
                        lv1.SubItems.Add(tab.ticket[i].objet.ToString());
                        lv1.SubItems.Add(tab.ticket[i].cloture.ToString());
                        lvNonCloturé.Items.Add(lv1);
                    }


                }

            }
        }
    }
}
