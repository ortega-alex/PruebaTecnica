namespace Presentation.Froms
{
    partial class frmService
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
            txbNewMonthyCost = new TextBox();
            label3 = new Label();
            btnUpdate = new Button();
            dgvServices = new DataGridView();
            btnBuscar = new Button();
            txbSearch = new TextBox();
            btnNuevoLista = new Button();
            label7 = new Label();
            tabControlMain = new TabControl();
            tabLista = new TabPage();
            tabNuevo = new TabPage();
            cmbNewSerbiceSetting = new ComboBox();
            label12 = new Label();
            cmbNewServieLocation = new ComboBox();
            label9 = new Label();
            cmbNewServiceType = new ComboBox();
            label8 = new Label();
            btnSave = new Button();
            btnNewBack = new Button();
            txbNewDescription = new TextBox();
            tabEdit = new TabPage();
            cmbEditServiceSetting = new ComboBox();
            label4 = new Label();
            cmbEditServiceLocation = new ComboBox();
            label5 = new Label();
            cmbEditServiceType = new ComboBox();
            label10 = new Label();
            txbEditMonthyCost = new TextBox();
            label11 = new Label();
            txbEditDescription = new TextBox();
            label13 = new Label();
            cbbEnable = new ComboBox();
            label6 = new Label();
            btnEditBack = new Button();
            label2 = new Label();
            label1 = new Label();
            txbNewCode = new TextBox();
            label14 = new Label();
            txbEditCode = new TextBox();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            tabControlMain.SuspendLayout();
            tabLista.SuspendLayout();
            tabNuevo.SuspendLayout();
            tabEdit.SuspendLayout();
            SuspendLayout();
            // 
            // txbNewMonthyCost
            // 
            txbNewMonthyCost.Location = new Point(14, 119);
            txbNewMonthyCost.Name = "txbNewMonthyCost";
            txbNewMonthyCost.Size = new Size(694, 23);
            txbNewMonthyCost.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 102);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 6;
            label3.Text = "Mensualidad:";
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.FromArgb(30, 90, 195);
            btnUpdate.Location = new Point(638, 297);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Guardar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvServices
            // 
            dgvServices.AllowUserToAddRows = false;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(17, 44);
            dgvServices.Name = "dgvServices";
            dgvServices.Size = new Size(701, 266);
            dgvServices.TabIndex = 3;
            dgvServices.CellClick += dgvServices_CellClick;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 57);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 0;
            label7.Text = "Descripcion:";
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabLista);
            tabControlMain.Controls.Add(tabNuevo);
            tabControlMain.Controls.Add(tabEdit);
            tabControlMain.ItemSize = new Size(80, 20);
            tabControlMain.Location = new Point(12, 39);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(740, 354);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 5;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(dgvServices);
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
            // tabNuevo
            // 
            tabNuevo.Controls.Add(txbNewCode);
            tabNuevo.Controls.Add(label14);
            tabNuevo.Controls.Add(cmbNewSerbiceSetting);
            tabNuevo.Controls.Add(label12);
            tabNuevo.Controls.Add(cmbNewServieLocation);
            tabNuevo.Controls.Add(label9);
            tabNuevo.Controls.Add(cmbNewServiceType);
            tabNuevo.Controls.Add(label8);
            tabNuevo.Controls.Add(txbNewMonthyCost);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Controls.Add(btnSave);
            tabNuevo.Controls.Add(btnNewBack);
            tabNuevo.Controls.Add(txbNewDescription);
            tabNuevo.Controls.Add(label7);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(732, 326);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
            // 
            // cmbNewSerbiceSetting
            // 
            cmbNewSerbiceSetting.Cursor = Cursors.Hand;
            cmbNewSerbiceSetting.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNewSerbiceSetting.FormattingEnabled = true;
            cmbNewSerbiceSetting.Location = new Point(373, 165);
            cmbNewSerbiceSetting.Name = "cmbNewSerbiceSetting";
            cmbNewSerbiceSetting.Size = new Size(335, 23);
            cmbNewSerbiceSetting.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(376, 148);
            label12.Name = "label12";
            label12.Size = new Size(194, 15);
            label12.TabIndex = 18;
            label12.Text = "Configuracion (Velocidad/Canales):";
            // 
            // cmbNewServieLocation
            // 
            cmbNewServieLocation.Cursor = Cursors.Hand;
            cmbNewServieLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNewServieLocation.FormattingEnabled = true;
            cmbNewServieLocation.Location = new Point(13, 210);
            cmbNewServieLocation.Name = "cmbNewServieLocation";
            cmbNewServieLocation.Size = new Size(694, 23);
            cmbNewServieLocation.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 193);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 16;
            label9.Text = "Ubicacion:";
            // 
            // cmbNewServiceType
            // 
            cmbNewServiceType.Cursor = Cursors.Hand;
            cmbNewServiceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNewServiceType.FormattingEnabled = true;
            cmbNewServiceType.Location = new Point(14, 165);
            cmbNewServiceType.Name = "cmbNewServiceType";
            cmbNewServiceType.Size = new Size(353, 23);
            cmbNewServiceType.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 148);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 14;
            label8.Text = "Tipo de Servicio:";
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.FromArgb(30, 90, 195);
            btnSave.Location = new Point(637, 298);
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
            btnNewBack.Location = new Point(18, 297);
            btnNewBack.Name = "btnNewBack";
            btnNewBack.Size = new Size(75, 23);
            btnNewBack.TabIndex = 4;
            btnNewBack.Text = "Volver";
            btnNewBack.UseVisualStyleBackColor = true;
            btnNewBack.Click += btnNewBack_Click;
            // 
            // txbNewDescription
            // 
            txbNewDescription.Location = new Point(14, 73);
            txbNewDescription.Name = "txbNewDescription";
            txbNewDescription.Size = new Size(694, 23);
            txbNewDescription.TabIndex = 1;
            // 
            // tabEdit
            // 
            tabEdit.Controls.Add(txbEditCode);
            tabEdit.Controls.Add(label15);
            tabEdit.Controls.Add(cmbEditServiceSetting);
            tabEdit.Controls.Add(label4);
            tabEdit.Controls.Add(cmbEditServiceLocation);
            tabEdit.Controls.Add(label5);
            tabEdit.Controls.Add(cmbEditServiceType);
            tabEdit.Controls.Add(label10);
            tabEdit.Controls.Add(txbEditMonthyCost);
            tabEdit.Controls.Add(label11);
            tabEdit.Controls.Add(txbEditDescription);
            tabEdit.Controls.Add(label13);
            tabEdit.Controls.Add(btnUpdate);
            tabEdit.Controls.Add(cbbEnable);
            tabEdit.Controls.Add(label6);
            tabEdit.Controls.Add(btnEditBack);
            tabEdit.Location = new Point(4, 24);
            tabEdit.Name = "tabEdit";
            tabEdit.Padding = new Padding(3);
            tabEdit.Size = new Size(732, 326);
            tabEdit.TabIndex = 2;
            tabEdit.Text = "Editar";
            tabEdit.UseVisualStyleBackColor = true;
            // 
            // cmbEditServiceSetting
            // 
            cmbEditServiceSetting.Cursor = Cursors.Hand;
            cmbEditServiceSetting.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditServiceSetting.FormattingEnabled = true;
            cmbEditServiceSetting.Location = new Point(389, 157);
            cmbEditServiceSetting.Name = "cmbEditServiceSetting";
            cmbEditServiceSetting.Size = new Size(320, 23);
            cmbEditServiceSetting.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 140);
            label4.Name = "label4";
            label4.Size = new Size(194, 15);
            label4.TabIndex = 33;
            label4.Text = "Configuracion (Velocidad/Canales):";
            // 
            // cmbEditServiceLocation
            // 
            cmbEditServiceLocation.Cursor = Cursors.Hand;
            cmbEditServiceLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditServiceLocation.FormattingEnabled = true;
            cmbEditServiceLocation.Location = new Point(19, 203);
            cmbEditServiceLocation.Name = "cmbEditServiceLocation";
            cmbEditServiceLocation.Size = new Size(694, 23);
            cmbEditServiceLocation.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 186);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 31;
            label5.Text = "Ubicacion:";
            // 
            // cmbEditServiceType
            // 
            cmbEditServiceType.Cursor = Cursors.Hand;
            cmbEditServiceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditServiceType.FormattingEnabled = true;
            cmbEditServiceType.Location = new Point(20, 157);
            cmbEditServiceType.Name = "cmbEditServiceType";
            cmbEditServiceType.Size = new Size(363, 23);
            cmbEditServiceType.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 140);
            label10.Name = "label10";
            label10.Size = new Size(93, 15);
            label10.TabIndex = 29;
            label10.Text = "Tipo de Servicio:";
            // 
            // txbEditMonthyCost
            // 
            txbEditMonthyCost.Location = new Point(19, 113);
            txbEditMonthyCost.Name = "txbEditMonthyCost";
            txbEditMonthyCost.Size = new Size(694, 23);
            txbEditMonthyCost.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 96);
            label11.Name = "label11";
            label11.Size = new Size(78, 15);
            label11.TabIndex = 27;
            label11.Text = "Mensualidad:";
            // 
            // txbEditDescription
            // 
            txbEditDescription.Location = new Point(20, 69);
            txbEditDescription.Name = "txbEditDescription";
            txbEditDescription.Size = new Size(694, 23);
            txbEditDescription.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 51);
            label13.Name = "label13";
            label13.Size = new Size(72, 15);
            label13.TabIndex = 25;
            label13.Text = "Descripcion:";
            // 
            // cbbEnable
            // 
            cbbEnable.Cursor = Cursors.Hand;
            cbbEnable.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbEnable.FormattingEnabled = true;
            cbbEnable.Location = new Point(17, 249);
            cbbEnable.Name = "cbbEnable";
            cbbEnable.Size = new Size(694, 23);
            cbbEnable.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 233);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 12;
            label6.Text = "Habilitado:";
            // 
            // btnEditBack
            // 
            btnEditBack.Cursor = Cursors.Hand;
            btnEditBack.FlatStyle = FlatStyle.Flat;
            btnEditBack.Location = new Point(16, 298);
            btnEditBack.Name = "btnEditBack";
            btnEditBack.Size = new Size(75, 23);
            btnEditBack.TabIndex = 10;
            btnEditBack.Text = "Volver";
            btnEditBack.UseVisualStyleBackColor = true;
            btnEditBack.Click += btnEditBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 21);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 6;
            label2.Text = "Servicios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // txbNewCode
            // 
            txbNewCode.Location = new Point(14, 31);
            txbNewCode.Name = "txbNewCode";
            txbNewCode.Size = new Size(694, 23);
            txbNewCode.TabIndex = 21;
            txbNewCode.TextChanged += textBox1_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 15);
            label14.Name = "label14";
            label14.Size = new Size(49, 15);
            label14.TabIndex = 20;
            label14.Text = "Codigo:";
            // 
            // txbEditCode
            // 
            txbEditCode.Location = new Point(21, 27);
            txbEditCode.Name = "txbEditCode";
            txbEditCode.Size = new Size(694, 23);
            txbEditCode.TabIndex = 36;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(23, 11);
            label15.Name = "label15";
            label15.Size = new Size(49, 15);
            label15.TabIndex = 35;
            label15.Text = "Codigo:";
            // 
            // frmService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(tabControlMain);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmService";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmService";
            Load += frmService_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            tabControlMain.ResumeLayout(false);
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            tabEdit.ResumeLayout(false);
            tabEdit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txbNewMonthyCost;
        private Label label3;
        private Button btnUpdate;
        private DataGridView dgvServices;
        private Button btnBuscar;
        private TextBox txbSearch;
        private Button btnNuevoLista;
        private Label label7;
        private TabControl tabControlMain;
        private TabPage tabLista;
        private TabPage tabNuevo;
        private Button btnSave;
        private Button btnNewBack;
        private TextBox txbNewDescription;
        private TabPage tabEdit;
        private ComboBox cbbEnable;
        private Label label6;
        private Button btnEditBack;
        private Label label2;
        private Label label1;
        private ComboBox cmbNewServiceType;
        private Label label8;
        private ComboBox cmbNewSerbiceSetting;
        private Label label12;
        private ComboBox cmbNewServieLocation;
        private Label label9;
        private ComboBox cmbEditServiceSetting;
        private Label label4;
        private ComboBox cmbEditServiceLocation;
        private Label label5;
        private ComboBox cmbEditServiceType;
        private Label label10;
        private TextBox txbEditMonthyCost;
        private Label label11;
        private TextBox txbEditDescription;
        private Label label13;
        private TextBox txbNewCode;
        private Label label14;
        private TextBox txbEditCode;
        private Label label15;
    }
}