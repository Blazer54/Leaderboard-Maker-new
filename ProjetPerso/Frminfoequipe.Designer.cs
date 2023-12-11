namespace ProjetPerso
{
    partial class Frminfoequipe
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
            this.lbljoueur6equip6 = new System.Windows.Forms.Label();
            this.lbljoueur6equip5 = new System.Windows.Forms.Label();
            this.lbljoueur6equip4 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbljoueur6equip6
            // 
            this.lbljoueur6equip6.AutoSize = true;
            this.lbljoueur6equip6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljoueur6equip6.Location = new System.Drawing.Point(769, 411);
            this.lbljoueur6equip6.Name = "lbljoueur6equip6";
            this.lbljoueur6equip6.Size = new System.Drawing.Size(0, 20);
            this.lbljoueur6equip6.TabIndex = 134;
            // 
            // lbljoueur6equip5
            // 
            this.lbljoueur6equip5.AutoSize = true;
            this.lbljoueur6equip5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljoueur6equip5.Location = new System.Drawing.Point(482, 411);
            this.lbljoueur6equip5.Name = "lbljoueur6equip5";
            this.lbljoueur6equip5.Size = new System.Drawing.Size(0, 20);
            this.lbljoueur6equip5.TabIndex = 120;
            // 
            // lbljoueur6equip4
            // 
            this.lbljoueur6equip4.AutoSize = true;
            this.lbljoueur6equip4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljoueur6equip4.Location = new System.Drawing.Point(179, 411);
            this.lbljoueur6equip4.Name = "lbljoueur6equip4";
            this.lbljoueur6equip4.Size = new System.Drawing.Size(0, 20);
            this.lbljoueur6equip4.TabIndex = 107;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(557, 448);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(229, 104);
            this.btnValider.TabIndex = 135;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(183, 448);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(229, 104);
            this.btnModifier.TabIndex = 136;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // Frminfoequipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1077, 564);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lbljoueur6equip6);
            this.Controls.Add(this.lbljoueur6equip5);
            this.Controls.Add(this.lbljoueur6equip4);
            this.Name = "Frminfoequipe";
            this.Text = "infoequipe";
            this.Load += new System.EventHandler(this.Frminfoequipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbljoueur6equip6;
        private System.Windows.Forms.Label lbljoueur6equip5;
        private System.Windows.Forms.Label lbljoueur6equip4;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnModifier;
    }
}