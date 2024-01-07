namespace ProjetPerso
{
    partial class FormAjouterPartie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjouterPartie));
            this.lblAjouterPartie = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAjouterPartie
            // 
            this.lblAjouterPartie.AutoSize = true;
            this.lblAjouterPartie.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjouterPartie.Location = new System.Drawing.Point(337, 30);
            this.lblAjouterPartie.Name = "lblAjouterPartie";
            this.lblAjouterPartie.Size = new System.Drawing.Size(289, 39);
            this.lblAjouterPartie.TabIndex = 0;
            this.lblAjouterPartie.Text = "Ajouter une partie";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(785, 30);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(174, 39);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // FormAjouterPartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(998, 624);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblAjouterPartie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAjouterPartie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter une partie";
            this.Load += new System.EventHandler(this.FormAjouterPartie_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAjouterPartie;
        private System.Windows.Forms.Button btnValider;
    }
}