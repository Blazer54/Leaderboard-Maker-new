namespace ProjetPerso
{
    partial class FrmSystPoint
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
            this.lblelim = new System.Windows.Forms.Label();
            this.tbxptselim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Lime;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(265, 331);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(256, 107);
            this.btnValider.TabIndex = 14;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblelim
            // 
            this.lblelim.AutoSize = true;
            this.lblelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblelim.Location = new System.Drawing.Point(507, 101);
            this.lblelim.Name = "lblelim";
            this.lblelim.Size = new System.Drawing.Size(237, 25);
            this.lblelim.TabIndex = 15;
            this.lblelim.Text = "Point pour 1 élimination";
            // 
            // tbxptselim
            // 
            this.tbxptselim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxptselim.Location = new System.Drawing.Point(579, 129);
            this.tbxptselim.Name = "tbxptselim";
            this.tbxptselim.Size = new System.Drawing.Size(100, 31);
            this.tbxptselim.TabIndex = 16;
            // 
            // FrmSystPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxptselim);
            this.Controls.Add(this.lblelim);
            this.Controls.Add(this.btnValider);
            this.Name = "FrmSystPoint";
            this.Load += new System.EventHandler(this.FrmSystPoint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblelim;
        private System.Windows.Forms.TextBox tbxptselim;
    }
}