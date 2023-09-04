namespace pryRaoInsEvaluativa
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.StaStrip = new System.Windows.Forms.StatusStrip();
            this.FechHoraStatustrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.activosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FechayHoraBien = new System.Windows.Forms.ToolStripStatusLabel();
            this.StaStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaStrip
            // 
            this.StaStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FechHoraStatustrip,
            this.FechayHoraBien});
            this.StaStrip.Location = new System.Drawing.Point(0, 470);
            this.StaStrip.Name = "StaStrip";
            this.StaStrip.Size = new System.Drawing.Size(460, 22);
            this.StaStrip.TabIndex = 0;
            this.StaStrip.Text = "statusStrip1";
            // 
            // FechHoraStatustrip
            // 
            this.FechHoraStatustrip.Name = "FechHoraStatustrip";
            this.FechHoraStatustrip.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.listadoReportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.gestionToolStripMenuItem.Text = "Gestion ";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeProveedoresToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // registroDeProveedoresToolStripMenuItem
            // 
            this.registroDeProveedoresToolStripMenuItem.Name = "registroDeProveedoresToolStripMenuItem";
            this.registroDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.registroDeProveedoresToolStripMenuItem.Text = "Registro de Proveedores";
            // 
            // listadoReportesToolStripMenuItem
            // 
            this.listadoReportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem1});
            this.listadoReportesToolStripMenuItem.Name = "listadoReportesToolStripMenuItem";
            this.listadoReportesToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.listadoReportesToolStripMenuItem.Text = "Listado/Reportes";
            // 
            // proveedoresToolStripMenuItem1
            // 
            this.proveedoresToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activosToolStripMenuItem});
            this.proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            this.proveedoresToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem1.Text = "Proveedores";
            // 
            // activosToolStripMenuItem
            // 
            this.activosToolStripMenuItem.Name = "activosToolStripMenuItem";
            this.activosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.activosToolStripMenuItem.Text = "Activos";
            // 
            // FechayHoraBien
            // 
            this.FechayHoraBien.Name = "FechayHoraBien";
            this.FechayHoraBien.Size = new System.Drawing.Size(27, 17);
            this.FechayHoraBien.Text = "----";
            this.FechayHoraBien.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 492);
            this.Controls.Add(this.StaStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Sistema de Gestion de Ventas de Seguros";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.StaStrip.ResumeLayout(false);
            this.StaStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StaStrip;
        private System.Windows.Forms.ToolStripStatusLabel FechHoraStatustrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem activosToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel FechayHoraBien;
    }
}

