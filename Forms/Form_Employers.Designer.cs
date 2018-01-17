namespace Reczna_Myjnia_Samochodowa
{
    partial class Form_Employers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Employers));
            this.EmployersGridView = new System.Windows.Forms.DataGridView();
            this.iDemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employersDataSet = new Reczna_Myjnia_Samochodowa.EmployersDataSet();
            this.employeeTableAdapter = new Reczna_Myjnia_Samochodowa.EmployersDataSetTableAdapters.EmployeeTableAdapter();
            this.gb_Employers = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_jobtitle = new System.Windows.Forms.ComboBox();
            this.lb_salary = new System.Windows.Forms.Label();
            this.lb_jobtitle = new System.Windows.Forms.Label();
            this.lb_pesel = new System.Windows.Forms.Label();
            this.lb_surname = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.btn_UpdateEmployee = new System.Windows.Forms.Button();
            this.btn_DeleteEmployee = new System.Windows.Forms.Button();
            this.btn_InsertEmployee = new System.Windows.Forms.Button();
            this.lb_EmployeeID = new System.Windows.Forms.Label();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.tb_pesel = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_EmployeeID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersDataSet)).BeginInit();
            this.gb_Employers.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployersGridView
            // 
            this.EmployersGridView.AutoGenerateColumns = false;
            this.EmployersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDemployeeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.pESELDataGridViewTextBoxColumn,
            this.jobtitleDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.EmployersGridView.DataSource = this.employeeBindingSource;
            this.EmployersGridView.Location = new System.Drawing.Point(267, 12);
            this.EmployersGridView.MultiSelect = false;
            this.EmployersGridView.Name = "EmployersGridView";
            this.EmployersGridView.ReadOnly = true;
            this.EmployersGridView.Size = new System.Drawing.Size(646, 329);
            this.EmployersGridView.TabIndex = 0;
            this.EmployersGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EmployersGridView_CellMouseClick);
            // 
            // iDemployeeDataGridViewTextBoxColumn
            // 
            this.iDemployeeDataGridViewTextBoxColumn.DataPropertyName = "ID_employee";
            this.iDemployeeDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDemployeeDataGridViewTextBoxColumn.Name = "iDemployeeDataGridViewTextBoxColumn";
            this.iDemployeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pESELDataGridViewTextBoxColumn
            // 
            this.pESELDataGridViewTextBoxColumn.DataPropertyName = "PESEL";
            this.pESELDataGridViewTextBoxColumn.HeaderText = "PESEL";
            this.pESELDataGridViewTextBoxColumn.Name = "pESELDataGridViewTextBoxColumn";
            this.pESELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobtitleDataGridViewTextBoxColumn
            // 
            this.jobtitleDataGridViewTextBoxColumn.DataPropertyName = "Job_title";
            this.jobtitleDataGridViewTextBoxColumn.HeaderText = "Stanowisko";
            this.jobtitleDataGridViewTextBoxColumn.Name = "jobtitleDataGridViewTextBoxColumn";
            this.jobtitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Pensja";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.employersDataSet;
            // 
            // employersDataSet
            // 
            this.employersDataSet.DataSetName = "EmployersDataSet";
            this.employersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // gb_Employers
            // 
            this.gb_Employers.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gb_Employers.Controls.Add(this.label1);
            this.gb_Employers.Controls.Add(this.cb_jobtitle);
            this.gb_Employers.Controls.Add(this.lb_salary);
            this.gb_Employers.Controls.Add(this.lb_jobtitle);
            this.gb_Employers.Controls.Add(this.lb_pesel);
            this.gb_Employers.Controls.Add(this.lb_surname);
            this.gb_Employers.Controls.Add(this.lb_name);
            this.gb_Employers.Controls.Add(this.btn_UpdateEmployee);
            this.gb_Employers.Controls.Add(this.btn_DeleteEmployee);
            this.gb_Employers.Controls.Add(this.btn_InsertEmployee);
            this.gb_Employers.Controls.Add(this.lb_EmployeeID);
            this.gb_Employers.Controls.Add(this.tb_salary);
            this.gb_Employers.Controls.Add(this.tb_pesel);
            this.gb_Employers.Controls.Add(this.tb_surname);
            this.gb_Employers.Controls.Add(this.tb_name);
            this.gb_Employers.Controls.Add(this.tb_EmployeeID);
            this.gb_Employers.Location = new System.Drawing.Point(12, 41);
            this.gb_Employers.Name = "gb_Employers";
            this.gb_Employers.Size = new System.Drawing.Size(249, 269);
            this.gb_Employers.TabIndex = 3;
            this.gb_Employers.TabStop = false;
            this.gb_Employers.Text = "Pracownik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "zł";
            // 
            // cb_jobtitle
            // 
            this.cb_jobtitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_jobtitle.FormattingEnabled = true;
            this.cb_jobtitle.Items.AddRange(new object[] {
            "Kierownik",
            "Recepcjonista",
            "Pracownik"});
            this.cb_jobtitle.Location = new System.Drawing.Point(84, 152);
            this.cb_jobtitle.Name = "cb_jobtitle";
            this.cb_jobtitle.Size = new System.Drawing.Size(121, 21);
            this.cb_jobtitle.TabIndex = 4;
            // 
            // lb_salary
            // 
            this.lb_salary.AutoSize = true;
            this.lb_salary.Location = new System.Drawing.Point(24, 122);
            this.lb_salary.Name = "lb_salary";
            this.lb_salary.Size = new System.Drawing.Size(42, 13);
            this.lb_salary.TabIndex = 13;
            this.lb_salary.Text = "Pensja:";
            // 
            // lb_jobtitle
            // 
            this.lb_jobtitle.AutoSize = true;
            this.lb_jobtitle.Location = new System.Drawing.Point(13, 155);
            this.lb_jobtitle.Name = "lb_jobtitle";
            this.lb_jobtitle.Size = new System.Drawing.Size(65, 13);
            this.lb_jobtitle.TabIndex = 13;
            this.lb_jobtitle.Text = "Stanowisko:";
            // 
            // lb_pesel
            // 
            this.lb_pesel.AutoSize = true;
            this.lb_pesel.Location = new System.Drawing.Point(24, 93);
            this.lb_pesel.Name = "lb_pesel";
            this.lb_pesel.Size = new System.Drawing.Size(44, 13);
            this.lb_pesel.TabIndex = 13;
            this.lb_pesel.Text = "PESEL:";
            // 
            // lb_surname
            // 
            this.lb_surname.AutoSize = true;
            this.lb_surname.Location = new System.Drawing.Point(11, 62);
            this.lb_surname.Name = "lb_surname";
            this.lb_surname.Size = new System.Drawing.Size(56, 13);
            this.lb_surname.TabIndex = 13;
            this.lb_surname.Text = "Nazwisko:";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(38, 33);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(29, 13);
            this.lb_name.TabIndex = 13;
            this.lb_name.Text = "Imie:";
            // 
            // btn_UpdateEmployee
            // 
            this.btn_UpdateEmployee.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_UpdateEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_UpdateEmployee.BackgroundImage")));
            this.btn_UpdateEmployee.Location = new System.Drawing.Point(165, 233);
            this.btn_UpdateEmployee.Name = "btn_UpdateEmployee";
            this.btn_UpdateEmployee.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateEmployee.TabIndex = 8;
            this.btn_UpdateEmployee.Text = "Aktualizuj";
            this.btn_UpdateEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UpdateEmployee.UseVisualStyleBackColor = false;
            this.btn_UpdateEmployee.Click += new System.EventHandler(this.btn_UpdateEmployee_Click);
            // 
            // btn_DeleteEmployee
            // 
            this.btn_DeleteEmployee.Image = global::Reczna_Myjnia_Samochodowa.Properties.Resources.Delete_Button;
            this.btn_DeleteEmployee.Location = new System.Drawing.Point(84, 233);
            this.btn_DeleteEmployee.Name = "btn_DeleteEmployee";
            this.btn_DeleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteEmployee.TabIndex = 7;
            this.btn_DeleteEmployee.Text = "Usuń";
            this.btn_DeleteEmployee.UseVisualStyleBackColor = true;
            this.btn_DeleteEmployee.Click += new System.EventHandler(this.btn_DeleteEmployee_Click);
            // 
            // btn_InsertEmployee
            // 
            this.btn_InsertEmployee.BackgroundImage = global::Reczna_Myjnia_Samochodowa.Properties.Resources.Add_Button;
            this.btn_InsertEmployee.Location = new System.Drawing.Point(3, 233);
            this.btn_InsertEmployee.Name = "btn_InsertEmployee";
            this.btn_InsertEmployee.Size = new System.Drawing.Size(75, 23);
            this.btn_InsertEmployee.TabIndex = 6;
            this.btn_InsertEmployee.Text = "Dodaj";
            this.btn_InsertEmployee.UseVisualStyleBackColor = true;
            this.btn_InsertEmployee.Click += new System.EventHandler(this.btn_InsertEmployee_Click);
            // 
            // lb_EmployeeID
            // 
            this.lb_EmployeeID.AutoSize = true;
            this.lb_EmployeeID.Location = new System.Drawing.Point(96, 202);
            this.lb_EmployeeID.Name = "lb_EmployeeID";
            this.lb_EmployeeID.Size = new System.Drawing.Size(18, 13);
            this.lb_EmployeeID.TabIndex = 5;
            this.lb_EmployeeID.Text = "ID";
            // 
            // tb_salary
            // 
            this.tb_salary.Location = new System.Drawing.Point(73, 119);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(86, 20);
            this.tb_salary.TabIndex = 3;
            this.tb_salary.Text = "0,00";
            this.tb_salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_salary_KeyPress);
            // 
            // tb_pesel
            // 
            this.tb_pesel.Location = new System.Drawing.Point(73, 89);
            this.tb_pesel.Name = "tb_pesel";
            this.tb_pesel.Size = new System.Drawing.Size(132, 20);
            this.tb_pesel.TabIndex = 2;
            this.tb_pesel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pesel_KeyPress);
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(73, 59);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(132, 20);
            this.tb_surname.TabIndex = 1;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(73, 30);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(132, 20);
            this.tb_name.TabIndex = 0;
            // 
            // tb_EmployeeID
            // 
            this.tb_EmployeeID.Location = new System.Drawing.Point(120, 198);
            this.tb_EmployeeID.Name = "tb_EmployeeID";
            this.tb_EmployeeID.Size = new System.Drawing.Size(100, 20);
            this.tb_EmployeeID.TabIndex = 5;
            // 
            // Form_Employers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 348);
            this.Controls.Add(this.gb_Employers);
            this.Controls.Add(this.EmployersGridView);
            this.Name = "Form_Employers";
            this.Text = "Pracownicy";
            this.Load += new System.EventHandler(this.Form_Employers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersDataSet)).EndInit();
            this.gb_Employers.ResumeLayout(false);
            this.gb_Employers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployersGridView;
        private EmployersDataSet employersDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EmployersDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.GroupBox gb_Employers;
        private System.Windows.Forms.Button btn_UpdateEmployee;
        private System.Windows.Forms.Button btn_DeleteEmployee;
        private System.Windows.Forms.Button btn_InsertEmployee;
        private System.Windows.Forms.Label lb_EmployeeID;
        private System.Windows.Forms.TextBox tb_EmployeeID;
        private System.Windows.Forms.Label lb_salary;
        private System.Windows.Forms.Label lb_jobtitle;
        private System.Windows.Forms.Label lb_pesel;
        private System.Windows.Forms.Label lb_surname;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.TextBox tb_pesel;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.ComboBox cb_jobtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
    }
}