using BusinessLayer.DTOs.Customer;
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
    public partial class frmCustomer : Form
    {
        private readonly ICustomerService _service;

        public frmCustomer(ICustomerService service)
        {
            InitializeComponent();
            _service = service;
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

        private async Task ShowCustomers(string search = "")
        {
            var customers = await _service.GetAll(search);
            var listaVM = customers.Select(item => new CustomerVM
            {
                Id = item.Id,
                Name = item.Name,
                Code = item.Code,
                Address = item.Address,
                Email = item.Email,
                PhoneNumber = item.PhoneNumber,
                IsActive = item.IsActive,
                Enabled = item.IsActive ? "Si" : "No"
            }).ToList();
            dgvCustomers.DataSource = listaVM;

            dgvCustomers.Columns["Id"].Visible = false;
            dgvCustomers.Columns["IsActive"].Visible = false;
        }

        private async void frmCustomer_Load(object sender, EventArgs e)
        {
            ShowTab(tabLista.Name);
            dgvCustomers.ImplementarConfiguracion("Editar");
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            await ShowCustomers();

            OptionCombo[] itemsEnable = new OptionCombo[]
            {
                new OptionCombo { Texto = "Si", Valor = 1},
                new OptionCombo { Texto = "No", Valor = 0}
            };

            cbbEnable.InsertarItems(itemsEnable);
            txbEditPhoneNumber.ValidarNumero();
            txbNewPhoneNumber.ValidarNumero();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await ShowCustomers(txbSearch.Text);
        }

        private void btnNuevoLista_Click(object sender, EventArgs e)
        {
            txbNewName.Text = "";
            txbNewCode.Text = "";
            txbNewAddress.Text = "";
            txbNewEmail.Text = "";
            txbNewPhoneNumber.Text = "";
            ShowTab(tabNuevo.Name);
        }

        private void btnNewBack_Click(object sender, EventArgs e)
        {
            ShowTab(tabLista.Name);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (txbNewName.Text.Trim() == "")
            {
                MessageBox.Show("El nombre es requerido");
                return;
            }

            var customer = new CreateCustomerDto
            {
                Name = txbNewName.Text,
                Code = txbNewCode.Text,
                Address = txbNewAddress.Text,
                Email = txbNewEmail.Text,
                PhoneNumber = txbNewPhoneNumber.Text
            };

            var response = await _service.Add(customer);
            if (response != null) MessageBox.Show(response);
            else
            {
                await ShowCustomers();
                ShowTab(tabLista.Name);
            }
        }

        private void btnEditBack_Click(object sender, EventArgs e)
        {
            ShowTab(tabLista.Name);
        }


        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomers.Columns[e.ColumnIndex].Name == "ColumnaAcccion")
            {
                var customerSelected = (CustomerVM)dgvCustomers.CurrentRow.DataBoundItem;
                txbEditName.Text = customerSelected.Name.ToString();
                txbEditCode.Text = customerSelected.Code.ToString();
                txbEditAddress.Text = customerSelected.Address.ToString();
                txbEditEmail.Text = customerSelected.Email.ToString();
                txbEditPhoneNumber.Text = customerSelected.PhoneNumber.ToString();
                cbbEnable.EstablecerValor(customerSelected.IsActive ? 1 : 0);

                ShowTab(tabEdit.Name);
                txbEditName.Select();
            }
        }


        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbEditName.Text.Trim() == "")
            {
                MessageBox.Show("El nombre es requerido");
                return;
            }

            var customerSelect = (CustomerVM)dgvCustomers.CurrentRow.DataBoundItem;
            var customer = new UpdateCustomerDto
            {
                Id = customerSelect.Id,
                Name = txbEditName.Text,
                Code = txbEditCode.Text,
                Address = txbEditAddress.Text,
                Email = txbEditEmail.Text,
                PhoneNumber = txbEditPhoneNumber.Text,
                IsActive = ((OptionCombo)cbbEnable.SelectedItem!).Valor == 1
            };

            var response = await _service.Update(customer);
            if (response != null) MessageBox.Show(response);
            else
            {
                MessageBox.Show("Cliente creado satisfactoriamente");
                await ShowCustomers();
                ShowTab(tabLista.Name);
            }
        }
    }
}
