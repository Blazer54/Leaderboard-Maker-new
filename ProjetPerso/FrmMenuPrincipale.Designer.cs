namespace ProjetPerso
{
    partial class FrmMenuPrincipale
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
            this.btnAfficherClass = new System.Windows.Forms.Button();
            this.lblsbmanager = new System.Windows.Forms.Label();
            this.btnAddPartie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfficherClass
            // 
            this.btnAfficherClass.BackColor = System.Drawing.Color.Lime;
            this.btnAfficherClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAfficherClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficherClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherClass.Location = new System.Drawing.Point(12, 83);
            this.btnAfficherClass.Name = "btnAfficherClass";
            this.btnAfficherClass.Size = new System.Drawing.Size(374, 355);
            this.btnAfficherClass.TabIndex = 0;
            this.btnAfficherClass.Text = "Afficher le classement";
            this.btnAfficherClass.UseVisualStyleBackColor = false;
            this.btnAfficherClass.Click += new System.EventHandler(this.btnAfficherClass_Click);
            // 
            // lblsbmanager
            // 
            this.lblsbmanager.AutoSize = true;
            this.lblsbmanager.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsbmanager.Location = new System.Drawing.Point(223, 9);
            this.lblsbmanager.Name = "lblsbmanager";
            this.lblsbmanager.Size = new System.Drawing.Size(348, 42);
            this.lblsbmanager.TabIndex = 2;
            this.lblsbmanager.Text = "Scorboard manager";
            // 
            // btnAddPartie
            // 
            this.btnAddPartie.BackColor = System.Drawing.Color.Lime;
            this.btnAddPartie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPartie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPartie.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPartie.Location = new System.Drawing.Point(414, 83);
            this.btnAddPartie.Name = "btnAddPartie";
            this.btnAddPartie.Size = new System.Drawing.Size(374, 355);
            this.btnAddPartie.TabIndex = 3;
            this.btnAddPartie.Text = "Ajouter une partie";
            this.btnAddPartie.UseVisualStyleBackColor = false;
            this.btnAddPartie.Click += new System.EventHandler(this.btnAddPartie_Click);
            // 
            // FrmMenuPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddPartie);
            this.Controls.Add(this.lblsbmanager);
            this.Controls.Add(this.btnAfficherClass);
            this.Name = "FrmMenuPrincipale";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmMenuPrincipale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfficherClass;
        private System.Windows.Forms.Label lblsbmanager;
        private System.Windows.Forms.Button btnAddPartie;
    }
}