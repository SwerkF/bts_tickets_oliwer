using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prj_wfrm_centreCall_tickets
{
    public partial class frmNouveauTicket : Form
    {
        //Initialisation du chemin du répertoire de fichiers
        string repertoireFichiers = "../../../fichiers/";

        //Initialisation d'un booléen pour vérifier le numéro
        bool verifNumero = false;

        int i = 0;

        public frmNouveauTicket()
        {
            InitializeComponent();
        }
        private void frmNouveauTicket_Load_1(object sender, EventArgs e)
        {
            //Si aucun client n'est chargé
            if (tab.nbClients == 0)
            {
                MessageBox.Show("Aucun client", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //parcours du tableau des clients
                for (int i = 0; i < tab.nbClients; i++)
                {
                    //Ajout des items dans la comboBox
                    cbClientNouveauTicket.Items.Add(tab.client[i].numero.ToString() + " - " + tab.client[i].raisonSociale);
                }
            }

            //Si aucun technicien n'est chargé
            if (tab.nbTech == 0)
            {
                MessageBox.Show("Aucun technicien", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //parcours du tableau des techniciens
                for (int i = 0; i < tab.nbTech; i++)
                {
                    //AJout des items dans la comboBox
                    cbNouveauTech.Items.Add(tab.tech[i].numero.ToString() + " - " + tab.tech[i].nom);
                }
            }
        }

        private void nudNumTicket_ValueChanged_1(object sender, EventArgs e)
        {
            //Si un numéro de ticket est sélectionné,
            //que la comboBox client a un item sélectionné,
            //que la comboBox technicien a un item sélectionné,
            //et qu'un objet est entré
            if (nudNumTicket.Value > 0 && cbClientNouveauTicket.SelectedIndex != -1
                && cbNouveauTech.SelectedIndex != -1 && tbObjet.Text != "")
            {
                //Bouton valider disponible
                btnValider.Enabled = true;
            }

            else
                //Bouton valider indisponible
                btnValider.Enabled = false;
        }

        private void cbClientNouveauTicket_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Si un numéro de ticket est sélectionné,
            //que la comboBox client a un item sélectionné,
            //que la comboBox technicien a un item sélectionné,
            //et qu'un objet est entré
            if (nudNumTicket.Value > 0 && cbClientNouveauTicket.SelectedIndex != -1
                && cbNouveauTech.SelectedIndex != -1 && tbObjet.Text != "")
            {
                //Bouton valider disponible
                btnValider.Enabled = true;
            }

            else
            {
                //Bouton valider indisponible
                btnValider.Enabled = false;
            }
        }

        private void cbNouveauTech_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Si un numéro de ticket est sélectionné,
            //que la comboBox client a un item sélectionné,
            //que la comboBox technicien a un item sélectionné,
            //et qu'un objet est entré
            if (nudNumTicket.Value > 0 && cbClientNouveauTicket.SelectedIndex != -1
                && cbNouveauTech.SelectedIndex != -1 && tbObjet.Text != "")
            {
                //Bouton valider disponible
                btnValider.Enabled = true;
            }

            else
                //Bouton valider indisponible
                btnValider.Enabled = false;
        }

        private void tbObjet_TextChanged_1(object sender, EventArgs e)
        {
            //Si un numéro de ticket est sélectionné,
            //que la comboBox client a un item sélectionné,
            //que la comboBox technicien a un item sélectionné,
            //et qu'un objet est entré
            if (nudNumTicket.Value > 0 && cbClientNouveauTicket.SelectedIndex != -1
                && cbNouveauTech.SelectedIndex != -1 && tbObjet.Text != "")
            {
                //Bouton valider disponible
                btnValider.Enabled = true;
            }

            else
                //Bouton valider indisponible
                btnValider.Enabled = false;
        }

        private void btnValider_Click_1(object sender, EventArgs e)
        {
            //Boucle tant que i est inérieur au nombre de tickets
            while (i < tab.nbTickets)
            {
                //Si le numéro entré n'est pas égale au numéro de ticket i
                if (nudNumTicket.Value != tab.ticket[i].numero)
                {
                    //On met le booléen en true
                    verifNumero = true;
                    //On passe au ticket suivant
                    i++;
                }

                // Si le numéro entré est égal au numéro de ticket i
                else if (nudNumTicket.Value == tab.ticket[i].numero)
                {
                    //On met le booléen en false
                    verifNumero = false;
                    //Fermeture de la boucle for
                    i = tab.nbTickets;
                }
            }

            //On réinitialise i
            i = 0;

            //Si le numéro est disponible
            if (verifNumero == true)
            {
                //On grise les paramètres
                btnValider.Enabled = false;
                nudNumTicket.Enabled = false;
                cbClientNouveauTicket.Enabled = false;
                cbNouveauTech.Enabled = false;
                tbObjet.Enabled = false;
                calendarTicket.Enabled = false;

                MessageBox.Show("Nouveau ticket créé avec succès");

                //Pour split le text de la comboBox et ne garder que le numéro
                int index = cbClientNouveauTicket.Text.IndexOf('-');
                string numero;
                numero = Convert.ToString(cbClientNouveauTicket.Text.Substring(0, index - 1));

                int index2 = cbNouveauTech.Text.IndexOf('-');
                string numero2;
                numero2 = Convert.ToString(cbClientNouveauTicket.Text.Substring(0, index2 - 1));



                // Ecriture dans le fichier
                using (StreamWriter writer =
                    new StreamWriter(repertoireFichiers + @"ticket.csv", true))
                {
                    writer.WriteLine(nudNumTicket.Value + ";" +
                        calendarTicket.SelectionStart.ToShortDateString() + ";" +
                        numero + ";" +
                        tbObjet.Text + ";" + "NON;;;" + numero2);
                }
            }

            //Si le numéro est indisponible
            else if (verifNumero == false)
            {
                MessageBox.Show("Ce numéro de ticket est déjà attribué");
            }
        }

        private void btnRecommencer_Click_1(object sender, EventArgs e)
        {
            //On dégrise les paramètres et on remet les valeurs par défauts
            nudNumTicket.Value = 0;
            nudNumTicket.Enabled = true;
            cbClientNouveauTicket.Text = "";
            cbClientNouveauTicket.Enabled = true;
            cbNouveauTech.Text = "";
            cbNouveauTech.Enabled = true;
            tbObjet.Text = "";
            tbObjet.Enabled = true;
            calendarTicket.Enabled = true;
            verifNumero = false;
            i = 0;
        }


    }
}