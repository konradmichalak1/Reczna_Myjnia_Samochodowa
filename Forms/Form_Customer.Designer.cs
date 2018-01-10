namespace Reczna_Myjnia_Samochodowa
{
    partial class Form_Customer
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
            this.components = new System.ComponentModel.Container();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myjniaDataSet1 = new Reczna_Myjnia_Samochodowa.MyjniaDataSet1();
            this.customerTableAdapter = new Reczna_Myjnia_Samochodowa.MyjniaDataSet1TableAdapters.CustomerTableAdapter();
            this.gb_Customers = new System.Windows.Forms.GroupBox();
            this.lb_CustomerTelephone = new System.Windows.Forms.Label();
            this.tb_CustomerTelephone = new System.Windows.Forms.TextBox();
            this.btn_UpdateCustomer = new System.Windows.Forms.Button();
            this.btn_DeleteCustomer = new System.Windows.Forms.Button();
            this.btn_InsertCustomer = new System.Windows.Forms.Button();
            this.lb_CustomerSurname = new System.Windows.Forms.Label();
            this.lb_CustomerName = new System.Windows.Forms.Label();
            this.lb_CustomerID = new System.Windows.Forms.Label();
            this.tb_CustomerName = new System.Windows.Forms.TextBox();
            this.tb_CustomerSurname = new System.Windows.Forms.TextBox();
            this.tb_CustomerID = new System.Windows.Forms.TextBox();
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.iDcustomerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myjniaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myjniaDataSet1)).BeginInit();
            this.gb_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myjniaDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.myjniaDataSet1;
            // 
            // myjniaDataSet1
            // 
            this.myjniaDataSet1.DataSetName = "MyjniaDataSet1";
            this.myjniaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // gb_Customers
            // 
            this.gb_Customers.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gb_Customers.Controls.Add(this.lb_CustomerTelephone);
            this.gb_Customers.Controls.Add(this.tb_CustomerTelephone);
            this.gb_Customers.Controls.Add(this.btn_UpdateCustomer);
            this.gb_Customers.Controls.Add(this.btn_DeleteCustomer);
            this.gb_Customers.Controls.Add(this.btn_InsertCustomer);
            this.gb_Customers.Controls.Add(this.lb_CustomerSurname);
            this.gb_Customers.Controls.Add(this.lb_CustomerName);
            this.gb_Customers.Controls.Add(this.lb_CustomerID);
            this.gb_Customers.Controls.Add(this.tb_CustomerName);
            this.gb_Customers.Controls.Add(this.tb_CustomerSurname);
            this.gb_Customers.Controls.Add(this.tb_CustomerID);
            this.gb_Customers.Location = new System.Drawing.Point(12, 62);
            this.gb_Customers.Name = "gb_Customers";
            this.gb_Customers.Size = new System.Drawing.Size(249, 174);
            this.gb_Customers.TabIndex = 2;
            this.gb_Customers.TabStop = false;
            this.gb_Customers.Text = "Klient";
            // 
            // lb_CustomerTelephone
            // 
            this.lb_CustomerTelephone.AutoSize = true;
            this.lb_CustomerTelephone.Location = new System.Drawing.Point(54, 101);
            this.lb_CustomerTelephone.Name = "lb_CustomerTelephone";
            this.lb_CustomerTelephone.Size = new System.Drawing.Size(43, 13);
            this.lb_CustomerTelephone.TabIndex = 14;
            this.lb_CustomerTelephone.Text = "Telefon";
            // 
            // tb_CustomerTelephone
            // 
            this.tb_CustomerTelephone.Location = new System.Drawing.Point(104, 97);
            this.tb_CustomerTelephone.Name = "tb_CustomerTelephone";
            this.tb_CustomerTelephone.Size = new System.Drawing.Size(100, 20);
            this.tb_CustomerTelephone.TabIndex = 13;
            // 
            // btn_UpdateCustomer
            // 
            this.btn_UpdateCustomer.BackgroundImage = global::Reczna_Myjnia_Samochodowa.Properties.Resources.Update_Button;
            this.btn_UpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_UpdateCustomer.Location = new System.Drawing.Point(167, 143);
            this.btn_UpdateCustomer.Name = "btn_UpdateCustomer";
            this.btn_UpdateCustomer.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateCustomer.TabIndex = 12;
            this.btn_UpdateCustomer.Text = "Aktualizuj";
            this.btn_UpdateCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UpdateCustomer.UseVisualStyleBackColor = true;
            this.btn_UpdateCustomer.Click += new System.EventHandler(this.btn_UpdateCustomer_Click);
            // 
            // btn_DeleteCustomer
            // 
            this.btn_DeleteCustomer.BackgroundImage = global::Reczna_Myjnia_Samochodowa.Properties.Resources.Delete_Button;
            this.btn_DeleteCustomer.Location = new System.Drawing.Point(86, 143);
            this.btn_DeleteCustomer.Name = "btn_DeleteCustomer";
            this.btn_DeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteCustomer.TabIndex = 11;
            this.btn_DeleteCustomer.Text = "Usuń";
            this.btn_DeleteCustomer.UseVisualStyleBackColor = true;
            this.btn_DeleteCustomer.Click += new System.EventHandler(this.btn_DeleteCustomer_Click);
            // 
            // btn_InsertCustomer
            // 
            this.btn_InsertCustomer.BackgroundImage = global::Reczna_Myjnia_Samochodowa.Properties.Resources.Add_Button;
            this.btn_InsertCustomer.Location = new System.Drawing.Point(5, 143);
            this.btn_InsertCustomer.Name = "btn_InsertCustomer";
            this.btn_InsertCustomer.Size = new System.Drawing.Size(75, 23);
            this.btn_InsertCustomer.TabIndex = 10;
            this.btn_InsertCustomer.Text = "Dodaj";
            this.btn_InsertCustomer.UseVisualStyleBackColor = true;
            this.btn_InsertCustomer.Click += new System.EventHandler(this.btn_InsertCustomer_Click);
            // 
            // lb_CustomerSurname
            // 
            this.lb_CustomerSurname.AutoSize = true;
            this.lb_CustomerSurname.Location = new System.Drawing.Point(44, 75);
            this.lb_CustomerSurname.Name = "lb_CustomerSurname";
            this.lb_CustomerSurname.Size = new System.Drawing.Size(53, 13);
            this.lb_CustomerSurname.TabIndex = 8;
            this.lb_CustomerSurname.Text = "Nazwisko";
            // 
            // lb_CustomerName
            // 
            this.lb_CustomerName.AutoSize = true;
            this.lb_CustomerName.Location = new System.Drawing.Point(71, 49);
            this.lb_CustomerName.Name = "lb_CustomerName";
            this.lb_CustomerName.Size = new System.Drawing.Size(26, 13);
            this.lb_CustomerName.TabIndex = 7;
            this.lb_CustomerName.Text = "Imię";
            // 
            // lb_CustomerID
            // 
            this.lb_CustomerID.AutoSize = true;
            this.lb_CustomerID.Location = new System.Drawing.Point(80, 22);
            this.lb_CustomerID.Name = "lb_CustomerID";
            this.lb_CustomerID.Size = new System.Drawing.Size(18, 13);
            this.lb_CustomerID.TabIndex = 5;
            this.lb_CustomerID.Text = "ID";
            // 
            // tb_CustomerName
            // 
            this.tb_CustomerName.Location = new System.Drawing.Point(104, 45);
            this.tb_CustomerName.Name = "tb_CustomerName";
            this.tb_CustomerName.Size = new System.Drawing.Size(100, 20);
            this.tb_CustomerName.TabIndex = 3;
            this.tb_CustomerName.TextChanged += new System.EventHandler(this.tb_CustomerName_TextChanged);
            // 
            // tb_CustomerSurname
            // 
            this.tb_CustomerSurname.Location = new System.Drawing.Point(104, 71);
            this.tb_CustomerSurname.Name = "tb_CustomerSurname";
            this.tb_CustomerSurname.Size = new System.Drawing.Size(100, 20);
            this.tb_CustomerSurname.TabIndex = 2;
            // 
            // tb_CustomerID
            // 
            this.tb_CustomerID.Location = new System.Drawing.Point(104, 19);
            this.tb_CustomerID.Name = "tb_CustomerID";
            this.tb_CustomerID.Size = new System.Drawing.Size(100, 20);
            this.tb_CustomerID.TabIndex = 0;
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.AutoGenerateColumns = false;
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDcustomerDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.surnameDataGridViewTextBoxColumn1,
            this.telephoneDataGridViewTextBoxColumn1});
            this.CustomerGridView.DataSource = this.customerBindingSource;
            this.CustomerGridView.Location = new System.Drawing.Point(276, 12);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.ReadOnly = true;
            this.CustomerGridView.Size = new System.Drawing.Size(450, 404);
            this.CustomerGridView.TabIndex = 3;
            this.CustomerGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CustomerGridView_CellContentClick);
            // 
            // iDcustomerDataGridViewTextBoxColumn1
            // 
            this.iDcustomerDataGridViewTextBoxColumn1.DataPropertyName = "ID_customer";
            this.iDcustomerDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDcustomerDataGridViewTextBoxColumn1.Name = "iDcustomerDataGridViewTextBoxColumn1";
            this.iDcustomerDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Imie";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Nazwisko";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            this.surnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn1
            // 
            this.telephoneDataGridViewTextBoxColumn1.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn1.HeaderText = "Telefon";
            this.telephoneDataGridViewTextBoxColumn1.Name = "telephoneDataGridViewTextBoxColumn1";
            this.telephoneDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // myjniaDataSet1BindingSource
            // 
            this.myjniaDataSet1BindingSource.DataSource = this.myjniaDataSet1;
            this.myjniaDataSet1BindingSource.Position = 0;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(98, 328);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 4;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // Form_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 427);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.CustomerGridView);
            this.Controls.Add(this.gb_Customers);
            this.Name = "Form_Customer";
            this.Text = "Klient";
            this.Load += new System.EventHandler(this.Form_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myjniaDataSet1)).EndInit();
            this.gb_Customers.ResumeLayout(false);
            this.gb_Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myjniaDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MyjniaDataSet1 myjniaDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private MyjniaDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcarDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gb_Customers;
        private System.Windows.Forms.Button btn_UpdateCustomer;
        private System.Windows.Forms.Button btn_DeleteCustomer;
        private System.Windows.Forms.Button btn_InsertCustomer;
        private System.Windows.Forms.Label lb_CustomerSurname;
        private System.Windows.Forms.Label lb_CustomerName;
        private System.Windows.Forms.Label lb_CustomerID;
        private System.Windows.Forms.TextBox tb_CustomerName;
        private System.Windows.Forms.TextBox tb_CustomerSurname;
        private System.Windows.Forms.TextBox tb_CustomerID;
        private System.Windows.Forms.Label lb_CustomerTelephone;
        private System.Windows.Forms.TextBox tb_CustomerTelephone;
        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.BindingSource myjniaDataSet1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcustomerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btn_Ok;
    }
}