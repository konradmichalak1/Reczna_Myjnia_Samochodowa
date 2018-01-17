namespace Reczna_Myjnia_Samochodowa
{
    partial class Form_Services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Services));
            this.ServiceGridView = new System.Windows.Forms.DataGridView();
            this.iDserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realizationtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesDataSet = new Reczna_Myjnia_Samochodowa.ServicesDataSet();
            this.serviceTableAdapter = new Reczna_Myjnia_Samochodowa.ServicesDataSetTableAdapters.ServiceTableAdapter();
            this.gb_Services = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_realizationtime = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.btn_UpdateService = new System.Windows.Forms.Button();
            this.btn_DeleteService = new System.Windows.Forms.Button();
            this.btn_InsertService = new System.Windows.Forms.Button();
            this.lb_ServiceID = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_realizationtime = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_ServiceID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataSet)).BeginInit();
            this.gb_Services.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServiceGridView
            // 
            this.ServiceGridView.AutoGenerateColumns = false;
            this.ServiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDserviceDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.realizationtimeDataGridViewTextBoxColumn});
            this.ServiceGridView.DataSource = this.serviceBindingSource;
            this.ServiceGridView.Location = new System.Drawing.Point(276, 12);
            this.ServiceGridView.Name = "ServiceGridView";
            this.ServiceGridView.ReadOnly = true;
            this.ServiceGridView.Size = new System.Drawing.Size(448, 342);
            this.ServiceGridView.TabIndex = 0;
            this.ServiceGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ServiceGridView_CellMouseClick);
            // 
            // iDserviceDataGridViewTextBoxColumn
            // 
            this.iDserviceDataGridViewTextBoxColumn.DataPropertyName = "ID_service";
            this.iDserviceDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDserviceDataGridViewTextBoxColumn.Name = "iDserviceDataGridViewTextBoxColumn";
            this.iDserviceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // realizationtimeDataGridViewTextBoxColumn
            // 
            this.realizationtimeDataGridViewTextBoxColumn.DataPropertyName = "Realization_time";
            this.realizationtimeDataGridViewTextBoxColumn.HeaderText = "Czas realizacji";
            this.realizationtimeDataGridViewTextBoxColumn.Name = "realizationtimeDataGridViewTextBoxColumn";
            this.realizationtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.servicesDataSet;
            // 
            // servicesDataSet
            // 
            this.servicesDataSet.DataSetName = "ServicesDataSet";
            this.servicesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // gb_Services
            // 
            this.gb_Services.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gb_Services.Controls.Add(this.label2);
            this.gb_Services.Controls.Add(this.label1);
            this.gb_Services.Controls.Add(this.lb_price);
            this.gb_Services.Controls.Add(this.lb_realizationtime);
            this.gb_Services.Controls.Add(this.lb_name);
            this.gb_Services.Controls.Add(this.btn_UpdateService);
            this.gb_Services.Controls.Add(this.btn_DeleteService);
            this.gb_Services.Controls.Add(this.btn_InsertService);
            this.gb_Services.Controls.Add(this.lb_ServiceID);
            this.gb_Services.Controls.Add(this.tb_price);
            this.gb_Services.Controls.Add(this.tb_realizationtime);
            this.gb_Services.Controls.Add(this.tb_name);
            this.gb_Services.Controls.Add(this.tb_ServiceID);
            this.gb_Services.Location = new System.Drawing.Point(12, 101);
            this.gb_Services.Name = "gb_Services";
            this.gb_Services.Size = new System.Drawing.Size(249, 165);
            this.gb_Services.TabIndex = 4;
            this.gb_Services.TabStop = false;
            this.gb_Services.Text = "Usługa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "zł";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Location = new System.Drawing.Point(41, 74);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(35, 13);
            this.lb_price.TabIndex = 13;
            this.lb_price.Text = "Cena:";
            // 
            // lb_realizationtime
            // 
            this.lb_realizationtime.AutoSize = true;
            this.lb_realizationtime.Location = new System.Drawing.Point(13, 48);
            this.lb_realizationtime.Name = "lb_realizationtime";
            this.lb_realizationtime.Size = new System.Drawing.Size(76, 13);
            this.lb_realizationtime.TabIndex = 13;
            this.lb_realizationtime.Text = "Czas realizacji:";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(18, 22);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(43, 13);
            this.lb_name.TabIndex = 13;
            this.lb_name.Text = "Nazwa:";
            // 
            // btn_UpdateService
            // 
            this.btn_UpdateService.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_UpdateService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_UpdateService.BackgroundImage")));
            this.btn_UpdateService.Location = new System.Drawing.Point(168, 131);
            this.btn_UpdateService.Name = "btn_UpdateService";
            this.btn_UpdateService.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateService.TabIndex = 6;
            this.btn_UpdateService.Text = "Aktualizuj";
            this.btn_UpdateService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UpdateService.UseVisualStyleBackColor = false;
            this.btn_UpdateService.Click += new System.EventHandler(this.btn_UpdateService_Click);
            // 
            // btn_DeleteService
            // 
            this.btn_DeleteService.Image = global::Reczna_Myjnia_Samochodowa.Properties.Resources.Delete_Button;
            this.btn_DeleteService.Location = new System.Drawing.Point(87, 131);
            this.btn_DeleteService.Name = "btn_DeleteService";
            this.btn_DeleteService.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteService.TabIndex = 5;
            this.btn_DeleteService.Text = "Usuń";
            this.btn_DeleteService.UseVisualStyleBackColor = true;
            this.btn_DeleteService.Click += new System.EventHandler(this.btn_DeleteService_Click);
            // 
            // btn_InsertService
            // 
            this.btn_InsertService.BackgroundImage = global::Reczna_Myjnia_Samochodowa.Properties.Resources.Add_Button;
            this.btn_InsertService.Location = new System.Drawing.Point(6, 131);
            this.btn_InsertService.Name = "btn_InsertService";
            this.btn_InsertService.Size = new System.Drawing.Size(75, 23);
            this.btn_InsertService.TabIndex = 4;
            this.btn_InsertService.Text = "Dodaj";
            this.btn_InsertService.UseVisualStyleBackColor = true;
            this.btn_InsertService.Click += new System.EventHandler(this.btn_InsertService_Click);
            // 
            // lb_ServiceID
            // 
            this.lb_ServiceID.AutoSize = true;
            this.lb_ServiceID.Location = new System.Drawing.Point(106, 109);
            this.lb_ServiceID.Name = "lb_ServiceID";
            this.lb_ServiceID.Size = new System.Drawing.Size(18, 13);
            this.lb_ServiceID.TabIndex = 5;
            this.lb_ServiceID.Text = "ID";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(82, 71);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(68, 20);
            this.tb_price.TabIndex = 2;
            this.tb_price.Text = "0,00";
            this.tb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_salary_KeyPress);
            // 
            // tb_realizationtime
            // 
            this.tb_realizationtime.Location = new System.Drawing.Point(91, 45);
            this.tb_realizationtime.Name = "tb_realizationtime";
            this.tb_realizationtime.Size = new System.Drawing.Size(59, 20);
            this.tb_realizationtime.TabIndex = 1;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(66, 19);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(132, 20);
            this.tb_name.TabIndex = 0;
            // 
            // tb_ServiceID
            // 
            this.tb_ServiceID.Location = new System.Drawing.Point(130, 105);
            this.tb_ServiceID.Name = "tb_ServiceID";
            this.tb_ServiceID.Size = new System.Drawing.Size(100, 20);
            this.tb_ServiceID.TabIndex = 3;
            // 
            // Form_Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 366);
            this.Controls.Add(this.gb_Services);
            this.Controls.Add(this.ServiceGridView);
            this.Name = "Form_Services";
            this.Text = "Usługi";
            this.Load += new System.EventHandler(this.Form_Services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataSet)).EndInit();
            this.gb_Services.ResumeLayout(false);
            this.gb_Services.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ServiceGridView;
        private ServicesDataSet servicesDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private ServicesDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.GroupBox gb_Services;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_realizationtime;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Button btn_UpdateService;
        private System.Windows.Forms.Button btn_DeleteService;
        private System.Windows.Forms.Button btn_InsertService;
        private System.Windows.Forms.Label lb_ServiceID;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_realizationtime;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_ServiceID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDserviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realizationtimeDataGridViewTextBoxColumn;
    }
}