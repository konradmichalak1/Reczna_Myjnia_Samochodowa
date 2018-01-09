namespace Reczna_Myjnia_Samochodowa
{
    partial class Form_Main
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
            this.btn_cars = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_orders = new System.Windows.Forms.Button();
            this.btn_Employers = new System.Windows.Forms.Button();
            this.btn_services = new System.Windows.Forms.Button();
            this.btn_faults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cars
            // 
            this.btn_cars.Location = new System.Drawing.Point(12, 86);
            this.btn_cars.Name = "btn_cars";
            this.btn_cars.Size = new System.Drawing.Size(112, 55);
            this.btn_cars.TabIndex = 2;
            this.btn_cars.Text = "Samochody";
            this.btn_cars.UseVisualStyleBackColor = true;
            this.btn_cars.Click += new System.EventHandler(this.btn_cars_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.Location = new System.Drawing.Point(12, 147);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(112, 55);
            this.btn_customers.TabIndex = 1;
            this.btn_customers.Text = "Klienci";
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_orders
            // 
            this.btn_orders.Location = new System.Drawing.Point(12, 25);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(112, 55);
            this.btn_orders.TabIndex = 0;
            this.btn_orders.Text = "Zamówienia";
            this.btn_orders.UseVisualStyleBackColor = true;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // btn_Employers
            // 
            this.btn_Employers.Location = new System.Drawing.Point(139, 25);
            this.btn_Employers.Name = "btn_Employers";
            this.btn_Employers.Size = new System.Drawing.Size(112, 55);
            this.btn_Employers.TabIndex = 3;
            this.btn_Employers.Text = "Pracownicy";
            this.btn_Employers.UseVisualStyleBackColor = true;
            this.btn_Employers.Click += new System.EventHandler(this.btn_Employers_Click);
            // 
            // btn_services
            // 
            this.btn_services.Location = new System.Drawing.Point(139, 86);
            this.btn_services.Name = "btn_services";
            this.btn_services.Size = new System.Drawing.Size(112, 55);
            this.btn_services.TabIndex = 4;
            this.btn_services.Text = "Usługi";
            this.btn_services.UseVisualStyleBackColor = true;
            this.btn_services.Click += new System.EventHandler(this.btn_services_Click);
            // 
            // btn_faults
            // 
            this.btn_faults.Location = new System.Drawing.Point(139, 147);
            this.btn_faults.Name = "btn_faults";
            this.btn_faults.Size = new System.Drawing.Size(112, 55);
            this.btn_faults.TabIndex = 5;
            this.btn_faults.Text = "Usterki";
            this.btn_faults.UseVisualStyleBackColor = true;
            this.btn_faults.Click += new System.EventHandler(this.btn_faults_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 261);
            this.Controls.Add(this.btn_faults);
            this.Controls.Add(this.btn_services);
            this.Controls.Add(this.btn_Employers);
            this.Controls.Add(this.btn_orders);
            this.Controls.Add(this.btn_customers);
            this.Controls.Add(this.btn_cars);
            this.Name = "Form_Main";
            this.Text = "Ręczna Myjnia Samochodowa";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cars;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.Button btn_Employers;
        private System.Windows.Forms.Button btn_services;
        private System.Windows.Forms.Button btn_faults;
    }
}

