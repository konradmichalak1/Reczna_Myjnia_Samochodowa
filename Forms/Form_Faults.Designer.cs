namespace Reczna_Myjnia_Samochodowa
{
    partial class Form_Faults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Faults));
            this.faultGridView = new System.Windows.Forms.DataGridView();
            this.faultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faultsDataSet = new Reczna_Myjnia_Samochodowa.FaultsDataSet();
            this.faultsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faultTableAdapter = new Reczna_Myjnia_Samochodowa.FaultsDataSetTableAdapters.FaultTableAdapter();
            this.gb_Faults = new System.Windows.Forms.GroupBox();
            this.btn_UpdateFault = new System.Windows.Forms.Button();
            this.btn_DeleteFault = new System.Windows.Forms.Button();
            this.btn_InsertFault = new System.Windows.Forms.Button();
            this.lb_FaultNote = new System.Windows.Forms.Label();
            this.lb_FaultID = new System.Windows.Forms.Label();
            this.tb_CarNote = new System.Windows.Forms.TextBox();
            this.tb_FaultID = new System.Windows.Forms.TextBox();
            this.iDfaultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.faultGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultsDataSetBindingSource)).BeginInit();
            this.gb_Faults.SuspendLayout();
            this.SuspendLayout();
            // 
            // faultGridView
            // 
            this.faultGridView.AutoGenerateColumns = false;
            this.faultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.faultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDfaultDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.reportdateDataGridViewTextBoxColumn});
            this.faultGridView.DataSource = this.faultBindingSource;
            this.faultGridView.Location = new System.Drawing.Point(277, 12);
            this.faultGridView.Name = "faultGridView";
            this.faultGridView.ReadOnly = true;
            this.faultGridView.Size = new System.Drawing.Size(379, 269);
            this.faultGridView.TabIndex = 0;
            this.faultGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.faultGridView_CellMouseClick);
            // 
            // faultBindingSource
            // 
            this.faultBindingSource.DataMember = "Fault";
            this.faultBindingSource.DataSource = this.faultsDataSet;
            // 
            // faultsDataSet
            // 
            this.faultsDataSet.DataSetName = "FaultsDataSet";
            this.faultsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // faultsDataSetBindingSource
            // 
            this.faultsDataSetBindingSource.DataSource = this.faultsDataSet;
            this.faultsDataSetBindingSource.Position = 0;
            // 
            // faultTableAdapter
            // 
            this.faultTableAdapter.ClearBeforeFill = true;
            // 
            // gb_Faults
            // 
            this.gb_Faults.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gb_Faults.Controls.Add(this.btn_UpdateFault);
            this.gb_Faults.Controls.Add(this.btn_DeleteFault);
            this.gb_Faults.Controls.Add(this.btn_InsertFault);
            this.gb_Faults.Controls.Add(this.lb_FaultNote);
            this.gb_Faults.Controls.Add(this.lb_FaultID);
            this.gb_Faults.Controls.Add(this.tb_CarNote);
            this.gb_Faults.Controls.Add(this.tb_FaultID);
            this.gb_Faults.Location = new System.Drawing.Point(12, 12);
            this.gb_Faults.Name = "gb_Faults";
            this.gb_Faults.Size = new System.Drawing.Size(249, 269);
            this.gb_Faults.TabIndex = 2;
            this.gb_Faults.TabStop = false;
            this.gb_Faults.Text = "Usterka";
            // 
            // btn_UpdateFault
            // 
            this.btn_UpdateFault.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_UpdateFault.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_UpdateFault.BackgroundImage")));
            this.btn_UpdateFault.Location = new System.Drawing.Point(165, 223);
            this.btn_UpdateFault.Name = "btn_UpdateFault";
            this.btn_UpdateFault.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateFault.TabIndex = 12;
            this.btn_UpdateFault.Text = "Aktualizuj";
            this.btn_UpdateFault.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UpdateFault.UseVisualStyleBackColor = false;
            this.btn_UpdateFault.Click += new System.EventHandler(this.btn_UpdateFault_Click);
            // 
            // btn_DeleteFault
            // 
            this.btn_DeleteFault.Image = global::Reczna_Myjnia_Samochodowa.Properties.Resources.Delete_Button;
            this.btn_DeleteFault.Location = new System.Drawing.Point(84, 223);
            this.btn_DeleteFault.Name = "btn_DeleteFault";
            this.btn_DeleteFault.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteFault.TabIndex = 11;
            this.btn_DeleteFault.Text = "Usuń";
            this.btn_DeleteFault.UseVisualStyleBackColor = true;
            this.btn_DeleteFault.Click += new System.EventHandler(this.btn_DeleteFault_Click);
            // 
            // btn_InsertFault
            // 
            this.btn_InsertFault.BackgroundImage = global::Reczna_Myjnia_Samochodowa.Properties.Resources.Add_Button;
            this.btn_InsertFault.Location = new System.Drawing.Point(3, 223);
            this.btn_InsertFault.Name = "btn_InsertFault";
            this.btn_InsertFault.Size = new System.Drawing.Size(75, 23);
            this.btn_InsertFault.TabIndex = 10;
            this.btn_InsertFault.Text = "Dodaj";
            this.btn_InsertFault.UseVisualStyleBackColor = true;
            this.btn_InsertFault.Click += new System.EventHandler(this.btn_InsertFault_Click);
            // 
            // lb_FaultNote
            // 
            this.lb_FaultNote.AutoSize = true;
            this.lb_FaultNote.Location = new System.Drawing.Point(6, 32);
            this.lb_FaultNote.Name = "lb_FaultNote";
            this.lb_FaultNote.Size = new System.Drawing.Size(65, 13);
            this.lb_FaultNote.TabIndex = 9;
            this.lb_FaultNote.Text = "Opis usterki:";
            // 
            // lb_FaultID
            // 
            this.lb_FaultID.AutoSize = true;
            this.lb_FaultID.Location = new System.Drawing.Point(104, 201);
            this.lb_FaultID.Name = "lb_FaultID";
            this.lb_FaultID.Size = new System.Drawing.Size(18, 13);
            this.lb_FaultID.TabIndex = 5;
            this.lb_FaultID.Text = "ID";
            // 
            // tb_CarNote
            // 
            this.tb_CarNote.Location = new System.Drawing.Point(9, 48);
            this.tb_CarNote.Multiline = true;
            this.tb_CarNote.Name = "tb_CarNote";
            this.tb_CarNote.Size = new System.Drawing.Size(234, 80);
            this.tb_CarNote.TabIndex = 4;
            // 
            // tb_FaultID
            // 
            this.tb_FaultID.Location = new System.Drawing.Point(128, 197);
            this.tb_FaultID.Name = "tb_FaultID";
            this.tb_FaultID.Size = new System.Drawing.Size(100, 20);
            this.tb_FaultID.TabIndex = 0;
            // 
            // iDfaultDataGridViewTextBoxColumn
            // 
            this.iDfaultDataGridViewTextBoxColumn.DataPropertyName = "ID_fault";
            this.iDfaultDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDfaultDataGridViewTextBoxColumn.Name = "iDfaultDataGridViewTextBoxColumn";
            this.iDfaultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Opis usterki";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportdateDataGridViewTextBoxColumn
            // 
            this.reportdateDataGridViewTextBoxColumn.DataPropertyName = "Report_date";
            this.reportdateDataGridViewTextBoxColumn.HeaderText = "Data zgłoszenia";
            this.reportdateDataGridViewTextBoxColumn.Name = "reportdateDataGridViewTextBoxColumn";
            this.reportdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.reportdateDataGridViewTextBoxColumn.Width = 130;
            // 
            // Form_Faults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 293);
            this.Controls.Add(this.gb_Faults);
            this.Controls.Add(this.faultGridView);
            this.Name = "Form_Faults";
            this.Text = "Usterki";
            this.Load += new System.EventHandler(this.Form_Faults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.faultGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultsDataSetBindingSource)).EndInit();
            this.gb_Faults.ResumeLayout(false);
            this.gb_Faults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView faultGridView;
        private System.Windows.Forms.BindingSource faultsDataSetBindingSource;
        private FaultsDataSet faultsDataSet;
        private System.Windows.Forms.BindingSource faultBindingSource;
        private FaultsDataSetTableAdapters.FaultTableAdapter faultTableAdapter;
        private System.Windows.Forms.GroupBox gb_Faults;
        private System.Windows.Forms.Button btn_UpdateFault;
        private System.Windows.Forms.Button btn_DeleteFault;
        private System.Windows.Forms.Button btn_InsertFault;
        private System.Windows.Forms.Label lb_FaultNote;
        private System.Windows.Forms.Label lb_FaultID;
        private System.Windows.Forms.TextBox tb_CarNote;
        private System.Windows.Forms.TextBox tb_FaultID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDfaultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportdateDataGridViewTextBoxColumn;
    }
}