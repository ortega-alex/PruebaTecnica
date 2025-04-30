namespace Presentation.Froms
{
    partial class frmContract
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dgvContractDetail = new DataGridView();
            label3 = new Label();
            btnBuscar = new Button();
            txbServiceCode = new TextBox();
            label4 = new Label();
            cbbCustomer = new ComboBox();
            label6 = new Label();
            dtpStartDate = new DateTimePicker();
            label5 = new Label();
            label7 = new Label();
            dtpEndDate = new DateTimePicker();
            txbPayPeriod = new TextBox();
            label8 = new Label();
            txbDiscountPercentage = new TextBox();
            label9 = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContractDetail).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 7);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 7;
            label2.Text = "Nuevo Contrato";
            // 
            // dgvContractDetail
            // 
            dgvContractDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContractDetail.Location = new Point(24, 168);
            dgvContractDetail.Name = "dgvContractDetail";
            dgvContractDetail.Size = new Size(701, 171);
            dgvContractDetail.TabIndex = 44;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(4, 24);
            label3.Name = "label3";
            label3.Size = new Size(740, 340);
            label3.TabIndex = 43;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(646, 46);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 47;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txbServiceCode
            // 
            txbServiceCode.Location = new Point(377, 46);
            txbServiceCode.Name = "txbServiceCode";
            txbServiceCode.Size = new Size(263, 23);
            txbServiceCode.TabIndex = 46;
            txbServiceCode.KeyDown += txbServiceCode_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(377, 28);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 45;
            label4.Text = "Codigo Servicio:";
            // 
            // cbbCustomer
            // 
            cbbCustomer.Cursor = Cursors.Hand;
            cbbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCustomer.FormattingEnabled = true;
            cbbCustomer.Location = new Point(24, 46);
            cbbCustomer.Name = "cbbCustomer";
            cbbCustomer.Size = new Size(347, 23);
            cbbCustomer.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 30);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 48;
            label6.Text = "Cliente:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(24, 93);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(347, 23);
            dtpStartDate.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 75);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 51;
            label5.Text = "Fecha Inicio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(377, 75);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 53;
            label7.Text = "Fecha Fin:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(374, 93);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(347, 23);
            dtpEndDate.TabIndex = 52;
            // 
            // txbPayPeriod
            // 
            txbPayPeriod.Location = new Point(24, 137);
            txbPayPeriod.Name = "txbPayPeriod";
            txbPayPeriod.Size = new Size(347, 23);
            txbPayPeriod.TabIndex = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(24, 119);
            label8.Name = "label8";
            label8.Size = new Size(97, 15);
            label8.TabIndex = 54;
            label8.Text = "Periodo de pago:";
            // 
            // txbDiscountPercentage
            // 
            txbDiscountPercentage.Location = new Point(376, 137);
            txbDiscountPercentage.Name = "txbDiscountPercentage";
            txbDiscountPercentage.Size = new Size(347, 23);
            txbDiscountPercentage.TabIndex = 57;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(376, 119);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 56;
            label9.Text = "% Descuento:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(649, 341);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 58;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmContract
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 368);
            Controls.Add(btnSave);
            Controls.Add(txbDiscountPercentage);
            Controls.Add(label9);
            Controls.Add(txbPayPeriod);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dtpEndDate);
            Controls.Add(label5);
            Controls.Add(dtpStartDate);
            Controls.Add(cbbCustomer);
            Controls.Add(label6);
            Controls.Add(btnBuscar);
            Controls.Add(txbServiceCode);
            Controls.Add(label4);
            Controls.Add(dgvContractDetail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmContract";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmContract";
            Load += frmContract_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContractDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private DataGridView dgvContractDetail;
        private Label label3;
        private Button btnBuscar;
        private TextBox txbServiceCode;
        private Label label4;
        private ComboBox cbbCustomer;
        private Label label6;
        private DateTimePicker dtpStartDate;
        private Label label5;
        private Label label7;
        private DateTimePicker dtpEndDate;
        private TextBox txbPayPeriod;
        private Label label8;
        private TextBox txbDiscountPercentage;
        private Label label9;
        private Button btnSave;
    }
}