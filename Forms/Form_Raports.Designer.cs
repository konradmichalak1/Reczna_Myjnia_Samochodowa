namespace Reczna_Myjnia_Samochodowa
{
    partial class Form_Raport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Raport));
            this.btn_generalRaport = new System.Windows.Forms.Button();
            this.dtp_dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtp_timeFrom = new System.Windows.Forms.DateTimePicker();
            this.dtp_timeTo = new System.Windows.Forms.DateTimePicker();
            this.dtp_dateTo = new System.Windows.Forms.DateTimePicker();
            this.lb_text1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_daily = new System.Windows.Forms.Button();
            this.btn_weekly = new System.Windows.Forms.Button();
            this.btn_monthly = new System.Windows.Forms.Button();
            this.btn_detailedRaport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_generalRaport
            // 
            this.btn_generalRaport.Location = new System.Drawing.Point(25, 168);
            this.btn_generalRaport.Name = "btn_generalRaport";
            this.btn_generalRaport.Size = new System.Drawing.Size(137, 41);
            this.btn_generalRaport.TabIndex = 7;
            this.btn_generalRaport.Text = "Raport ogólny";
            this.btn_generalRaport.UseVisualStyleBackColor = true;
            this.btn_generalRaport.Click += new System.EventHandler(this.btn_createRaport_Click);
            // 
            // dtp_dateFrom
            // 
            this.dtp_dateFrom.Location = new System.Drawing.Point(39, 51);
            this.dtp_dateFrom.Name = "dtp_dateFrom";
            this.dtp_dateFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_dateFrom.Size = new System.Drawing.Size(189, 20);
            this.dtp_dateFrom.TabIndex = 0;
            // 
            // dtp_timeFrom
            // 
            this.dtp_timeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_timeFrom.Location = new System.Drawing.Point(234, 51);
            this.dtp_timeFrom.Name = "dtp_timeFrom";
            this.dtp_timeFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_timeFrom.ShowUpDown = true;
            this.dtp_timeFrom.Size = new System.Drawing.Size(81, 20);
            this.dtp_timeFrom.TabIndex = 1;
            // 
            // dtp_timeTo
            // 
            this.dtp_timeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_timeTo.Location = new System.Drawing.Point(234, 77);
            this.dtp_timeTo.Name = "dtp_timeTo";
            this.dtp_timeTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_timeTo.ShowUpDown = true;
            this.dtp_timeTo.Size = new System.Drawing.Size(81, 20);
            this.dtp_timeTo.TabIndex = 3;
            // 
            // dtp_dateTo
            // 
            this.dtp_dateTo.Location = new System.Drawing.Point(39, 77);
            this.dtp_dateTo.Name = "dtp_dateTo";
            this.dtp_dateTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_dateTo.Size = new System.Drawing.Size(189, 20);
            this.dtp_dateTo.TabIndex = 2;
            // 
            // lb_text1
            // 
            this.lb_text1.AutoSize = true;
            this.lb_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lb_text1.Location = new System.Drawing.Point(7, 21);
            this.lb_text1.Name = "lb_text1";
            this.lb_text1.Size = new System.Drawing.Size(136, 16);
            this.lb_text1.TabIndex = 5;
            this.lb_text1.Text = "Sporządzanie raportu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "do:";
            // 
            // btn_daily
            // 
            this.btn_daily.Location = new System.Drawing.Point(57, 103);
            this.btn_daily.Name = "btn_daily";
            this.btn_daily.Size = new System.Drawing.Size(75, 27);
            this.btn_daily.TabIndex = 4;
            this.btn_daily.Text = "Dzienny";
            this.btn_daily.UseVisualStyleBackColor = true;
            this.btn_daily.Click += new System.EventHandler(this.btn_daily_Click);
            // 
            // btn_weekly
            // 
            this.btn_weekly.Location = new System.Drawing.Point(138, 103);
            this.btn_weekly.Name = "btn_weekly";
            this.btn_weekly.Size = new System.Drawing.Size(75, 27);
            this.btn_weekly.TabIndex = 5;
            this.btn_weekly.Text = "Tygodniowy";
            this.btn_weekly.UseVisualStyleBackColor = true;
            this.btn_weekly.Click += new System.EventHandler(this.btn_weekly_Click);
            // 
            // btn_monthly
            // 
            this.btn_monthly.Location = new System.Drawing.Point(219, 103);
            this.btn_monthly.Name = "btn_monthly";
            this.btn_monthly.Size = new System.Drawing.Size(75, 27);
            this.btn_monthly.TabIndex = 6;
            this.btn_monthly.Text = "Miesięczny";
            this.btn_monthly.UseVisualStyleBackColor = true;
            this.btn_monthly.Click += new System.EventHandler(this.btn_monthly_Click);
            // 
            // btn_detailedRaport
            // 
            this.btn_detailedRaport.Location = new System.Drawing.Point(168, 168);
            this.btn_detailedRaport.Name = "btn_detailedRaport";
            this.btn_detailedRaport.Size = new System.Drawing.Size(137, 41);
            this.btn_detailedRaport.TabIndex = 8;
            this.btn_detailedRaport.Text = "Raport szczegółowy";
            this.btn_detailedRaport.UseVisualStyleBackColor = true;
            // 
            // Form_Raport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 235);
            this.Controls.Add(this.btn_detailedRaport);
            this.Controls.Add(this.btn_monthly);
            this.Controls.Add(this.btn_weekly);
            this.Controls.Add(this.btn_daily);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_text1);
            this.Controls.Add(this.dtp_timeTo);
            this.Controls.Add(this.dtp_dateTo);
            this.Controls.Add(this.dtp_timeFrom);
            this.Controls.Add(this.dtp_dateFrom);
            this.Controls.Add(this.btn_generalRaport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Raport";
            this.Text = "Raporty";
            this.Load += new System.EventHandler(this.Form_Raport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generalRaport;
        private System.Windows.Forms.DateTimePicker dtp_dateFrom;
        private System.Windows.Forms.DateTimePicker dtp_timeFrom;
        private System.Windows.Forms.DateTimePicker dtp_timeTo;
        private System.Windows.Forms.DateTimePicker dtp_dateTo;
        private System.Windows.Forms.Label lb_text1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_daily;
        private System.Windows.Forms.Button btn_weekly;
        private System.Windows.Forms.Button btn_monthly;
        private System.Windows.Forms.Button btn_detailedRaport;
    }
}