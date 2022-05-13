namespace prj_wfrm_centreCall_tickets
{
    partial class frmNouveauTicket
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
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.tbObjet = new System.Windows.Forms.TextBox();
            this.cbNouveauTech = new System.Windows.Forms.ComboBox();
            this.cbClientNouveauTicket = new System.Windows.Forms.ComboBox();
            this.nudNumTicket = new System.Windows.Forms.NumericUpDown();
            this.btnValider = new System.Windows.Forms.Button();
            this.calendarTicket = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.Location = new System.Drawing.Point(439, 330);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(183, 72);
            this.btnRecommencer.TabIndex = 23;
            this.btnRecommencer.Text = "Recommencer";
            this.btnRecommencer.UseVisualStyleBackColor = true;
            this.btnRecommencer.Click += new System.EventHandler(this.btnRecommencer_Click_1);
            // 
            // tbObjet
            // 
            this.tbObjet.Location = new System.Drawing.Point(167, 279);
            this.tbObjet.Name = "tbObjet";
            this.tbObjet.Size = new System.Drawing.Size(541, 22);
            this.tbObjet.TabIndex = 22;
            this.tbObjet.TextChanged += new System.EventHandler(this.tbObjet_TextChanged_1);
            // 
            // cbNouveauTech
            // 
            this.cbNouveauTech.FormattingEnabled = true;
            this.cbNouveauTech.Location = new System.Drawing.Point(167, 189);
            this.cbNouveauTech.Name = "cbNouveauTech";
            this.cbNouveauTech.Size = new System.Drawing.Size(189, 24);
            this.cbNouveauTech.TabIndex = 21;
            this.cbNouveauTech.SelectedIndexChanged += new System.EventHandler(this.cbNouveauTech_SelectedIndexChanged_1);
            // 
            // cbClientNouveauTicket
            // 
            this.cbClientNouveauTicket.FormattingEnabled = true;
            this.cbClientNouveauTicket.Location = new System.Drawing.Point(167, 133);
            this.cbClientNouveauTicket.Name = "cbClientNouveauTicket";
            this.cbClientNouveauTicket.Size = new System.Drawing.Size(189, 24);
            this.cbClientNouveauTicket.TabIndex = 20;
            this.cbClientNouveauTicket.SelectedIndexChanged += new System.EventHandler(this.cbClientNouveauTicket_SelectedIndexChanged_1);
            // 
            // nudNumTicket
            // 
            this.nudNumTicket.Location = new System.Drawing.Point(181, 76);
            this.nudNumTicket.Name = "nudNumTicket";
            this.nudNumTicket.Size = new System.Drawing.Size(59, 22);
            this.nudNumTicket.TabIndex = 19;
            this.nudNumTicket.ValueChanged += new System.EventHandler(this.nudNumTicket_ValueChanged_1);
            // 
            // btnValider
            // 
            this.btnValider.Enabled = false;
            this.btnValider.Location = new System.Drawing.Point(181, 330);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(183, 72);
            this.btnValider.TabIndex = 18;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click_1);
            // 
            // calendarTicket
            // 
            this.calendarTicket.Location = new System.Drawing.Point(491, 50);
            this.calendarTicket.Name = "calendarTicket";
            this.calendarTicket.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Technicien :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Client :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Objet du ticket :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date du ticket :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Numéro de ticket :";
            // 
            // frmNouveauTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.tbObjet);
            this.Controls.Add(this.cbNouveauTech);
            this.Controls.Add(this.cbClientNouveauTicket);
            this.Controls.Add(this.nudNumTicket);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.calendarTicket);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNouveauTicket";
            this.Text = "Nouveau ticket";
            this.Load += new System.EventHandler(this.frmNouveauTicket_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecommencer;
        private System.Windows.Forms.TextBox tbObjet;
        private System.Windows.Forms.ComboBox cbNouveauTech;
        private System.Windows.Forms.ComboBox cbClientNouveauTicket;
        private System.Windows.Forms.NumericUpDown nudNumTicket;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.MonthCalendar calendarTicket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}