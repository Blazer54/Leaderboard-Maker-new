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
            this.lblInfoJoueur = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
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
            this.btnValider.Location = new System.Drawing.Point(472, 443);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(142, 75);
            this.btnValider.TabIndex = 31;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // FrmInfoJoueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1077, 564);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblInfoJoueur);
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
    }
}