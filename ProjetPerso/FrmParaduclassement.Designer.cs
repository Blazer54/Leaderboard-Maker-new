﻿namespace ProjetPerso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParaduclassement));
            this.LblNbrjoueur = new System.Windows.Forms.Label();
            this.LblJeux = new System.Windows.Forms.Label();
            this.cbxjeux = new System.Windows.Forms.ComboBox();
            this.lblequipe = new System.Windows.Forms.Label();
            this.chbequipe = new System.Windows.Forms.CheckBox();
            this.lblnbrequipe = new System.Windows.Forms.Label();
            this.btnvalider = new System.Windows.Forms.Button();
            this.tbxnbrequipe = new System.Windows.Forms.TextBox();
            this.btnValidernbrequipe = new System.Windows.Forms.Button();
            this.tbxnbrjoueur = new System.Windows.Forms.TextBox();
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
            this.cbxjeux.BackColor = System.Drawing.Color.Chartreuse;
            this.cbxjeux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // chbequipe
            // 
            this.chbequipe.AutoSize = true;
            this.chbequipe.BackColor = System.Drawing.Color.Chartreuse;
            this.chbequipe.Location = new System.Drawing.Point(94, 63);
            this.chbequipe.Name = "chbequipe";
            this.chbequipe.Size = new System.Drawing.Size(15, 14);
            this.chbequipe.TabIndex = 7;
            this.chbequipe.UseVisualStyleBackColor = false;
            this.chbequipe.CheckedChanged += new System.EventHandler(this.chbequipe_CheckedChanged);
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
            // btnvalider
            // 
            this.btnvalider.BackColor = System.Drawing.Color.Lime;
            this.btnvalider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvalider.Location = new System.Drawing.Point(25, 125);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(184, 113);
            this.btnvalider.TabIndex = 23;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = false;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // tbxnbrequipe
            // 
            this.tbxnbrequipe.BackColor = System.Drawing.Color.Chartreuse;
            this.tbxnbrequipe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxnbrequipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxnbrequipe.Location = new System.Drawing.Point(646, 59);
            this.tbxnbrequipe.Name = "tbxnbrequipe";
            this.tbxnbrequipe.Size = new System.Drawing.Size(141, 21);
            this.tbxnbrequipe.TabIndex = 24;
            this.tbxnbrequipe.TextChanged += new System.EventHandler(this.tbxnbrequipe_TextChanged);
            // 
            // btnValidernbrequipe
            // 
            this.btnValidernbrequipe.BackColor = System.Drawing.Color.Chartreuse;
            this.btnValidernbrequipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidernbrequipe.Location = new System.Drawing.Point(677, 83);
            this.btnValidernbrequipe.Name = "btnValidernbrequipe";
            this.btnValidernbrequipe.Size = new System.Drawing.Size(75, 23);
            this.btnValidernbrequipe.TabIndex = 25;
            this.btnValidernbrequipe.Text = "Valider";
            this.btnValidernbrequipe.UseVisualStyleBackColor = false;
            this.btnValidernbrequipe.Click += new System.EventHandler(this.btnValidernbrequipe_Click);
            // 
            // tbxnbrjoueur
            // 
            this.tbxnbrjoueur.BackColor = System.Drawing.Color.Chartreuse;
            this.tbxnbrjoueur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxnbrjoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxnbrjoueur.Location = new System.Drawing.Point(162, 20);
            this.tbxnbrjoueur.Name = "tbxnbrjoueur";
            this.tbxnbrjoueur.Size = new System.Drawing.Size(141, 21);
            this.tbxnbrjoueur.TabIndex = 26;
            // 
            // FrmParaduclassement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxnbrjoueur);
            this.Controls.Add(this.btnValidernbrequipe);
            this.Controls.Add(this.tbxnbrequipe);
            this.Controls.Add(this.btnvalider);
            this.Controls.Add(this.lblnbrequipe);
            this.Controls.Add(this.chbequipe);
            this.Controls.Add(this.lblequipe);
            this.Controls.Add(this.cbxjeux);
            this.Controls.Add(this.LblJeux);
            this.Controls.Add(this.LblNbrjoueur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmParaduclassement";
            this.Text = "Paramètre du classement";
            this.Load += new System.EventHandler(this.FrmParaduclassement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNbrjoueur;
        private System.Windows.Forms.Label LblJeux;
        private System.Windows.Forms.ComboBox cbxjeux;
        private System.Windows.Forms.Label lblequipe;
        private System.Windows.Forms.CheckBox chbequipe;
        private System.Windows.Forms.Label lblnbrequipe;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.TextBox tbxnbrequipe;
        private System.Windows.Forms.Button btnValidernbrequipe;
        private System.Windows.Forms.TextBox tbxnbrjoueur;
    }
}