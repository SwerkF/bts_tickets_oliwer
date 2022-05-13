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
    public partial class frmCentreAfficherTous : Form
    {
        public frmCentreAfficherTous()
        {
            InitializeComponent();
        }

        private void frmCentreAfficherTous_Load(object sender, EventArgs e)
        {
            if (tab.nbCentresAppel == 0)
            {
                MessageBox.Show("Aucun centre d'appel", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //parcours du tableau des centres d'appel
                for (int i=0; i < tab.nbCentresAppel; i++)
                {
                    //configuration d'une ligne de la liste
                    ListViewItem ligne = new ListViewItem();
                    ligne.Text = tab.centreAppel[i].numero.ToString();      //1ère colonne
                    ligne.SubItems.Add(tab.centreAppel[i].ville);           //2ème colonne

                    //ajout de la ligne dans la liste
                    lvCentre.Items.Add(ligne);
                }
            }
        }
    }
}
