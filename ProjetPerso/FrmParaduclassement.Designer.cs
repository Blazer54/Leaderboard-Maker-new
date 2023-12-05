namespace ProjetPerso
{
    partial class FrmParaduclassement
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
            this.LblNbrjoueur = new System.Windows.Forms.Label();
            this.cbxjoueur = new System.Windows.Forms.ComboBox();
            this.LblJeux = new System.Windows.Forms.Label();
            this.cbxjeux = new System.Windows.Forms.ComboBox();
            this.lblequipe = new System.Windows.Forms.Label();
            this.lblSeul = new System.Windows.Forms.Label();
            this.chbequipe = new System.Windows.Forms.CheckBox();
            this.chbSeul = new System.Windows.Forms.CheckBox();
            this.lblnbrequipe = new System.Windows.Forms.Label();
            this.cbxnbrequipe = new System.Windows.Forms.ComboBox();
            this.tbxnomequipe1 = new System.Windows.Forms.TextBox();
            this.tbxnomequipe3 = new System.Windows.Forms.TextBox();
            this.tbxnomequipe5 = new System.Windows.Forms.TextBox();
            this.tbxnomequipe4 = new System.Windows.Forms.TextBox();
            this.tbxnomequipe2 = new System.Windows.Forms.TextBox();
            this.lblnomequipe1 = new System.Windows.Forms.Label();
            this.lblnomequipe2 = new System.Windows.Forms.Label();
            this.lblnomequipe3 = new System.Windows.Forms.Label();
            this.lblnomequipe4 = new System.Windows.Forms.Label();
            this.lblnomequipe5 = new System.Windows.Forms.Label();
            this.lblnomequipe6 = new System.Windows.Forms.Label();
            this.tbxnomequipe6 = new System.Windows.Forms.TextBox();
            this.btnvalider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNbrjoueur
            // 
            this.LblNbrjoueur.AutoSize = true;
            this.LblNbrjoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNbrjoueur.Location = new System.Drawing.Point(21, 19);
            this.LblNbrjoueur.Name = "LblNbrjoueur";
            this.LblNbrjoueur.Size = new System.Drawing.Size(135, 20);
            this.LblNbrjoueur.TabIndex = 0;
            this.LblNbrjoueur.Text = "Nombre de joueur";
            // 
            // cbxjoueur
            // 
            this.cbxjoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxjoueur.FormattingEnabled = true;
            this.cbxjoueur.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12"});
            this.cbxjoueur.Location = new System.Drawing.Point(162, 19);
            this.cbxjoueur.Name = "cbxjoueur";
            this.cbxjoueur.Size = new System.Drawing.Size(109, 23);
            this.cbxjoueur.TabIndex = 1;
            // 
            // LblJeux
            // 
            this.LblJeux.AutoSize = true;
            this.LblJeux.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJeux.Location = new System.Drawing.Point(511, 20);
            this.LblJeux.Name = "LblJeux";
            this.LblJeux.Size = new System.Drawing.Size(97, 20);
            this.LblJeux.TabIndex = 3;
            this.LblJeux.Text = "Type de jeux";
            // 
            // cbxjeux
            // 
            this.cbxjeux.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxjeux.FormattingEnabled = true;
            this.cbxjeux.Items.AddRange(new object[] {
            "battle Royale",
            "MME (Match a mort par équipe)"});
            this.cbxjeux.Location = new System.Drawing.Point(614, 20);
            this.cbxjeux.Name = "cbxjeux";
            this.cbxjeux.Size = new System.Drawing.Size(174, 23);
            this.cbxjeux.TabIndex = 4;
            // 
            // lblequipe
            // 
            this.lblequipe.AutoSize = true;
            this.lblequipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblequipe.Location = new System.Drawing.Point(21, 57);
            this.lblequipe.Name = "lblequipe";
            this.lblequipe.Size = new System.Drawing.Size(67, 20);
            this.lblequipe.TabIndex = 5;
            this.lblequipe.Text = "Equipe :";
            // 
            // lblSeul
            // 
            this.lblSeul.AutoSize = true;
            this.lblSeul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeul.Location = new System.Drawing.Point(21, 92);
            this.lblSeul.Name = "lblSeul";
            this.lblSeul.Size = new System.Drawing.Size(49, 20);
            this.lblSeul.TabIndex = 6;
            this.lblSeul.Text = "Seul :";
            // 
            // chbequipe
            // 
            this.chbequipe.AutoSize = true;
            this.chbequipe.Location = new System.Drawing.Point(94, 63);
            this.chbequipe.Name = "chbequipe";
            this.chbequipe.Size = new System.Drawing.Size(15, 14);
            this.chbequipe.TabIndex = 7;
            this.chbequipe.UseVisualStyleBackColor = true;
            this.chbequipe.CheckedChanged += new System.EventHandler(this.chbequipe_CheckedChanged);
            // 
            // chbSeul
            // 
            this.chbSeul.AutoSize = true;
            this.chbSeul.Location = new System.Drawing.Point(94, 92);
            this.chbSeul.Name = "chbSeul";
            this.chbSeul.Size = new System.Drawing.Size(15, 14);
            this.chbSeul.TabIndex = 8;
            this.chbSeul.UseVisualStyleBackColor = true;
            this.chbSeul.CheckedChanged += new System.EventHandler(this.chbSeul_CheckedChanged);
            // 
            // lblnbrequipe
            // 
            this.lblnbrequipe.AutoSize = true;
            this.lblnbrequipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnbrequipe.Location = new System.Drawing.Point(511, 57);
            this.lblnbrequipe.Name = "lblnbrequipe";
            this.lblnbrequipe.Size = new System.Drawing.Size(129, 20);
            this.lblnbrequipe.TabIndex = 9;
            this.lblnbrequipe.Text = "Nombre d\'équipe";
            // 
            // cbxnbrequipe
            // 
            this.cbxnbrequipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxnbrequipe.FormattingEnabled = true;
            this.cbxnbrequipe.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbxnbrequipe.Location = new System.Drawing.Point(646, 54);
            this.cbxnbrequipe.Name = "cbxnbrequipe";
            this.cbxnbrequipe.Size = new System.Drawing.Size(121, 23);
            this.cbxnbrequipe.TabIndex = 10;
            this.cbxnbrequipe.SelectedIndexChanged += new System.EventHandler(this.cbxnbrequipe_SelectedIndexChanged);
            // 
            // tbxnomequipe1
            // 
            this.tbxnomequipe1.Location = new System.Drawing.Point(162, 155);
            this.tbxnomequipe1.Name = "tbxnomequipe1";
            this.tbxnomequipe1.Size = new System.Drawing.Size(258, 20);
            this.tbxnomequipe1.TabIndex = 11;
            // 
            // tbxnomequipe3
            // 
            this.tbxnomequipe3.Location = new System.Drawing.Point(162, 202);
            this.tbxnomequipe3.Name = "tbxnomequipe3";
            this.tbxnomequipe3.Size = new System.Drawing.Size(258, 20);
            this.tbxnomequipe3.TabIndex = 12;
            // 
            // tbxnomequipe5
            // 
            this.tbxnomequipe5.Location = new System.Drawing.Point(162, 253);
            this.tbxnomequipe5.Name = "tbxnomequipe5";
            this.tbxnomequipe5.Size = new System.Drawing.Size(258, 20);
            this.tbxnomequipe5.TabIndex = 13;
            // 
            // tbxnomequipe4
            // 
            this.tbxnomequipe4.Location = new System.Drawing.Point(581, 202);
            this.tbxnomequipe4.Name = "tbxnomequipe4";
            this.tbxnomequipe4.Size = new System.Drawing.Size(207, 20);
            this.tbxnomequipe4.TabIndex = 14;
            // 
            // tbxnomequipe2
            // 
            this.tbxnomequipe2.Location = new System.Drawing.Point(581, 155);
            this.tbxnomequipe2.Name = "tbxnomequipe2";
            this.tbxnomequipe2.Size = new System.Drawing.Size(207, 20);
            this.tbxnomequipe2.TabIndex = 15;
            // 
            // lblnomequipe1
            // 
            this.lblnomequipe1.AutoSize = true;
            this.lblnomequipe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomequipe1.Location = new System.Drawing.Point(7, 155);
            this.lblnomequipe1.Name = "lblnomequipe1";
            this.lblnomequipe1.Size = new System.Drawing.Size(149, 20);
            this.lblnomequipe1.TabIndex = 16;
            this.lblnomequipe1.Text = "Nom pour l\'équipe 1";
            // 
            // lblnomequipe2
            // 
            this.lblnomequipe2.AutoSize = true;
            this.lblnomequipe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomequipe2.Location = new System.Drawing.Point(426, 153);
            this.lblnomequipe2.Name = "lblnomequipe2";
            this.lblnomequipe2.Size = new System.Drawing.Size(149, 20);
            this.lblnomequipe2.TabIndex = 17;
            this.lblnomequipe2.Text = "Nom pour l\'équipe 2";
            // 
            // lblnomequipe3
            // 
            this.lblnomequipe3.AutoSize = true;
            this.lblnomequipe3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomequipe3.Location = new System.Drawing.Point(7, 202);
            this.lblnomequipe3.Name = "lblnomequipe3";
            this.lblnomequipe3.Size = new System.Drawing.Size(149, 20);
            this.lblnomequipe3.TabIndex = 18;
            this.lblnomequipe3.Text = "Nom pour l\'équipe 3";
            // 
            // lblnomequipe4
            // 
            this.lblnomequipe4.AutoSize = true;
            this.lblnomequipe4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomequipe4.Location = new System.Drawing.Point(426, 202);
            this.lblnomequipe4.Name = "lblnomequipe4";
            this.lblnomequipe4.Size = new System.Drawing.Size(149, 20);
            this.lblnomequipe4.TabIndex = 19;
            this.lblnomequipe4.Text = "Nom pour l\'équipe 4";
            // 
            // lblnomequipe5
            // 
            this.lblnomequipe5.AutoSize = true;
            this.lblnomequipe5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomequipe5.Location = new System.Drawing.Point(7, 255);
            this.lblnomequipe5.Name = "lblnomequipe5";
            this.lblnomequipe5.Size = new System.Drawing.Size(149, 20);
            this.lblnomequipe5.TabIndex = 20;
            this.lblnomequipe5.Text = "Nom pour l\'équipe 5";
            // 
            // lblnomequipe6
            // 
            this.lblnomequipe6.AutoSize = true;
            this.lblnomequipe6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomequipe6.Location = new System.Drawing.Point(426, 255);
            this.lblnomequipe6.Name = "lblnomequipe6";
            this.lblnomequipe6.Size = new System.Drawing.Size(149, 20);
            this.lblnomequipe6.TabIndex = 21;
            this.lblnomequipe6.Text = "Nom pour l\'équipe 6";
            // 
            // tbxnomequipe6
            // 
            this.tbxnomequipe6.Location = new System.Drawing.Point(581, 253);
            this.tbxnomequipe6.Name = "tbxnomequipe6";
            this.tbxnomequipe6.Size = new System.Drawing.Size(207, 20);
            this.tbxnomequipe6.TabIndex = 22;
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(318, 313);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(184, 113);
            this.btnvalider.TabIndex = 23;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // FrmParaduclassement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvalider);
            this.Controls.Add(this.tbxnomequipe6);
            this.Controls.Add(this.lblnomequipe6);
            this.Controls.Add(this.lblnomequipe5);
            this.Controls.Add(this.lblnomequipe4);
            this.Controls.Add(this.lblnomequipe3);
            this.Controls.Add(this.lblnomequipe2);
            this.Controls.Add(this.lblnomequipe1);
            this.Controls.Add(this.tbxnomequipe2);
            this.Controls.Add(this.tbxnomequipe4);
            this.Controls.Add(this.tbxnomequipe5);
            this.Controls.Add(this.tbxnomequipe3);
            this.Controls.Add(this.tbxnomequipe1);
            this.Controls.Add(this.cbxnbrequipe);
            this.Controls.Add(this.lblnbrequipe);
            this.Controls.Add(this.chbSeul);
            this.Controls.Add(this.chbequipe);
            this.Controls.Add(this.lblSeul);
            this.Controls.Add(this.lblequipe);
            this.Controls.Add(this.cbxjeux);
            this.Controls.Add(this.LblJeux);
            this.Controls.Add(this.cbxjoueur);
            this.Controls.Add(this.LblNbrjoueur);
            this.Name = "FrmParaduclassement";
            this.Text = "Paramètre du classement";
            this.Load += new System.EventHandler(this.FrmParaduclassement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNbrjoueur;
        private System.Windows.Forms.ComboBox cbxjoueur;
        private System.Windows.Forms.Label LblJeux;
        private System.Windows.Forms.ComboBox cbxjeux;
        private System.Windows.Forms.Label lblequipe;
        private System.Windows.Forms.Label lblSeul;
        private System.Windows.Forms.CheckBox chbequipe;
        private System.Windows.Forms.CheckBox chbSeul;
        private System.Windows.Forms.Label lblnbrequipe;
        private System.Windows.Forms.ComboBox cbxnbrequipe;
        private System.Windows.Forms.TextBox tbxnomequipe1;
        private System.Windows.Forms.TextBox tbxnomequipe3;
        private System.Windows.Forms.TextBox tbxnomequipe5;
        private System.Windows.Forms.TextBox tbxnomequipe4;
        private System.Windows.Forms.TextBox tbxnomequipe2;
        private System.Windows.Forms.Label lblnomequipe1;
        private System.Windows.Forms.Label lblnomequipe2;
        private System.Windows.Forms.Label lblnomequipe3;
        private System.Windows.Forms.Label lblnomequipe4;
        private System.Windows.Forms.Label lblnomequipe5;
        private System.Windows.Forms.Label lblnomequipe6;
        private System.Windows.Forms.TextBox tbxnomequipe6;
        private System.Windows.Forms.Button btnvalider;
    }
}