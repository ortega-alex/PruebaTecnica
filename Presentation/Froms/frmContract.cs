using AutoMapper;
using BusinessLayer.DTOs.Contract;
using BusinessLayer.DTOs.Service;
using BusinessLayer.Interfaces;
using DataLayer.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using Presentation.Utilities;
using Presentation.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Froms
{
    public partial class frmContract : Form
    {
        private readonly IContractService _contractService;
        private readonly ICustomerService _customerService;
        private readonly IServicesService _servicesService;
        private BindingList<ContractDetailVM> contractDetails = new BindingList<ContractDetailVM>();
        private readonly IServiceProvider _serviceProvider;

        public frmContract(IContractService contractService, ICustomerService customerService, IServicesService servicesService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _contractService = contractService;
            _customerService = customerService;
            _servicesService = servicesService;
            _serviceProvider = serviceProvider;
        }


        private async void frmContract_Load(object sender, EventArgs e)
        {
            dgvContractDetail.ImplementarConfiguracion("Eliminar");
            dgvContractDetail.DataSource = contractDetails;

            dgvContractDetail.Columns["ServiceId"].Visible = false;
            dgvContractDetail.Columns["Service"].Visible = false;

            dgvContractDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txbDiscountPercentage.ValidarNumero();
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Format = DateTimePickerFormat.Custom;

            dtpStartDate.CustomFormat = "yyyy-MM-dd";
            dtpEndDate.CustomFormat = "yyyy-MM-dd";

            var listCustomers = await _customerService.GetAll();
            var itemsCustomers = listCustomers.Select(item => new OptionCombo { Texto = item.Name, Valor = item.Id }).ToArray();

            cbbCustomer.InsertarItems(itemsCustomers);
        }

        private async Task AddServices(string code)
        {
            var service = await _servicesService.GetByCode(code);
            if (service == null)
            {
                txbServiceCode.BackColor = Color.FromArgb(255, 227, 227);
                return;
            }

            txbServiceCode.BackColor = SystemColors.Window;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(service.Description);
            sb.AppendLine("Tipo de servicio: " + service.ServiceSetting.Name);
            sb.AppendLine("Precio: " + service.MonthyCost.ToString("0.00"));
            sb.AppendLine();

            DialogResult result = MessageBox.Show(sb.ToString(), "Confirmar Servicio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                var encontrado = contractDetails.FirstOrDefault(x => x.ServiceId == service.Id);
                if (encontrado == null)
                {
                    contractDetails.Add(new ContractDetailVM
                    {
                        Service = service,
                        ServiceId = service.Id,
                        ServiceName = service.Description,
                        ServiceType = service.ServiceType.Name,
                        ServiceSetting = service.ServiceSetting.Name,
                        Price = service.MonthyCost.ToString("0.00"),
                        DisconuntPercentage = "0.00",
                        BillingFrequency = "Mensual"
                    });
                }
                else
                {
                    MessageBox.Show("El servicio ya esta agregado al contrato");
                }
            }
        }

        private async void txbServiceCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                await AddServices(txbServiceCode.Text.Trim());
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (contractDetails.Count == 0)
            {
                MessageBox.Show("No hay servicios");
                return;
            }

            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.", "Error de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal discount = 0;
            if (txbDiscountPercentage.Text.Trim() != "" && !decimal.TryParse(txbDiscountPercentage.Text.Trim(), out discount))
            {
                MessageBox.Show("El descuento no tiene un formato valido");
                return;
            }

            List<CreateContractDetailDto> detail = new List<CreateContractDetailDto>();
            foreach (ContractDetailVM item in contractDetails)
            {
                detail.Add(
                    new CreateContractDetailDto
                    {
                        ServiceId = item.Service.Id,
                        Price = Convert.ToDecimal(item.Price),
                        DisconuntPercentage = Convert.ToDecimal(item.DisconuntPercentage),
                        BillingFrequency = item.BillingFrequency
                    }
                );
            }

            var Contract = new CreateContractDto
            {
                CustomerId = ((OptionCombo)cbbCustomer.SelectedItem!).Valor,
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value,
                PayPeriod = txbPayPeriod.Text.Trim(),
                DisconuntPercentage = discount,
                ContractDetails = detail
            };

            var response = await _contractService.Add(Contract);
            if (response != null) MessageBox.Show(response);
            else
            {
                MessageBox.Show("Contrato agregado correctamente");
                cbbCustomer.SelectedIndex = 0;
                txbServiceCode.Text = "";
                dtpStartDate.Value = DateTime.Now;
                dtpEndDate.Value = DateTime.Now;
                txbDiscountPercentage.Text = "";
                txbPayPeriod.Text = "";
                contractDetails.Clear();
                cbbCustomer.Select();
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var _formSearchService = _serviceProvider.GetRequiredService<frmSearchService>();
            var result = _formSearchService.ShowDialog();
            if (result == DialogResult.OK)
            {
                var serviceSelected = _formSearchService._ServiceSelected;
                txbServiceCode.Text = serviceSelected.Code;
                await AddServices(serviceSelected.Code);
            }
        }
    }
}
