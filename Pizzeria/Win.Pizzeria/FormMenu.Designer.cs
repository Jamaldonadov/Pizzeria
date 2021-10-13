namespace Win.Pizzeria
{
    partial class FormMenu
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuestrasPizzasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuestrosPostresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bebidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suministrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perecederoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 662);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(627, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.suministrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(627, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuestrasPizzasToolStripMenuItem,
            this.nuestrosPostresToolStripMenuItem,
            this.bebidasToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // nuestrasPizzasToolStripMenuItem
            // 
            this.nuestrasPizzasToolStripMenuItem.Name = "nuestrasPizzasToolStripMenuItem";
            this.nuestrasPizzasToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.nuestrasPizzasToolStripMenuItem.Text = "Nuestras Pizzas";
            this.nuestrasPizzasToolStripMenuItem.Click += new System.EventHandler(this.nuestrasPizzasToolStripMenuItem_Click);
            // 
            // nuestrosPostresToolStripMenuItem
            // 
            this.nuestrosPostresToolStripMenuItem.Name = "nuestrosPostresToolStripMenuItem";
            this.nuestrosPostresToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.nuestrosPostresToolStripMenuItem.Text = "Nuestros Postres";
            this.nuestrosPostresToolStripMenuItem.Click += new System.EventHandler(this.nuestrosPostresToolStripMenuItem_Click);
            // 
            // bebidasToolStripMenuItem
            // 
            this.bebidasToolStripMenuItem.Name = "bebidasToolStripMenuItem";
            this.bebidasToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.bebidasToolStripMenuItem.Text = "Bebidas";
            this.bebidasToolStripMenuItem.Click += new System.EventHandler(this.bebidasToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDePagoToolStripMenuItem});
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // suministrosToolStripMenuItem
            // 
            this.suministrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipoToolStripMenuItem,
            this.perecederoToolStripMenuItem});
            this.suministrosToolStripMenuItem.Name = "suministrosToolStripMenuItem";
            this.suministrosToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.suministrosToolStripMenuItem.Text = "Suministros";
            // 
            // equipoToolStripMenuItem
            // 
            this.equipoToolStripMenuItem.Name = "equipoToolStripMenuItem";
            this.equipoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.equipoToolStripMenuItem.Text = "Equipo";
            this.equipoToolStripMenuItem.Click += new System.EventHandler(this.equipoToolStripMenuItem_Click);
            // 
            // perecederoToolStripMenuItem
            // 
            this.perecederoToolStripMenuItem.Name = "perecederoToolStripMenuItem";
            this.perecederoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.perecederoToolStripMenuItem.Text = "Perecedero";
            this.perecederoToolStripMenuItem.Click += new System.EventHandler(this.perecederoToolStripMenuItem_Click);
            // 
            // tiposDePagoToolStripMenuItem
            // 
            this.tiposDePagoToolStripMenuItem.Name = "tiposDePagoToolStripMenuItem";
            this.tiposDePagoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.tiposDePagoToolStripMenuItem.Text = "Tipos de pago";
            this.tiposDePagoToolStripMenuItem.Click += new System.EventHandler(this.tiposDePagoToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 684);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuestrasPizzasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuestrosPostresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bebidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suministrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perecederoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDePagoToolStripMenuItem;
    }
}