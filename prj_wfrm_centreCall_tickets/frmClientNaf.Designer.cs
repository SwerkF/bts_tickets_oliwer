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
    public partial class frmClientNaf : Form
    {
        public frmClientNaf()
        {
            InitializeComponent();
        }

        private void frmClientNaf_Load(object sender, EventArgs e)
        {
            if (tab.nbCodesNaf == 0)
            {
                MessageBox.Show("Aucun code NAF", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < tab.nbCodesNaf; i++)
                {
                    cbCodeNaf.Items.Add(tab.codeNaf[i].code.ToString() + " - " + tab.codeNaf[i].intitule.ToString());
                }
            }
        }

        private void cbCodeNaf_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvNafClient.Items.Clear();
            ListViewItem lv1 = new ListViewItem();

            for (int i = 0; i < tab.nbClients; i++)
            {
                
                if(cbCodeNaf.Text == tab.client[i].codeNaf.ToString())
                {
                    lv1.Text = tab.client[i].numero.ToString();
                    lv1.SubItems.Add(tab.client[i].raisonSociale.ToString());
                }
            }
            lvNafClient.Items.Add(lv1);
        }
    }
}
