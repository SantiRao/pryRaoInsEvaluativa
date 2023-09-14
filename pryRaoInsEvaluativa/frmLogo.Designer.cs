namespace pryRaoInsEvaluativa
{
    partial class frmLogo
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
            this.components = new System.ComponentModel.Container();
            this.LBLnOMBRE = new System.Windows.Forms.Label();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LBLnOMBRE
            // 
            this.LBLnOMBRE.AutoSize = true;
            this.LBLnOMBRE.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLnOMBRE.Location = new System.Drawing.Point(101, 276);
            this.LBLnOMBRE.Name = "LBLnOMBRE";
            this.LBLnOMBRE.Size = new System.Drawing.Size(278, 36);
            this.LBLnOMBRE.TabIndex = 0;
            this.LBLnOMBRE.Text = "VRAO\'S SECURES";
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // frmLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryRaoInsEvaluativa.Properties.Resources.lgoempresa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(460, 348);
            this.Controls.Add(this.LBLnOMBRE);
            this.Name = "frmLogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VRAO\'S SECURES";
            this.Load += new System.EventHandler(this.frmLogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLnOMBRE;
        private System.Windows.Forms.Timer Temporizador;
    }
}