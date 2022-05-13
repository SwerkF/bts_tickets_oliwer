namespace prj_wfrm_centreCall_tickets
{
    partial class frmTechnicienAfficherTous
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvTech = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbTauxHoraireMoyen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvTech
            // 
            this.lvTech.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvTech.FullRowSelect = true;
            this.lvTech.HideSelection = false;
            this.lvTech.Location = new System.Drawing.Point(12, 6);
            this.lvTech.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvTech.Name = "lvTech";
            this.lvTech.Size = new System.Drawing.Size(405, 400);
            this.lvTech.TabIndex = 1;
            this.lvTech.UseCompatibleStateImageBehavior = false;
            this.lvTech.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N°";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prénom";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Taux Horaire";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 80;
            // 
            // tbTauxHoraireMoyen
            // 
            this.tbTauxHoraireMoyen.Location = new System.Drawing.Point(12, 423);
            this.tbTauxHoraireMoyen.Name = "tbTauxHoraireMoyen";
            this.tbTauxHoraireMoyen.ReadOnly = true;
            this.tbTauxHoraireMoyen.Size = new System.Drawing.Size(405, 20);
            this.tbTauxHoraireMoyen.TabIndex = 3;
            // 
            // frmTechnicienAfficherTous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 552);
            this.Controls.Add(this.tbTauxHoraireMoyen);
            this.Controls.Add(this.lvTech);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTechnicienAfficherTous";
            this.Text = "Techniciens - Tous";
            this.Load += new System.EventHandler(this.frmTechnicienAfficherTous_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTech;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tbTauxHoraireMoyen;
    }
}