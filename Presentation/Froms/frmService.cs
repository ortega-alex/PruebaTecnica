using BusinessLayer.DTOs.Service;
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
    public partial class frmService : Form
    {
        private readonly IServicesService _service;
        private readonly IServiceLocationService _locationService;
        private readonly IServiceTypeService _typeService;
        private readonly IServiceSettingService _settingService;

        public frmService(IServicesService service, IServiceLocationService locationService, IServiceTypeService typeService, IServiceSettingService settingService)
        {
            InitializeComponent();
            _service = service;
            _locationService = locationService;
            _typeService = typeService;
            _settingService = settingService;
        }


        public void ShowTab(string tabName)
        {
            var TabsMenu = new TabPage[] { tabLista, tabNuevo, tabEdit };
            foreach (var tab in TabsMenu)
            {
                if (tab.Name != tabName)
                    tab.Parent = null;
                else
                    tab.Parent = tabControlMain;
            }
        }

        private async Task ShowServices(string search = "")
        {
            var services = await _service.GetAll(search);
            var listaVM = services.Select(item => new ServiceVM
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
                ServiceType = item.ServiceType,

                IsActive = item.IsActive,
                Enabled = item.IsActive ? "Si" : "No"
            }).ToList();
            dgvServices.DataSource = listaVM;

            dgvServices.Columns["Id"].Visible = false;
            dgvServices.Columns["ServiceLocationId"].Visible = false;
            dgvServices.Columns["ServiceSettingId"].Visible = false;
            dgvServices.Columns["ServiceTypeId"].Visible = false;
            dgvServices.Columns["IsActive"].Visible = false;
            dgvServices.Columns["City"].Visible = false;
            dgvServices.Columns["Zone"].Visible = false;
        }

        private async void frmService_Load(object sender, EventArgs e)
        {
            ShowTab(tabLista.Name);
            dgvServices.ImplementarConfiguracion("Editar");
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txbNewMonthyCost.ValidarNumero();
            txbEditMonthyCost.ValidarNumero();
            await ShowServices();

            OptionCombo[] itemsEnable = new OptionCombo[]
            {
                new OptionCombo { Texto = "Si", Valor = 1},
                new OptionCombo { Texto = "No", Valor = 0}
            };

            var listTypes = await _typeService.GetAll();
            var itemsType = listTypes.Select(item => new OptionCombo { Texto = item.Name, Valor = item.Id }).ToArray();

            var listSettings = await _settingService.GetAll();
            var itemsSettings = listSettings.Select(item => new OptionCombo { Texto = item.Name, Valor = item.Id }).ToArray();

            var listLocations = await _locationService.GetAll();
            var itemsLocations = listLocations.Select(item => new OptionCombo { Texto = $"{item.City} - {item.Zone}", Valor = item.Id }).ToArray();

            cbbEnable.InsertarItems(itemsEnable);
            cmbNewServiceType.InsertarItems(itemsType);
            cmbEditServiceType.InsertarItems(itemsType);
            cmbNewSerbiceSetting.InsertarItems(itemsSettings);
            cmbEditServiceSetting.InsertarItems(itemsSettings);
            cmbNewServieLocation.InsertarItems(itemsLocations);
            cmbEditServiceLocation.InsertarItems(itemsLocations);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await ShowServices(txbSearch.Text);
        }

        private void btnNuevoLista_Click(object sender, EventArgs e)
        {
            txbNewDescription.Text = "";
            txbNewMonthyCost.Text = "";
            cmbNewServiceType.SelectedIndex = 0;
            cmbNewSerbiceSetting.SelectedIndex = 0;
            cmbNewServieLocation.SelectedIndex = 0;

            ShowTab(tabNuevo.Name);
            txbNewDescription.Select();
        }

        private void btnNewBack_Click(object sender, EventArgs e)
        {
            ShowTab(tabLista.Name);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (txbNewCode.Text.Trim() == "")
            {
                MessageBox.Show("El codigo es requerido");
                return;
            }

            if (txbNewDescription.Text.Trim() == "")
            {
                MessageBox.Show("La descripcion es requerida");
                return;
            }

            if (txbNewMonthyCost.Text.Trim() == "")
            {
                MessageBox.Show("La mensualidad es requerida");
                return;
            }

            decimal monthyCost = 0;
            if (!decimal.TryParse(txbNewMonthyCost.Text, out monthyCost))
            {
                MessageBox.Show("Mensuadidad - formato moneda incorrecto", "Memsaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbNewMonthyCost.Select();
                return;
            }

            var service = new CreateServiceDto
            {
                Code = txbNewCode.Text.Trim(),
                Description = txbNewDescription.Text.Trim(),
                MonthyCost = monthyCost,
                ServiceLocationId = ((OptionCombo)cmbNewServieLocation.SelectedItem!).Valor,
                ServiceTypeId = ((OptionCombo)cmbNewServiceType.SelectedItem!).Valor,
                ServiceSettingId = ((OptionCombo)cmbNewSerbiceSetting.SelectedItem!).Valor
            };

            var response = await _service.Add(service);
            if (response != null) MessageBox.Show(response);
            else
            {
                await ShowServices();
                ShowTab(tabLista.Name);
            }
        }

        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvServices.Columns[e.ColumnIndex].Name == "ColumnaAcccion")
            {
                var serviceSelected = (ServiceVM)dgvServices.CurrentRow.DataBoundItem;

                txbEditDescription.Text = serviceSelected.Description;
                txbEditMonthyCost.Text = serviceSelected.MonthyCost.ToString("0.00");
                cmbEditServiceType.EstablecerValor(serviceSelected.ServiceTypeId);
                cmbEditServiceLocation.EstablecerValor(serviceSelected.ServiceLocationId);
                cmbEditServiceSetting.EstablecerValor(serviceSelected.ServiceSettingId);
                cbbEnable.EstablecerValor(serviceSelected.IsActive ? 1 : 0);

                ShowTab(tabEdit.Name);
                txbEditDescription.Select();
            }
        }

        private void btnEditBack_Click(object sender, EventArgs e)
        {
            ShowTab(tabLista.Name);
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbEditCode.Text.Trim() == "")
            {
                MessageBox.Show("El codigo es requerido");
                return;
            }

            if (txbEditDescription.Text.Trim() == "")
            {
                MessageBox.Show("La descripcion es requerida");
                return;
            }

            if (txbEditMonthyCost.Text.Trim() == "")
            {
                MessageBox.Show("La mensualidad es requerida");
                return;
            }

            decimal monthyCost = 0;
            if (!decimal.TryParse(txbEditMonthyCost.Text, out monthyCost))
            {
                MessageBox.Show("Mensuadidad - formato moneda incorrecto", "Memsaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbEditMonthyCost.Select();
                return;
            }

            var serviceSelected = (ServiceVM)dgvServices.CurrentRow.DataBoundItem;
            var service = new UpdateServiceDto
            {
                Id = serviceSelected.Id,
                Code = txbEditCode.Text.Trim(),
                Description = txbEditDescription.Text.Trim(),
                MonthyCost = monthyCost,
                ServiceLocationId = ((OptionCombo)cmbEditServiceLocation.SelectedItem!).Valor,
                ServiceTypeId = ((OptionCombo)cmbEditServiceType.SelectedItem!).Valor,
                ServiceSettingId = ((OptionCombo)cmbEditServiceSetting.SelectedItem!).Valor
            };

            var response = await _service.Update(service);
            if (response != null) MessageBox.Show(response);
            else
            {
                await ShowServices();
                ShowTab(tabLista.Name);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
