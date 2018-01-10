namespace Reczna_Myjnia_Samochodowa
{
    partial class Form_Cars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cars));
            this.CarGridView = new System.Windows.Forms.DataGridView();
            this.iDcarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myjniaDataSet = new Reczna_Myjnia_Samochodowa.MyjniaDataSet();
            this.carTableAdapter = new Reczna_Myjnia_Samochodowa.MyjniaDataSetTableAdapters.CarTableAdapter();
            this.gb_Cars = new System.Windows.Forms.GroupBox();
            this.btn_UpdateCar = new System.Windows.Forms.Button();
            this.btn_DeleteCar = new System.Windows.Forms.Button();
            this.btn_InsertCar = new System.Windows.Forms.Button();
            this.lb_CarNote = new System.Windows.Forms.Label();
            this.lb_CarLicense = new System.Windows.Forms.Label();
            this.lb_CarModel = new System.Windows.Forms.Label();
            this.lb_CarMark = new System.Windows.Forms.Label();
            this.lb_CarID = new System.Windows.Forms.Label();
            this.tb_CarNote = new System.Windows.Forms.TextBox();
            this.tb_CarModel = new System.Windows.Forms.TextBox();
            this.tb_CarLicense = new System.Windows.Forms.TextBox();
            this.tb_CarMark = new System.Windows.Forms.TextBox();
            this.tb_CarID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myjniaDataSet)).BeginInit();
            this.gb_Cars.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarGridView
            // 
            this.CarGridView.AutoGenerateColumns = false;
            this.CarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDcarDataGridViewTextBoxColumn,
            this.markDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.licensenumberDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.reportdateDataGridViewTextBoxColumn});
            this.CarGridView.DataSource = this.carBindingSource;
            this.CarGridView.Location = new System.Drawing.Point(289, 17);
            this.CarGridView.Name = "CarGridView";
            this.CarGridView.ReadOnly = true;
            this.CarGridView.Size = new System.Drawing.Size(645, 351);
            this.CarGridView.TabIndex = 0;
            this.CarGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CarGridView_CellContentClick);
            // 
            // iDcarDataGridViewTextBoxColumn
            // 
            this.iDcarDataGridViewTextBoxColumn.DataPropertyName = "ID_car";
            this.iDcarDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDcarDataGridViewTextBoxColumn.Name = "iDcarDataGridViewTextBoxColumn";
            this.iDcarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markDataGridViewTextBoxColumn
            // 
            this.markDataGridViewTextBoxColumn.DataPropertyName = "Mark";
            this.markDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markDataGridViewTextBoxColumn.Name = "markDataGridViewTextBoxColumn";
            this.markDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // licensenumberDataGridViewTextBoxColumn
            // 
            this.licensenumberDataGridViewTextBoxColumn.DataPropertyName = "License_number";
            this.licensenumberDataGridViewTextBoxColumn.HeaderText = "Rejestracja";
            this.licensenumberDataGridViewTextBoxColumn.Name = "licensenumberDataGridViewTextBoxColumn";
            this.licensenumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Notatka";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportdateDataGridViewTextBoxColumn
            // 
            this.reportdateDataGridViewTextBoxColumn.DataPropertyName = "Report_date";
            this.reportdateDataGridViewTextBoxColumn.HeaderText = "Data";
            this.reportdateDataGridViewTextBoxColumn.Name = "reportdateDataGridViewTextBoxColumn";
            this.reportdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.myjniaDataSet;
            // 
            // myjniaDataSet
            // 
            this.myjniaDataSet.DataSetName = "MyjniaDataSet";
            this.myjniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // gb_Cars
            // 
            this.gb_Cars.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gb_Cars.Controls.Add(this.btn_UpdateCar);
            this.gb_Cars.Controls.Add(this.btn_DeleteCar);
            this.gb_Cars.Controls.Add(this.btn_InsertCar);
            this.gb_Cars.Controls.Add(this.lb_CarNote);
            this.gb_Cars.Controls.Add(this.lb_CarLicense);
            this.gb_Cars.Controls.Add(this.lb_CarModel);
            this.gb_Cars.Controls.Add(this.lb_CarMark);
            this.gb_Cars.Controls.Add(this.lb_CarID);
            this.gb_Cars.Controls.Add(this.tb_CarNote);
            this.gb_Cars.Controls.Add(this.tb_CarModel);
            this.gb_Cars.Controls.Add(this.tb_CarLicense);
            this.gb_Cars.Controls.Add(this.tb_CarMark);
            this.gb_Cars.Controls.Add(this.tb_CarID);
            this.gb_Cars.Location = new System.Drawing.Point(23, 33);
            this.gb_Cars.Name = "gb_Cars";
            this.gb_Cars.Size = new System.Drawing.Size(249, 269);
            this.gb_Cars.TabIndex = 1;
            this.gb_Cars.TabStop = false;
            this.gb_Cars.Text = "Samochód";
            // 
            // btn_UpdateCar
            // 
            this.btn_UpdateCar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_UpdateCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_UpdateCar.BackgroundImage")));
            this.btn_UpdateCar.Location = new System.Drawing.Point(165, 223);
            this.btn_UpdateCar.Name = "btn_UpdateCar";
            this.btn_UpdateCar.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateCar.TabIndex = 12;
            this.btn_UpdateCar.Text = "Aktualizuj";
            this.btn_UpdateCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UpdateCar.UseVisualStyleBackColor = false;
            this.btn_UpdateCar.Click += new System.EventHandler(this.btn_UpdateCar_Click);
            // 
            // btn_DeleteCar
            // 
            this.btn_DeleteCar.Image = global::Reczna_Myjnia_Samochodowa.Properties.Resources.Delete_Button;
            this.btn_DeleteCar.Location = new System.Drawing.Point(84, 223);
            this.btn_DeleteCar.Name = "btn_DeleteCar";
            this.btn_DeleteCar.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteCar.TabIndex = 11;
            this.btn_DeleteCar.Text = "Usuń";
            this.btn_DeleteCar.UseVisualStyleBackColor = true;
            this.btn_DeleteCar.Click += new System.EventHandler(this.btn_DeleteCar_Click);
            // 
            // btn_InsertCar
            // 
            this.btn_InsertCar.BackgroundImage = global::Reczna_Myjnia_Samochodowa.Properties.Resources.Add_Button;
            this.btn_InsertCar.Location = new System.Drawing.Point(3, 223);
            this.btn_InsertCar.Name = "btn_InsertCar";
            this.btn_InsertCar.Size = new System.Drawing.Size(75, 23);
            this.btn_InsertCar.TabIndex = 10;
            this.btn_InsertCar.Text = "Dodaj";
            this.btn_InsertCar.UseVisualStyleBackColor = true;
            this.btn_InsertCar.Click += new System.EventHandler(this.btn_CreateCar_Click);
            // 
            // lb_CarNote
            // 
            this.lb_CarNote.AutoSize = true;
            this.lb_CarNote.Location = new System.Drawing.Point(3, 131);
            this.lb_CarNote.Name = "lb_CarNote";
            this.lb_CarNote.Size = new System.Drawing.Size(40, 13);
            this.lb_CarNote.TabIndex = 9;
            this.lb_CarNote.Text = "Uwagi:";
            // 
            // lb_CarLicense
            // 
            this.lb_CarLicense.AutoSize = true;
            this.lb_CarLicense.Location = new System.Drawing.Point(18, 99);
            this.lb_CarLicense.Name = "lb_CarLicense";
            this.lb_CarLicense.Size = new System.Drawing.Size(60, 13);
            this.lb_CarLicense.TabIndex = 8;
            this.lb_CarLicense.Text = "Rejestracja";
            // 
            // lb_CarModel
            // 
            this.lb_CarModel.AutoSize = true;
            this.lb_CarModel.Location = new System.Drawing.Point(42, 76);
            this.lb_CarModel.Name = "lb_CarModel";
            this.lb_CarModel.Size = new System.Drawing.Size(36, 13);
            this.lb_CarModel.TabIndex = 7;
            this.lb_CarModel.Text = "Model";
            // 
            // lb_CarMark
            // 
            this.lb_CarMark.AutoSize = true;
            this.lb_CarMark.Location = new System.Drawing.Point(41, 50);
            this.lb_CarMark.Name = "lb_CarMark";
            this.lb_CarMark.Size = new System.Drawing.Size(37, 13);
            this.lb_CarMark.TabIndex = 6;
            this.lb_CarMark.Text = "Marka";
            // 
            // lb_CarID
            // 
            this.lb_CarID.AutoSize = true;
            this.lb_CarID.Location = new System.Drawing.Point(60, 28);
            this.lb_CarID.Name = "lb_CarID";
            this.lb_CarID.Size = new System.Drawing.Size(18, 13);
            this.lb_CarID.TabIndex = 5;
            this.lb_CarID.Text = "ID";
            // 
            // tb_CarNote
            // 
            this.tb_CarNote.Location = new System.Drawing.Point(6, 147);
            this.tb_CarNote.Multiline = true;
            this.tb_CarNote.Name = "tb_CarNote";
            this.tb_CarNote.Size = new System.Drawing.Size(234, 55);
            this.tb_CarNote.TabIndex = 4;
            // 
            // tb_CarModel
            // 
            this.tb_CarModel.Location = new System.Drawing.Point(84, 73);
            this.tb_CarModel.Name = "tb_CarModel";
            this.tb_CarModel.Size = new System.Drawing.Size(100, 20);
            this.tb_CarModel.TabIndex = 3;
            // 
            // tb_CarLicense
            // 
            this.tb_CarLicense.Location = new System.Drawing.Point(84, 99);
            this.tb_CarLicense.Name = "tb_CarLicense";
            this.tb_CarLicense.Size = new System.Drawing.Size(100, 20);
            this.tb_CarLicense.TabIndex = 2;
            // 
            // tb_CarMark
            // 
            this.tb_CarMark.Location = new System.Drawing.Point(84, 47);
            this.tb_CarMark.Name = "tb_CarMark";
            this.tb_CarMark.Size = new System.Drawing.Size(100, 20);
            this.tb_CarMark.TabIndex = 1;
            // 
            // tb_CarID
            // 
            this.tb_CarID.Location = new System.Drawing.Point(84, 21);
            this.tb_CarID.Name = "tb_CarID";
            this.tb_CarID.Size = new System.Drawing.Size(100, 20);
            this.tb_CarID.TabIndex = 0;
            // 
            // Form_Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 380);
            this.Controls.Add(this.gb_Cars);
            this.Controls.Add(this.CarGridView);
            this.Name = "Form_Cars";
            this.Text = "Samochody";
            this.Load += new System.EventHandler(this.Form_Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myjniaDataSet)).EndInit();
            this.gb_Cars.ResumeLayout(false);
            this.gb_Cars.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CarGridView;
        private MyjniaDataSet myjniaDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private MyjniaDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.GroupBox gb_Cars;
        private System.Windows.Forms.Label lb_CarID;
        private System.Windows.Forms.TextBox tb_CarNote;
        private System.Windows.Forms.TextBox tb_CarModel;
        private System.Windows.Forms.TextBox tb_CarLicense;
        private System.Windows.Forms.TextBox tb_CarMark;
        private System.Windows.Forms.TextBox tb_CarID;
        private System.Windows.Forms.Button btn_UpdateCar;
        private System.Windows.Forms.Button btn_DeleteCar;
        private System.Windows.Forms.Button btn_InsertCar;
        private System.Windows.Forms.Label lb_CarNote;
        private System.Windows.Forms.Label lb_CarLicense;
        private System.Windows.Forms.Label lb_CarModel;
        private System.Windows.Forms.Label lb_CarMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportdateDataGridViewTextBoxColumn;
    }
}