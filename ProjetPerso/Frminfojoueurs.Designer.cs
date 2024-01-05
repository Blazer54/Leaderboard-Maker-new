namespace ProjetPerso
{
    partial class FrmInfoJoueurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfoJoueurs));
            this.lblInfoJoueur = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.tbxNone = new System.Windows.Forms.TextBox();
            this.cbxNone = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblInfoJoueur
            // 
            this.lblInfoJoueur.AutoSize = true;
            this.lblInfoJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoJoueur.Location = new System.Drawing.Point(350, 22);
            this.lblInfoJoueur.Name = "lblInfoJoueur";
            this.lblInfoJoueur.Size = new System.Drawing.Size(354, 42);
            this.lblInfoJoueur.TabIndex = 0;
            this.lblInfoJoueur.Text = "Informations joueurs";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(36, 15);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(142, 75);
            this.btnValider.TabIndex = 31;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // tbxNone
            // 
            this.tbxNone.Location = new System.Drawing.Point(999, 54);
            this.tbxNone.Multiline = true;
            this.tbxNone.Name = "tbxNone";
            this.tbxNone.Size = new System.Drawing.Size(23, 10);
            this.tbxNone.TabIndex = 32;
            // 
            // cbxNone
            // 
            this.cbxNone.FormattingEnabled = true;
            this.cbxNone.Location = new System.Drawing.Point(1003, 81);
            this.cbxNone.Name = "cbxNone";
            this.cbxNone.Size = new System.Drawing.Size(19, 21);
            this.cbxNone.TabIndex = 33;
            // 
            // FrmInfoJoueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1077, 564);
            this.Controls.Add(this.cbxNone);
            this.Controls.Add(this.tbxNone);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblInfoJoueur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInfoJoueurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information sur les joueurs";
            this.Load += new System.EventHandler(this.FrmInfoJoueurs_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoJoueur;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox tbxNone;
        private System.Windows.Forms.ComboBox cbxNone;
    }
}