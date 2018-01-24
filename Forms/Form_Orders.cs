using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Reczna_Myjnia_Samochodowa
{
    public partial class Form_Orders : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Myjnia; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        MyjniaEntities1 myjnia = new MyjniaEntities1();
        public Form_Orders()
        {
            InitializeComponent();
        }

        private void Form_Orders_Load(object sender, EventArgs e)
        {
            cb_orderWorkspaceNr.SelectedIndex = 0;
        }
        
        private void btn_CustomerIDChoose_Click(object sender, EventArgs e)
        {
            Form_Customer frm = new Form_Customer();
            frm.send_OrdersObject(this);
            frm.Show();
        }

        private void btn_CarIDChoose_Click(object sender, EventArgs e)
        {
            Form_Cars frm = new Form_Cars();
            frm.sendOrdersObjectToCar(this);
            frm.Show();
        }
        
        private void btn_SetEmployee_Click(object sender, EventArgs e)
        {
            connection.Open();
            checklist_employers.Items.Clear();
            using (SqlCommand cmd = new SqlCommand("SELECT [ID_employee],[Name],[Surname] FROM [Employee]", connection))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string name, surname, id;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        id = dt.Rows[i]["ID_employee"].ToString();
                        name = dt.Rows[i]["Name"].ToString();
                        surname = dt.Rows[i]["Surname"].ToString();
                        checklist_employers.Items.Add(id + " " + name + " " + surname);
                    }
                }
            }
            connection.Close();
            checklist_employers.Dock = DockStyle.Bottom;
            btn_okEmployers.Visible = true;
            btn_okService.Visible = false;
            checklist_employers.Visible = true;
            checklist_services.Visible = false;
        }

        private void btn_okEmployers_Click(object sender, EventArgs e)
        {
            btn_okEmployers.Visible = false;
            checklist_employers.Visible = false;
            tb_employerlist.Items.Clear();
            foreach(string s in checklist_employers.CheckedItems)
            {
                tb_employerlist.Items.Add(s); 
            }

            checklist_employers.Items.Clear();
            tb_employerlist.SelectedIndex = 0;
        }

        private void btn_SetService_Click(object sender, EventArgs e)
        {
            connection.Open();
            checklist_services.Items.Clear();
            using (SqlCommand cmd = new SqlCommand("SELECT [ID_service],[Name],[Price] FROM [Service]", connection))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string name, price, id;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        id = dt.Rows[i]["ID_service"].ToString();
                        name = dt.Rows[i]["Name"].ToString();
                        price = dt.Rows[i]["Price"].ToString();
                        checklist_services.Items.Add(id + " "  + name + " Cena: " + price+"zł");
                    }
                }
            }
            connection.Close();
            checklist_services.Dock = DockStyle.Bottom;
            btn_okService.Visible = true;
            btn_okEmployers.Visible = false;
            checklist_services.Visible = true;
            checklist_employers.Visible = false;
        }

        private void btn_okService_Click(object sender, EventArgs e)
        {
            btn_okService.Visible = false;
            checklist_services.Visible = false;
            tb_servicelist.Items.Clear();

            przelicz_zamowienie();
            checklist_services.Items.Clear();
            tb_servicelist.SelectedIndex = 0;
        }

        private void przelicz_zamowienie()
        {
            decimal suma = 0;
            string liczba = "";
            int counter = 0; //licznik spacji

            foreach (string s in checklist_services.CheckedItems)
            {
                tb_servicelist.Items.Add(s);
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == 58) { counter++; i++; }

                    if (counter == 1 && i < s.Length - 2) { liczba += s[i]; }
                }
                counter = 0;
                suma += Convert.ToDecimal(liczba);
                liczba = "";

            }
            suma = suma - (suma * (Convert.ToDecimal(tb_Discount.Text) / 100));
            tb_Price.Text = suma.ToString();
        }

        private void tb_Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            
            if (tb_Discount.Text.Length < 3)
            {
                if (!Char.IsDigit(ch) && ch != 8)
                {
                    e.Handled = true;
                }
            }
            else if (ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_przelicz_Click(object sender, EventArgs e)
        {
            if (tb_Price.Text != "0" && tb_Price.Text != "0,00" && tb_Price.Text != "0,0")
            {
                decimal suma;
                suma = Convert.ToDecimal(tb_Price.Text);
                suma = suma - (suma * (Convert.ToDecimal(tb_Discount.Text) / 100));
                tb_Price.Text = suma.ToString();
            }
        }

        private void btn_StartTimeSet_Click(object sender, EventArgs e)
        {
            if (lb_time_in_memory.Text == "czas-w-pamieci")
            {
                lb_time_in_memory.Text = tb_StartTime.Text;
                tb_StartTime.Text = string.Format("{0:HH:mm:ss}", DateTime.Now);
            }
            else
            {
                lb_time_in_memory.Text = tb_StartTime.Text;
                tb_StartTime.Text = string.Format("{0:HH:mm:ss}", DateTime.Now);
                btn_undoStart.Visible = true;
                btn_undoEnd.Visible = false;
            }
            
        }

        private void btn_EndTimeSet_Click(object sender, EventArgs e)
        {
            string x = cb_OrderPaymenttype.CheckState.ToString();

            if (lb_time_in_memory.Text == "czas-w-pamieci")
            {
                lb_time_in_memory.Text = tb_EndTime.Text;
                tb_EndTime.Text = string.Format("{0:HH:mm:ss}", DateTime.Now);
            }
            else
            {
                lb_time_in_memory.Text = tb_EndTime.Text;
                tb_EndTime.Text = string.Format("{0:HH:mm:ss}", DateTime.Now);
                btn_undoStart.Visible = false;
                btn_undoEnd.Visible = true;
            }
        }

        private void btn_undoStart_Click(object sender, EventArgs e)
        {
            tb_StartTime.Text = lb_time_in_memory.Text;
            btn_undoStart.Visible = false;
        }

        private void btn_undoEnd_Click(object sender, EventArgs e)
        {
            tb_EndTime.Text = lb_time_in_memory.Text;
            btn_undoEnd.Visible = false;
        }


        private void btn_InsertOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_CustomerID.Text == "") throw new Exception("Podaj ID Klienta!");
                if (tb_CarID.Text == "") throw new Exception("Podaj ID Samochodu!");
                if (tb_StartTime.Text == "") throw new Exception("Ustaw czas złożenia zamówienia!");

                connection.Open();
                TimeSpan startTime = TimeSpan.Parse(tb_StartTime.Text);
                TimeSpan endTime = TimeSpan.Parse("00:00:00");
                if(tb_EndTime.Text != "") endTime = TimeSpan.Parse(tb_EndTime.Text); 
                string index = "";
                foreach (var x in tb_employerlist.Items)
                {
                    string pom = x.ToString();
                    index = "";
                    for (int i = 0; i < pom.Length; i++)
                    {
                        if (pom[i] == 32) break;
                        else
                        {
                            index += pom[i];
                        }
                    }
                    
                }
                bool payment;
                string p = cb_OrderPaymenttype.CheckState.ToString();
                if (p == "Checked")
                    payment = true;
                else
                    payment = false;

                bool document;
                string d = cb_OrderDocumenttype.CheckState.ToString();
                if (d == "Checked")
                    document = true;
                else
                    document = false;
          
                Order order = new Order()
                {
                    ID_employee = Convert.ToInt32(index),
                    ID_customer = Convert.ToInt32(tb_CustomerID.Text),
                    ID_car = Convert.ToInt32(tb_CarID.Text),
                    Order_date = DateTime.Now,
                    Start_time = startTime,
                    End_time = endTime,
                    Price = Convert.ToDecimal(tb_Price.Text),
                    Workplace_nr = Convert.ToInt32(cb_orderWorkspaceNr.Text),
                    Payment_type = payment,
                    Document_type = document
                };
                myjnia.Order.Add(order);
                myjnia.SaveChanges();
                connection.Close();
                index = "";
                foreach (var x in tb_employerlist.Items){
                    string pom = x.ToString();
                    for (int i = 0; i < pom.Length; i++){
                        if (pom[i] == 32) {
                            try {
                                using (var command = new SqlCommand("InsertRealization", connection) {
                                    CommandType = CommandType.StoredProcedure})
                                {
                                    connection.Open();
                                    command.Parameters.Add("@ID_order", SqlDbType.VarChar).Value = order.ID_order;
                                    command.Parameters.Add("@ID_employee", SqlDbType.VarChar).Value = Convert.ToInt32(index);
                                    index = "";
                                    command.ExecuteNonQuery();
                                    connection.Close();
                                }
                            }
                            catch (Exception ex){
                                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                                else MessageBox.Show(ex.InnerException.InnerException.Message);
                                connection.Close();
                            }
                            break;
                        }
                        else index += pom[i]; }}

                foreach (var x in tb_servicelist.Items){
                    string pom = x.ToString();
                    for (int i = 0; i < pom.Length; i++){
                        if (pom[i] == 32) {
                            try {
                                using (var command = new SqlCommand("InsertOrderDetail", connection){
                                    CommandType = CommandType.StoredProcedure
                                })
                                {
                                    connection.Open();
                                    command.Parameters.Add("@ID_order", SqlDbType.VarChar).Value = order.ID_order;
                                    command.Parameters.Add("@ID_service", SqlDbType.VarChar).Value = Convert.ToInt32(index);
                                    command.Parameters.Add("@Discount", SqlDbType.VarChar).Value = Convert.ToInt32(tb_Discount.Text);
                                    index = "";
                                    command.ExecuteNonQuery();
                                    connection.Close();
                                }
                            }
                            catch (Exception ex) {
                                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                                else MessageBox.Show(ex.InnerException.InnerException.Message);
                                connection.Close();
                            }
                            break;
                        }
                        else index += pom[i]; }}

                try {
                    using (var command = new SqlCommand("InsertHave", connection){
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        connection.Open();
                        command.Parameters.Add("@ID_customer", SqlDbType.VarChar).Value = Convert.ToInt32(tb_CustomerID.Text);
                        command.Parameters.Add("@ID_car", SqlDbType.VarChar).Value = Convert.ToInt32(tb_CarID.Text);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                catch (Exception ex){
                    if (ex.InnerException == null) MessageBox.Show(ex.Message);
                    else MessageBox.Show(ex.InnerException.InnerException.Message);
                    connection.Close();
                }
            }
            catch(Exception ex){
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
                connection.Close();
            }
        }

        private void btn_DeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string index = "";



                foreach (var x in tb_employerlist.Items)
                {
                    string pom = x.ToString();
                    for (int i = 0; i < pom.Length; i++)
                    {
                        if (pom[i] == 32)
                        {
                            try
                            {
                                using (var command = new SqlCommand("DeleteRealization", connection)
                                {
                                    CommandType = CommandType.StoredProcedure
                                })
                                {
                                    connection.Open();
                                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = Convert.ToInt32(tb_OrderID.Text);
                                    index = "";
                                    command.ExecuteNonQuery();
                                    connection.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                                else MessageBox.Show(ex.InnerException.InnerException.Message);
                                connection.Close();
                            }
                            break;
                        }
                        else index += pom[i];
                    }
                }
                index = "";
                foreach (var x in tb_servicelist.Items)
                {
                    string pom = x.ToString();
                    for (int i = 0; i < pom.Length; i++)
                    {
                        if (pom[i] == 32)
                        {
                            try
                            {
                                using (var command = new SqlCommand("DeleteOrderDetail", connection)
                                {
                                    CommandType = CommandType.StoredProcedure
                                })
                                {
                                    connection.Open();
                                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = Convert.ToInt32(tb_OrderID.Text);
                                    index = "";
                                    command.ExecuteNonQuery();
                                    connection.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                                else MessageBox.Show(ex.InnerException.InnerException.Message);
                                connection.Close();
                            }
                            break;
                        }
                        else index += pom[i];
                    }
                }

                connection.Open();
                int id = Convert.ToInt32(tb_OrderID.Text);
                List<Order> usun = myjnia.Order.Where
                                      (p => (p.ID_order == id)).ToList();
                foreach (var p in usun)
                {
                    myjnia.Order.Remove(p);
                    //collec.DeleteOneAsync(Builders<BsonDocument>.Filter.Eq("PESEL", p.PESEL.ToString()));
                }
                myjnia.SaveChanges();
                connection.Close();



            }
            catch (Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
                connection.Close();
            }


        }

        private void btn_UpdateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                bool payment;
                string p = cb_OrderPaymenttype.CheckState.ToString();
                if (p == "Checked")
                    payment = true;
                else
                    payment = false;

                bool document;
                string d = cb_OrderDocumenttype.CheckState.ToString();
                if (d == "Checked")
                    document = true;
                else
                    document = false;
                int id = Convert.ToInt32(tb_OrderID.Text);
                var query = myjnia.Order.Where(x => (x.ID_order == id)).FirstOrDefault();
                query.ID_car = Convert.ToInt32(tb_CarID.Text);
                query.ID_customer = Convert.ToInt32(tb_CustomerID.Text);
                query.Price = Convert.ToDecimal(tb_Price.Text);
                query.Workplace_nr = Convert.ToInt32(cb_orderWorkspaceNr.Text);
                query.Payment_type = payment;
                query.Document_type = document;
                myjnia.SaveChanges();
                connection.Close();
            }
            catch(Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
                connection.Close();
            }
        }
    }

}
