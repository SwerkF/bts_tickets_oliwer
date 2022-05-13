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
    public partial class frmNafAfficherTous : Form
    {
        public frmNafAfficherTous()
        {
            InitializeComponent();
        }

        private void frmNafAfficherTous_Load(object sender, EventArgs e)
        {
            if (tab.nbCodesNaf == 0)
            {
                MessageBox.Show("Aucun code NAF", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //parcours du tableau des codes NAF
                for (int i = 0; i < tab.nbCodesNaf; i++)
                {
                    //configuration d'une ligne de la liste
                    ListViewItem ligne = new ListViewItem();
                    ligne.Text = tab.codeNaf[i].code.ToString();            //1ère colonne
                    ligne.SubItems.Add(tab.codeNaf[i].intitule);           //2ème colonne

                    //ajout de la ligne dans la liste
                    lvCode.Items.Add(ligne);
                }
            }
        }
    }
}
