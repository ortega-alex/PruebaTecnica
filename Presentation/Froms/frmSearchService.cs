using BusinessLayer.Interfaces;
using Presentation.Utilities;
using Presentation.ViewModel;
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
    public partial class frmSearchService : Form
    {
        private readonly IServicesService _service;
        public ServiceVM _ServiceSelected { get; set; } = null!;

        public frmSearchService(IServicesService service)
        {
            InitializeComponent();
            _service = service;
        }

        private async Task ShowServices(string search = "")
        {
            var services = await _service.GetAll(search);
            var listaVM = services
                .Where(item => item.IsActive)
                .Select(item => new ServiceVM
                {
                    Id = item.Id,
                    Code = item.Code,
                    Description = item.Description,
                    MonthyCost = item.MonthyCost,

                    ServiceLocationId = item.ServiceLocationId,
                    City = item.City,
                    Zone = item.Zone,
                    Location = $"{item.City} - Zona: {item.Zone}",

                    ServiceSettingId = item.ServiceSettingId,
                    ServiceSetting = item.ServiceSetting,

                    ServiceTypeId = item.ServiceTypeId,
                    ServiceType = item.ServiceType
                }).ToList();

            dgvServices.DataSource = listaVM;

            dgvServices.Columns["Id"].Visible = false;
            dgvServices.Columns["ServiceLocationId"].Visible = false;
            dgvServices.Columns["ServiceSettingId"].Visible = false;
            dgvServices.Columns["ServiceTypeId"].Visible = false;
            dgvServices.Columns["IsActive"].Visible = false;
            dgvServices.Columns["City"].Visible = false;
            dgvServices.Columns["Zone"].Visible = false;
            dgvServices.Columns["Enabled"].Visible = false;
        }

        private void frmSearchService_Load(object sender, EventArgs e)
        {
            dgvServices.ImplementarConfiguracion();
            ShowServices();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await ShowServices(txbSearch.Text.Trim());
        }

        private void dgvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _ServiceSelected = (ServiceVM)dgvServices.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
