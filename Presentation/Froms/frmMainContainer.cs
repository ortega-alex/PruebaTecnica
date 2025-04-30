using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Froms
{
    public partial class frmMainContainer : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private Form _activeForm = null;

        public frmMainContainer(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
                    }

        private void ShowFrmContainer(Form frm)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            _activeForm = frm;

            // Establece el formulario para que no sea un control de nivel superior
            frm.TopLevel = false;
            // Establece el formulario como hijo del panel contenedor
            frm.FormBorderStyle = FormBorderStyle.None; // Opcional: Quita los bordes del formulario hijo
            frm.Dock = DockStyle.Fill; // Opcional: Rellena el panel contenedor
            pnlMain.Controls.Add(frm);
            pnlMain.Tag = frm; // Opcional: Guarda una referencia al formulario actual
            pnlMain.BringToFront();
            // pnlMain.Show();
            frm.Show();
        }

        private void seToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrmContainer(_serviceProvider.GetRequiredService<frmService>());
        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrmContainer(_serviceProvider.GetRequiredService<frmContract>());
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrmContainer(_serviceProvider.GetRequiredService<frmCustomer>());
        }

        private void frmMainContainer_Load(object sender, EventArgs e)
        {

        }
    }
}
