namespace Reczna_Myjnia_Samochodowa
{
    partial class Form_Orders
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
            this.gb_Orders = new System.Windows.Forms.GroupBox();
            this.tb_Fault = new System.Windows.Forms.TextBox();
            this.cb_ServiceList = new System.Windows.Forms.ComboBox();
            this.cb_EmployeeList = new System.Windows.Forms.ComboBox();
            this.btn_SetFault = new System.Windows.Forms.Button();
            this.btn_SetService = new System.Windows.Forms.Button();
            this.btn_SetEmployee = new System.Windows.Forms.Button();
            this.btn_UpdateOrder = new System.Windows.Forms.Button();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.btn_DeleteOrder = new System.Windows.Forms.Button();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.btn_InsertOrder = new System.Windows.Forms.Button();
            this.btn_EndTimeSet = new System.Windows.Forms.Button();
            this.btn_StartTimeSet = new System.Windows.Forms.Button();
            this.tb_EndTime = new System.Windows.Forms.TextBox();
            this.tb_StartTime = new System.Windows.Forms.TextBox();
            this.btn_CarIDChoose = new System.Windows.Forms.Button();
            this.btn_CustomerIDChoose = new System.Windows.Forms.Button();
            this.tb_CarID = new System.Windows.Forms.TextBox();
            this.tb_CustomerID = new System.Windows.Forms.TextBox();
            this.lb_OrderFault = new System.Windows.Forms.Label();
            this.lb_OrderServices = new System.Windows.Forms.Label();
            this.tb_DocumentID = new System.Windows.Forms.TextBox();
            this.tb_OrderID = new System.Windows.Forms.TextBox();
            this.cb_orderWorkspaceNr = new System.Windows.Forms.ComboBox();
            this.cb_OrderDocumenttype = new System.Windows.Forms.CheckBox();
            this.cb_OrderPaymenttype = new System.Windows.Forms.CheckBox();
            this.lb_OrderWorkplaceNr = new System.Windows.Forms.Label();
            this.lb_OrderDiscount = new System.Windows.Forms.Label();
            this.lb_OrderPrice = new System.Windows.Forms.Label();
            this.lb_OrderEndTime = new System.Windows.Forms.Label();
            this.lb_OrderStartTime = new System.Windows.Forms.Label();
            this.lb_OrderIDDocument = new System.Windows.Forms.Label();
            this.lb_OrdersIDCar = new System.Windows.Forms.Label();
            this.lb_OrdersIDCustomer = new System.Windows.Forms.Label();
            this.lb_OrderEmployee = new System.Windows.Forms.Label();
            this.lb_id_order = new System.Windows.Forms.Label();
            this.gb_Orders.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Orders
            // 
            this.gb_Orders.Controls.Add(this.tb_Fault);
            this.gb_Orders.Controls.Add(this.cb_ServiceList);
            this.gb_Orders.Controls.Add(this.cb_EmployeeList);
            this.gb_Orders.Controls.Add(this.btn_SetFault);
            this.gb_Orders.Controls.Add(this.btn_SetService);
            this.gb_Orders.Controls.Add(this.btn_SetEmployee);
            this.gb_Orders.Controls.Add(this.btn_UpdateOrder);
            this.gb_Orders.Controls.Add(this.tb_Discount);
            this.gb_Orders.Controls.Add(this.btn_DeleteOrder);
            this.gb_Orders.Controls.Add(this.tb_Price);
            this.gb_Orders.Controls.Add(this.btn_InsertOrder);
            this.gb_Orders.Controls.Add(this.btn_EndTimeSet);
            this.gb_Orders.Controls.Add(this.btn_StartTimeSet);
            this.gb_Orders.Controls.Add(this.tb_EndTime);
            this.gb_Orders.Controls.Add(this.tb_StartTime);
            this.gb_Orders.Controls.Add(this.btn_CarIDChoose);
            this.gb_Orders.Controls.Add(this.btn_CustomerIDChoose);
            this.gb_Orders.Controls.Add(this.tb_CarID);
            this.gb_Orders.Controls.Add(this.tb_CustomerID);
            this.gb_Orders.Controls.Add(this.lb_OrderFault);
            this.gb_Orders.Controls.Add(this.lb_OrderServices);
            this.gb_Orders.Controls.Add(this.tb_DocumentID);
            this.gb_Orders.Controls.Add(this.tb_OrderID);
            this.gb_Orders.Controls.Add(this.cb_orderWorkspaceNr);
            this.gb_Orders.Controls.Add(this.cb_OrderDocumenttype);
            this.gb_Orders.Controls.Add(this.cb_OrderPaymenttype);
            this.gb_Orders.Controls.Add(this.lb_OrderWorkplaceNr);
            this.gb_Orders.Controls.Add(this.lb_OrderDiscount);
            this.gb_Orders.Controls.Add(this.lb_OrderPrice);
            this.gb_Orders.Controls.Add(this.lb_OrderEndTime);
            this.gb_Orders.Controls.Add(this.lb_OrderStartTime);
            this.gb_Orders.Controls.Add(this.lb_OrderIDDocument);
            this.gb_Orders.Controls.Add(this.lb_OrdersIDCar);
            this.gb_Orders.Controls.Add(this.lb_OrdersIDCustomer);
            this.gb_Orders.Controls.Add(this.lb_OrderEmployee);
            this.gb_Orders.Controls.Add(this.lb_id_order);
            this.gb_Orders.Location = new System.Drawing.Point(12, 12);
            this.gb_Orders.Name = "gb_Orders";
            this.gb_Orders.Size = new System.Drawing.Size(311, 410);
            this.gb_Orders.TabIndex = 1;
            this.gb_Orders.TabStop = false;
            this.gb_Orders.Text = "Zamówienie";
            // 
            // tb_Fault
            // 
            this.tb_Fault.Enabled = false;
            this.tb_Fault.Location = new System.Drawing.Point(74, 281);
            this.tb_Fault.Name = "tb_Fault";
            this.tb_Fault.Size = new System.Drawing.Size(92, 20);
            this.tb_Fault.TabIndex = 32;
            // 
            // cb_ServiceList
            // 
            this.cb_ServiceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ServiceList.FormattingEnabled = true;
            this.cb_ServiceList.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_ServiceList.Location = new System.Drawing.Point(74, 252);
            this.cb_ServiceList.Name = "cb_ServiceList";
            this.cb_ServiceList.Size = new System.Drawing.Size(91, 21);
            this.cb_ServiceList.Sorted = true;
            this.cb_ServiceList.TabIndex = 31;
            // 
            // cb_EmployeeList
            // 
            this.cb_EmployeeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EmployeeList.FormattingEnabled = true;
            this.cb_EmployeeList.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_EmployeeList.Location = new System.Drawing.Point(74, 222);
            this.cb_EmployeeList.Name = "cb_EmployeeList";
            this.cb_EmployeeList.Size = new System.Drawing.Size(91, 21);
            this.cb_EmployeeList.Sorted = true;
            this.cb_EmployeeList.TabIndex = 30;
            // 
            // btn_SetFault
            // 
            this.btn_SetFault.Location = new System.Drawing.Point(187, 278);
            this.btn_SetFault.Name = "btn_SetFault";
            this.btn_SetFault.Size = new System.Drawing.Size(62, 23);
            this.btn_SetFault.TabIndex = 29;
            this.btn_SetFault.Text = "Przypisz";
            this.btn_SetFault.UseVisualStyleBackColor = true;
            // 
            // btn_SetService
            // 
            this.btn_SetService.Location = new System.Drawing.Point(187, 250);
            this.btn_SetService.Name = "btn_SetService";
            this.btn_SetService.Size = new System.Drawing.Size(62, 23);
            this.btn_SetService.TabIndex = 28;
            this.btn_SetService.Text = "Przypisz";
            this.btn_SetService.UseVisualStyleBackColor = true;
            // 
            // btn_SetEmployee
            // 
            this.btn_SetEmployee.Location = new System.Drawing.Point(187, 222);
            this.btn_SetEmployee.Name = "btn_SetEmployee";
            this.btn_SetEmployee.Size = new System.Drawing.Size(62, 23);
            this.btn_SetEmployee.TabIndex = 27;
            this.btn_SetEmployee.Text = "Przypisz";
            this.btn_SetEmployee.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateOrder
            // 
            this.btn_UpdateOrder.BackgroundImage = global::Reczna_Myjnia_Samochodowa.Properties.Resources.Update_Button;
            this.btn_UpdateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_UpdateOrder.Location = new System.Drawing.Point(174, 381);
            this.btn_UpdateOrder.Name = "btn_UpdateOrder";
            this.btn_UpdateOrder.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateOrder.TabIndex = 15;
            this.btn_UpdateOrder.Text = "Aktualizuj";
            this.btn_UpdateOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UpdateOrder.UseVisualStyleBackColor = true;
            // 
            // tb_Discount
            // 
            this.tb_Discount.Enabled = false;
            this.tb_Discount.Location = new System.Drawing.Point(182, 325);
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(67, 20);
            this.tb_Discount.TabIndex = 26;
            // 
            // btn_DeleteOrder
            // 
            this.btn_DeleteOrder.BackgroundImage = global::Reczna_Myjnia_Samochodowa.Properties.Resources.Delete_Button;
            this.btn_DeleteOrder.Location = new System.Drawing.Point(93, 381);
            this.btn_DeleteOrder.Name = "btn_DeleteOrder";
            this.btn_DeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteOrder.TabIndex = 14;
            this.btn_DeleteOrder.Text = "Usuń";
            this.btn_DeleteOrder.UseVisualStyleBackColor = true;
            // 
            // tb_Price
            // 
            this.tb_Price.Enabled = false;
            this.tb_Price.Location = new System.Drawing.Point(44, 326);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(92, 20);
            this.tb_Price.TabIndex = 25;
            // 
            // btn_InsertOrder
            // 
            this.btn_InsertOrder.BackgroundImage = global::Reczna_Myjnia_Samochodowa.Properties.Resources.Add_Button;
            this.btn_InsertOrder.Location = new System.Drawing.Point(12, 381);
            this.btn_InsertOrder.Name = "btn_InsertOrder";
            this.btn_InsertOrder.Size = new System.Drawing.Size(75, 23);
            this.btn_InsertOrder.TabIndex = 13;
            this.btn_InsertOrder.Text = "Dodaj";
            this.btn_InsertOrder.UseVisualStyleBackColor = true;
            // 
            // btn_EndTimeSet
            // 
            this.btn_EndTimeSet.Location = new System.Drawing.Point(182, 149);
            this.btn_EndTimeSet.Name = "btn_EndTimeSet";
            this.btn_EndTimeSet.Size = new System.Drawing.Size(47, 23);
            this.btn_EndTimeSet.TabIndex = 24;
            this.btn_EndTimeSet.Text = "Ustaw";
            this.btn_EndTimeSet.UseVisualStyleBackColor = true;
            // 
            // btn_StartTimeSet
            // 
            this.btn_StartTimeSet.Location = new System.Drawing.Point(182, 127);
            this.btn_StartTimeSet.Name = "btn_StartTimeSet";
            this.btn_StartTimeSet.Size = new System.Drawing.Size(47, 23);
            this.btn_StartTimeSet.TabIndex = 23;
            this.btn_StartTimeSet.Text = "Ustaw";
            this.btn_StartTimeSet.UseVisualStyleBackColor = true;
            // 
            // tb_EndTime
            // 
            this.tb_EndTime.Enabled = false;
            this.tb_EndTime.Location = new System.Drawing.Point(84, 151);
            this.tb_EndTime.Name = "tb_EndTime";
            this.tb_EndTime.Size = new System.Drawing.Size(92, 20);
            this.tb_EndTime.TabIndex = 22;
            // 
            // tb_StartTime
            // 
            this.tb_StartTime.Enabled = false;
            this.tb_StartTime.Location = new System.Drawing.Point(84, 128);
            this.tb_StartTime.Name = "tb_StartTime";
            this.tb_StartTime.Size = new System.Drawing.Size(92, 20);
            this.tb_StartTime.TabIndex = 21;
            // 
            // btn_CarIDChoose
            // 
            this.btn_CarIDChoose.Location = new System.Drawing.Point(182, 84);
            this.btn_CarIDChoose.Name = "btn_CarIDChoose";
            this.btn_CarIDChoose.Size = new System.Drawing.Size(75, 23);
            this.btn_CarIDChoose.TabIndex = 20;
            this.btn_CarIDChoose.Text = "Wyszukaj";
            this.btn_CarIDChoose.UseVisualStyleBackColor = true;
            // 
            // btn_CustomerIDChoose
            // 
            this.btn_CustomerIDChoose.Location = new System.Drawing.Point(182, 58);
            this.btn_CustomerIDChoose.Name = "btn_CustomerIDChoose";
            this.btn_CustomerIDChoose.Size = new System.Drawing.Size(75, 23);
            this.btn_CustomerIDChoose.TabIndex = 19;
            this.btn_CustomerIDChoose.Text = "Wyszukaj";
            this.btn_CustomerIDChoose.UseVisualStyleBackColor = true;
            // 
            // tb_CarID
            // 
            this.tb_CarID.Location = new System.Drawing.Point(88, 84);
            this.tb_CarID.Name = "tb_CarID";
            this.tb_CarID.Size = new System.Drawing.Size(88, 20);
            this.tb_CarID.TabIndex = 18;
            // 
            // tb_CustomerID
            // 
            this.tb_CustomerID.Location = new System.Drawing.Point(88, 60);
            this.tb_CustomerID.Name = "tb_CustomerID";
            this.tb_CustomerID.Size = new System.Drawing.Size(88, 20);
            this.tb_CustomerID.TabIndex = 17;
            // 
            // lb_OrderFault
            // 
            this.lb_OrderFault.AutoSize = true;
            this.lb_OrderFault.Location = new System.Drawing.Point(7, 284);
            this.lb_OrderFault.Name = "lb_OrderFault";
            this.lb_OrderFault.Size = new System.Drawing.Size(47, 13);
            this.lb_OrderFault.TabIndex = 16;
            this.lb_OrderFault.Text = "Usterka:";
            // 
            // lb_OrderServices
            // 
            this.lb_OrderServices.AutoSize = true;
            this.lb_OrderServices.Location = new System.Drawing.Point(7, 255);
            this.lb_OrderServices.Name = "lb_OrderServices";
            this.lb_OrderServices.Size = new System.Drawing.Size(41, 13);
            this.lb_OrderServices.TabIndex = 15;
            this.lb_OrderServices.Text = "Usługi:";
            // 
            // tb_DocumentID
            // 
            this.tb_DocumentID.Location = new System.Drawing.Point(213, 25);
            this.tb_DocumentID.Name = "tb_DocumentID";
            this.tb_DocumentID.Size = new System.Drawing.Size(77, 20);
            this.tb_DocumentID.TabIndex = 14;
            // 
            // tb_OrderID
            // 
            this.tb_OrderID.Location = new System.Drawing.Point(27, 25);
            this.tb_OrderID.Name = "tb_OrderID";
            this.tb_OrderID.Size = new System.Drawing.Size(76, 20);
            this.tb_OrderID.TabIndex = 13;
            // 
            // cb_orderWorkspaceNr
            // 
            this.cb_orderWorkspaceNr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_orderWorkspaceNr.FormattingEnabled = true;
            this.cb_orderWorkspaceNr.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_orderWorkspaceNr.Location = new System.Drawing.Point(107, 184);
            this.cb_orderWorkspaceNr.Name = "cb_orderWorkspaceNr";
            this.cb_orderWorkspaceNr.Size = new System.Drawing.Size(36, 21);
            this.cb_orderWorkspaceNr.Sorted = true;
            this.cb_orderWorkspaceNr.TabIndex = 12;
            // 
            // cb_OrderDocumenttype
            // 
            this.cb_OrderDocumenttype.AutoSize = true;
            this.cb_OrderDocumenttype.Location = new System.Drawing.Point(114, 352);
            this.cb_OrderDocumenttype.Name = "cb_OrderDocumenttype";
            this.cb_OrderDocumenttype.Size = new System.Drawing.Size(62, 17);
            this.cb_OrderDocumenttype.TabIndex = 11;
            this.cb_OrderDocumenttype.Text = "Faktura";
            this.cb_OrderDocumenttype.UseVisualStyleBackColor = true;
            // 
            // cb_OrderPaymenttype
            // 
            this.cb_OrderPaymenttype.AutoSize = true;
            this.cb_OrderPaymenttype.Location = new System.Drawing.Point(7, 352);
            this.cb_OrderPaymenttype.Name = "cb_OrderPaymenttype";
            this.cb_OrderPaymenttype.Size = new System.Drawing.Size(96, 17);
            this.cb_OrderPaymenttype.TabIndex = 10;
            this.cb_OrderPaymenttype.Text = "Płatność kartą";
            this.cb_OrderPaymenttype.UseVisualStyleBackColor = true;
            // 
            // lb_OrderWorkplaceNr
            // 
            this.lb_OrderWorkplaceNr.AutoSize = true;
            this.lb_OrderWorkplaceNr.Location = new System.Drawing.Point(6, 187);
            this.lb_OrderWorkplaceNr.Name = "lb_OrderWorkplaceNr";
            this.lb_OrderWorkplaceNr.Size = new System.Drawing.Size(97, 13);
            this.lb_OrderWorkplaceNr.TabIndex = 9;
            this.lb_OrderWorkplaceNr.Text = "Numer stanowiska:";
            // 
            // lb_OrderDiscount
            // 
            this.lb_OrderDiscount.AutoSize = true;
            this.lb_OrderDiscount.Location = new System.Drawing.Point(142, 329);
            this.lb_OrderDiscount.Name = "lb_OrderDiscount";
            this.lb_OrderDiscount.Size = new System.Drawing.Size(42, 13);
            this.lb_OrderDiscount.TabIndex = 8;
            this.lb_OrderDiscount.Text = "Zniżka:";
            // 
            // lb_OrderPrice
            // 
            this.lb_OrderPrice.AutoSize = true;
            this.lb_OrderPrice.Location = new System.Drawing.Point(3, 328);
            this.lb_OrderPrice.Name = "lb_OrderPrice";
            this.lb_OrderPrice.Size = new System.Drawing.Size(35, 13);
            this.lb_OrderPrice.TabIndex = 7;
            this.lb_OrderPrice.Text = "Cena:";
            // 
            // lb_OrderEndTime
            // 
            this.lb_OrderEndTime.AutoSize = true;
            this.lb_OrderEndTime.Location = new System.Drawing.Point(6, 154);
            this.lb_OrderEndTime.Name = "lb_OrderEndTime";
            this.lb_OrderEndTime.Size = new System.Drawing.Size(72, 13);
            this.lb_OrderEndTime.TabIndex = 6;
            this.lb_OrderEndTime.Text = "Zakończenie:";
            // 
            // lb_OrderStartTime
            // 
            this.lb_OrderStartTime.AutoSize = true;
            this.lb_OrderStartTime.Location = new System.Drawing.Point(6, 131);
            this.lb_OrderStartTime.Name = "lb_OrderStartTime";
            this.lb_OrderStartTime.Size = new System.Drawing.Size(72, 13);
            this.lb_OrderStartTime.TabIndex = 5;
            this.lb_OrderStartTime.Text = "Rozpoczęcie:";
            // 
            // lb_OrderIDDocument
            // 
            this.lb_OrderIDDocument.AutoSize = true;
            this.lb_OrderIDDocument.Location = new System.Drawing.Point(133, 28);
            this.lb_OrderIDDocument.Name = "lb_OrderIDDocument";
            this.lb_OrderIDDocument.Size = new System.Drawing.Size(74, 13);
            this.lb_OrderIDDocument.TabIndex = 4;
            this.lb_OrderIDDocument.Text = "ID dokumentu";
            // 
            // lb_OrdersIDCar
            // 
            this.lb_OrdersIDCar.AutoSize = true;
            this.lb_OrdersIDCar.Location = new System.Drawing.Point(6, 87);
            this.lb_OrdersIDCar.Name = "lb_OrdersIDCar";
            this.lb_OrdersIDCar.Size = new System.Drawing.Size(78, 13);
            this.lb_OrdersIDCar.TabIndex = 3;
            this.lb_OrdersIDCar.Text = "ID Samochodu";
            // 
            // lb_OrdersIDCustomer
            // 
            this.lb_OrdersIDCustomer.AutoSize = true;
            this.lb_OrdersIDCustomer.Location = new System.Drawing.Point(31, 63);
            this.lb_OrdersIDCustomer.Name = "lb_OrdersIDCustomer";
            this.lb_OrdersIDCustomer.Size = new System.Drawing.Size(53, 13);
            this.lb_OrdersIDCustomer.TabIndex = 2;
            this.lb_OrdersIDCustomer.Text = "ID Klienta";
            // 
            // lb_OrderEmployee
            // 
            this.lb_OrderEmployee.AutoSize = true;
            this.lb_OrderEmployee.Location = new System.Drawing.Point(7, 227);
            this.lb_OrderEmployee.Name = "lb_OrderEmployee";
            this.lb_OrderEmployee.Size = new System.Drawing.Size(65, 13);
            this.lb_OrderEmployee.TabIndex = 1;
            this.lb_OrderEmployee.Text = "Pracownicy:";
            // 
            // lb_id_order
            // 
            this.lb_id_order.AutoSize = true;
            this.lb_id_order.Location = new System.Drawing.Point(6, 28);
            this.lb_id_order.Name = "lb_id_order";
            this.lb_id_order.Size = new System.Drawing.Size(18, 13);
            this.lb_id_order.TabIndex = 0;
            this.lb_id_order.Text = "ID";
            // 
            // Form_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 434);
            this.Controls.Add(this.gb_Orders);
            this.Name = "Form_Orders";
            this.Text = "Zamówienia";
            this.Load += new System.EventHandler(this.Form_Orders_Load);
            this.gb_Orders.ResumeLayout(false);
            this.gb_Orders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Orders;
        private System.Windows.Forms.Label lb_id_order;
        private System.Windows.Forms.ComboBox cb_orderWorkspaceNr;
        private System.Windows.Forms.CheckBox cb_OrderDocumenttype;
        private System.Windows.Forms.CheckBox cb_OrderPaymenttype;
        private System.Windows.Forms.Label lb_OrderWorkplaceNr;
        private System.Windows.Forms.Label lb_OrderDiscount;
        private System.Windows.Forms.Label lb_OrderPrice;
        private System.Windows.Forms.Label lb_OrderEndTime;
        private System.Windows.Forms.Label lb_OrderStartTime;
        private System.Windows.Forms.Label lb_OrderIDDocument;
        private System.Windows.Forms.Label lb_OrdersIDCar;
        private System.Windows.Forms.Label lb_OrdersIDCustomer;
        private System.Windows.Forms.Label lb_OrderEmployee;
        private System.Windows.Forms.TextBox tb_OrderID;
        private System.Windows.Forms.TextBox tb_DocumentID;
        private System.Windows.Forms.TextBox tb_CustomerID;
        private System.Windows.Forms.Label lb_OrderFault;
        private System.Windows.Forms.Label lb_OrderServices;
        private System.Windows.Forms.TextBox tb_CarID;
        private System.Windows.Forms.TextBox tb_EndTime;
        private System.Windows.Forms.TextBox tb_StartTime;
        private System.Windows.Forms.Button btn_CarIDChoose;
        private System.Windows.Forms.Button btn_CustomerIDChoose;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Button btn_EndTimeSet;
        private System.Windows.Forms.Button btn_StartTimeSet;
        private System.Windows.Forms.Button btn_UpdateOrder;
        private System.Windows.Forms.Button btn_DeleteOrder;
        private System.Windows.Forms.Button btn_InsertOrder;
        private System.Windows.Forms.TextBox tb_Fault;
        private System.Windows.Forms.ComboBox cb_ServiceList;
        private System.Windows.Forms.ComboBox cb_EmployeeList;
        private System.Windows.Forms.Button btn_SetFault;
        private System.Windows.Forms.Button btn_SetService;
        private System.Windows.Forms.Button btn_SetEmployee;
    }
}