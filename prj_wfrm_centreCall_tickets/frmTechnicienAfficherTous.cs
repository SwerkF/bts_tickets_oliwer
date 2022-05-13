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
    public partial class frmTechnicienAfficherTous : Form
    {
        public frmTechnicienAfficherTous()
        {
            InitializeComponent();
        }

        private void frmTechnicienAfficherTous_Load(object sender, EventArgs e)
        {
            if (tab.nbTech == 0)
            {
                MessageBox.Show("Aucun technicien", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double somme = 0;

                //parcours du tableau des centres d'appel
                for (int i = 0; i < tab.nbTech; i++)
                {
                    //configuration d'une ligne de la liste
                    ListViewItem ligne = new ListViewItem();
                    ligne.Text = tab.tech[i].numero.ToString();                             //1ère colonne
                    ligne.SubItems.Add(tab.tech[i].nom);                                    //2ème colonne
                    ligne.SubItems.Add(tab.tech[i].prenom);                                 //3ème colonne
                    ligne.SubItems.Add(String.Format("{0:C}", tab.tech[i].tauxHoraire));    //4ème colonne
                    //ajout de la ligne dans la liste
                    lvTech.Items.Add(ligne);


                    somme = somme + Convert.ToDouble(tab.tech[i].tauxHoraire);
                }

                double tauxHoraireMoyen = Math.Round((somme / tab.nbTech), 2);
                tbTauxHoraireMoyen.Text = "Taux horaire moyen des techniciens : " + tauxHoraireMoyen + " €";
            }
        }
    }
}
