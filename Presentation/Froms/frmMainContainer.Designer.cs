namespace Presentation.Froms
{
    partial class frmMainContainer
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            seToolStripMenuItem = new ToolStripMenuItem();
            contratoToolStripMenuItem = new ToolStripMenuItem();
            pnlMain = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, seToolStripMenuItem, contratoToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(50, 20);
            toolStripMenuItem1.Text = "Menu";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(121, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // seToolStripMenuItem
            // 
            seToolStripMenuItem.Name = "seToolStripMenuItem";
            seToolStripMenuItem.Size = new Size(121, 22);
            seToolStripMenuItem.Text = "Servicios";
            seToolStripMenuItem.Click += seToolStripMenuItem_Click;
            // 
            // contratoToolStripMenuItem
            // 
            contratoToolStripMenuItem.Name = "contratoToolStripMenuItem";
            contratoToolStripMenuItem.Size = new Size(121, 22);
            contratoToolStripMenuItem.Text = "Contrato";
            contratoToolStripMenuItem.Click += contratoToolStripMenuItem_Click;
            // 
            // pnlMain
            // 
            pnlMain.Location = new Point(18, 27);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(764, 407);
            pnlMain.TabIndex = 1;
            // 
            // frmMainContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMainContainer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prueba";
            Load += frmMainContainer_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem seToolStripMenuItem;
        private ToolStripMenuItem contratoToolStripMenuItem;
        private Panel pnlMain;
    }
}