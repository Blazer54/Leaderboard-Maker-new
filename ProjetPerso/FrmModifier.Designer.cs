namespace ProjetPerso
{
    partial class FrmModifier
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
            this.btnValider = new System.Windows.Forms.Button();
            this.lblInfoJoueur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(784, 29);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(142, 75);
            this.btnValider.TabIndex = 69;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // lblInfoJoueur
            // 
            this.lblInfoJoueur.AutoSize = true;
            this.lblInfoJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoJoueur.Location = new System.Drawing.Point(380, 36);
            this.lblInfoJoueur.Name = "lblInfoJoueur";
            this.lblInfoJoueur.Size = new System.Drawing.Size(350, 42);
            this.lblInfoJoueur.TabIndex = 38;
            this.lblInfoJoueur.Text = "Modifier les équipes";
            // 
            // FrmModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1077, 564);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblInfoJoueur);
            this.Name = "FrmModifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier";
            this.Load += new System.EventHandler(this.FrmModifier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblInfoJoueur;
    }
}