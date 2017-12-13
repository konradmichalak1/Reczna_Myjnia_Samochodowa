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
            this.SuspendLayout();
            // 
            // btn_cars
            // 
            this.btn_cars.Location = new System.Drawing.Point(62, 86);
            this.btn_cars.Name = "btn_cars";
            this.btn_cars.Size = new System.Drawing.Size(112, 55);
            this.btn_cars.TabIndex = 0;
            this.btn_cars.Text = "Samochody";
            this.btn_cars.UseVisualStyleBackColor = true;
            this.btn_cars.Click += new System.EventHandler(this.btn_cars_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.Location = new System.Drawing.Point(201, 86);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(112, 55);
            this.btn_customers.TabIndex = 1;
            this.btn_customers.Text = "Klienci";
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 261);
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
    }
}

