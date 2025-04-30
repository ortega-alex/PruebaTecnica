namespace Presentation.Froms
{
    partial class frmCustomer
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
            label1 = new Label();
            label2 = new Label();
            btnEditBack = new Button();
            btnSave = new Button();
            btnNewBack = new Button();
            tabEdit = new TabPage();
            btnUpdate = new Button();
            txbEditEmail = new TextBox();
            label13 = new Label();
            txbEditPhoneNumber = new TextBox();
            label4 = new Label();
            txbEditAddress = new TextBox();
            label5 = new Label();
            txbEditCode = new TextBox();
            label10 = new Label();
            txbEditName = new TextBox();
            label11 = new Label();
            cbbEnable = new ComboBox();
            label6 = new Label();
            txbNewName = new TextBox();
            tabNuevo = new TabPage();
            txbNewPhoneNumber = new TextBox();
            label12 = new Label();
            txbNewEmail = new TextBox();
            label9 = new Label();
            txbNewAddress = new TextBox();
            label8 = new Label();
            txbNewCode = new TextBox();
            label3 = new Label();
            label7 = new Label();
            dgvCustomers = new DataGridView();
            btnBuscar = new Button();
            txbSearch = new TextBox();
            btnNuevoLista = new Button();
            tabLista = new TabPage();
            tabControlMain = new TabControl();
            tabEdit.SuspendLayout();
            tabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            tabLista.SuspendLayout();
            tabControlMain.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Clientes";
            // 
            // btnEditBack
            // 
            btnEditBack.Cursor = Cursors.Hand;
            btnEditBack.FlatStyle = FlatStyle.Flat;
            btnEditBack.Location = new Point(16, 287);
            btnEditBack.Name = "btnEditBack";
            btnEditBack.Size = new Size(75, 23);
            btnEditBack.TabIndex = 10;
            btnEditBack.Text = "Volver";
            btnEditBack.UseVisualStyleBackColor = true;
            btnEditBack.Click += btnEditBack_Click;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.FromArgb(30, 90, 195);
            btnSave.Location = new Point(637, 287);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnNewBack
            // 
            btnNewBack.Cursor = Cursors.Hand;
            btnNewBack.FlatStyle = FlatStyle.Flat;
            btnNewBack.Location = new Point(18, 287);
            btnNewBack.Name = "btnNewBack";
            btnNewBack.Size = new Size(75, 23);
            btnNewBack.TabIndex = 4;
            btnNewBack.Text = "Volver";
            btnNewBack.UseVisualStyleBackColor = true;
            btnNewBack.Click += btnNewBack_Click;
            // 
            // tabEdit
            // 
            tabEdit.Controls.Add(btnUpdate);
            tabEdit.Controls.Add(txbEditEmail);
            tabEdit.Controls.Add(label13);
            tabEdit.Controls.Add(txbEditPhoneNumber);
            tabEdit.Controls.Add(label4);
            tabEdit.Controls.Add(txbEditAddress);
            tabEdit.Controls.Add(label5);
            tabEdit.Controls.Add(txbEditCode);
            tabEdit.Controls.Add(label10);
            tabEdit.Controls.Add(txbEditName);
            tabEdit.Controls.Add(label11);
            tabEdit.Controls.Add(cbbEnable);
            tabEdit.Controls.Add(label6);
            tabEdit.Controls.Add(btnEditBack);
            tabEdit.Location = new Point(4, 24);
            tabEdit.Name = "tabEdit";
            tabEdit.Padding = new Padding(3);
            tabEdit.Size = new Size(732, 316);
            tabEdit.TabIndex = 2;
            tabEdit.Text = "Editar";
            tabEdit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.FromArgb(30, 90, 195);
            btnUpdate.Location = new Point(638, 287);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Guardar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txbEditEmail
            // 
            txbEditEmail.Location = new Point(18, 170);
            txbEditEmail.Name = "txbEditEmail";
            txbEditEmail.Size = new Size(694, 23);
            txbEditEmail.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 155);
            label13.Name = "label13";
            label13.Size = new Size(46, 15);
            label13.TabIndex = 22;
            label13.Text = "Correo:";
            // 
            // txbEditPhoneNumber
            // 
            txbEditPhoneNumber.Location = new Point(18, 211);
            txbEditPhoneNumber.Name = "txbEditPhoneNumber";
            txbEditPhoneNumber.Size = new Size(694, 23);
            txbEditPhoneNumber.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 196);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 20;
            label4.Text = "Numero de Telefono:";
            // 
            // txbEditAddress
            // 
            txbEditAddress.Location = new Point(17, 127);
            txbEditAddress.Name = "txbEditAddress";
            txbEditAddress.Size = new Size(694, 23);
            txbEditAddress.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 112);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 18;
            label5.Text = "Dirección:";
            // 
            // txbEditCode
            // 
            txbEditCode.Location = new Point(18, 79);
            txbEditCode.Name = "txbEditCode";
            txbEditCode.Size = new Size(694, 23);
            txbEditCode.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 64);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 16;
            label10.Text = "Codigo:";
            // 
            // txbEditName
            // 
            txbEditName.Location = new Point(19, 31);
            txbEditName.Name = "txbEditName";
            txbEditName.Size = new Size(694, 23);
            txbEditName.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 16);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 14;
            label11.Text = "Nombre:";
            // 
            // cbbEnable
            // 
            cbbEnable.Cursor = Cursors.Hand;
            cbbEnable.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbEnable.FormattingEnabled = true;
            cbbEnable.Location = new Point(16, 253);
            cbbEnable.Name = "cbbEnable";
            cbbEnable.Size = new Size(694, 23);
            cbbEnable.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 238);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 12;
            label6.Text = "Habilitado:";
            // 
            // txbNewName
            // 
            txbNewName.Location = new Point(14, 28);
            txbNewName.Name = "txbNewName";
            txbNewName.Size = new Size(694, 23);
            txbNewName.TabIndex = 1;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(txbNewPhoneNumber);
            tabNuevo.Controls.Add(label12);
            tabNuevo.Controls.Add(txbNewEmail);
            tabNuevo.Controls.Add(label9);
            tabNuevo.Controls.Add(txbNewAddress);
            tabNuevo.Controls.Add(label8);
            tabNuevo.Controls.Add(txbNewCode);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Controls.Add(btnSave);
            tabNuevo.Controls.Add(btnNewBack);
            tabNuevo.Controls.Add(txbNewName);
            tabNuevo.Controls.Add(label7);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(732, 316);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
            // 
            // txbNewPhoneNumber
            // 
            txbNewPhoneNumber.Location = new Point(12, 232);
            txbNewPhoneNumber.Name = "txbNewPhoneNumber";
            txbNewPhoneNumber.Size = new Size(694, 23);
            txbNewPhoneNumber.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 217);
            label12.Name = "label12";
            label12.Size = new Size(118, 15);
            label12.TabIndex = 12;
            label12.Text = "Numero de Telefono:";
            // 
            // txbNewEmail
            // 
            txbNewEmail.Location = new Point(10, 181);
            txbNewEmail.Name = "txbNewEmail";
            txbNewEmail.Size = new Size(694, 23);
            txbNewEmail.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 166);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 10;
            label9.Text = "Correo:";
            // 
            // txbNewAddress
            // 
            txbNewAddress.Location = new Point(12, 129);
            txbNewAddress.Name = "txbNewAddress";
            txbNewAddress.Size = new Size(694, 23);
            txbNewAddress.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 114);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 8;
            label8.Text = "Dirección:";
            // 
            // txbNewCode
            // 
            txbNewCode.Location = new Point(13, 78);
            txbNewCode.Name = "txbNewCode";
            txbNewCode.Size = new Size(694, 23);
            txbNewCode.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 63);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Codigo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 13);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 0;
            label7.Text = "Nombre:";
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(17, 44);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.Size = new Size(701, 266);
            dgvCustomers.TabIndex = 3;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(643, 14);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txbSearch
            // 
            txbSearch.Location = new Point(444, 15);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(193, 23);
            txbSearch.TabIndex = 1;
            // 
            // btnNuevoLista
            // 
            btnNuevoLista.Cursor = Cursors.Hand;
            btnNuevoLista.FlatStyle = FlatStyle.Flat;
            btnNuevoLista.Location = new Point(17, 15);
            btnNuevoLista.Name = "btnNuevoLista";
            btnNuevoLista.Size = new Size(75, 23);
            btnNuevoLista.TabIndex = 0;
            btnNuevoLista.Text = "Nuevo";
            btnNuevoLista.UseVisualStyleBackColor = true;
            btnNuevoLista.Click += btnNuevoLista_Click;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(dgvCustomers);
            tabLista.Controls.Add(btnBuscar);
            tabLista.Controls.Add(txbSearch);
            tabLista.Controls.Add(btnNuevoLista);
            tabLista.Location = new Point(4, 24);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(732, 316);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabLista);
            tabControlMain.Controls.Add(tabNuevo);
            tabControlMain.Controls.Add(tabEdit);
            tabControlMain.ItemSize = new Size(80, 20);
            tabControlMain.Location = new Point(12, 45);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(740, 344);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 2;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(label2);
            Controls.Add(tabControlMain);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCustomer";
            Load += frmCustomer_Load;
            tabEdit.ResumeLayout(false);
            tabEdit.PerformLayout();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnGuardarEditar;
        private Button btnEditBack;
        private ComboBox cbbMedidaEditar;
        private TextBox txbNombreEditar;
        private Button btnSave;
        private Button btnNewBack;
        private TabPage tabEdit;
        private TextBox txbNewName;
        private TabPage tabNuevo;
        private Label label7;
        private DataGridView dgvCustomers;
        private Button btnBuscar;
        private TextBox txbSearch;
        private Button btnNuevoLista;
        private TabPage tabLista;
        private TabControl tabControlMain;
        private TextBox txbNewCode;
        private Label label3;
        private TextBox txbNewAddress;
        private Label label8;
        private TextBox txbNewEmail;
        private Label label9;
        private TextBox txbEditPhoneNumber;
        private Label label4;
        private TextBox txbEditAddress;
        private Label label5;
        private TextBox txbEditCode;
        private Label label10;
        private TextBox txbEditName;
        private Label label11;
        private ComboBox cbbEnable;
        private Label label6;
        private TextBox txbNewPhoneNumber;
        private Label label12;
        private TextBox txbEditEmail;
        private Label label13;
        private Button btnUpdate;
    }
}