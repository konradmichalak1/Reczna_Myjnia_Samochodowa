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
    public partial class Form_Customer : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Myjnia; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        MyjniaEntities1 myjnia = new MyjniaEntities1();
        public static Form_Orders frmOrders;
        public Form_Customer()
        {
            InitializeComponent();
        }

        private void Form_Customer_Load(object sender, EventArgs e)
        {
            display_customer();
        }
        private void btn_ShowCarsList_Click(object sender, EventArgs e)
        {
            Form_Cars fc = new Form_Cars();
            fc.Show();
        }

        private void btn_InsertCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                using (var command = new SqlCommand("InsertCustomer", connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    connection.Open();
                    command.Parameters.Add("@Name", SqlDbType.VarChar).Value = tb_CustomerName.Text;
                    command.Parameters.Add("@Surname", SqlDbType.VarChar).Value = tb_CustomerSurname.Text;
                    command.Parameters.Add("@Telephone", SqlDbType.VarChar).Value = tb_CustomerTelephone.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                    display_customer();
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
                connection.Close();
            }
        }

        private void btn_DeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                using (var command = new SqlCommand("DeleteCustomer", connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    connection.Open();
                    command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(tb_CustomerID.Text);
                    command.ExecuteNonQuery();
                }
                connection.Close();
                display_customer();
            }

            catch (Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
                connection.Close();
            }
        }

        private void btn_UpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                int id = Convert.ToInt32(tb_CustomerID.Text);
                var query = myjnia.Customer.Where(p => (p.ID_customer == id)).FirstOrDefault();
                query.Name = tb_CustomerName.Text;
                query.Surname = tb_CustomerSurname.Text;
                query.Telephone = tb_CustomerTelephone.Text;
                myjnia.SaveChanges();
                connection.Close();
                display_customer();
            }
            catch (Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
            }
            connection.Close();
        }
        private void display_customer()
        {
            connection.Open();
            IQueryable<Customer> show = myjnia.Customer.Select(n => n);
            CustomerGridView.DataSource = show.ToList();
            connection.Close();
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            connection.Open();
            using (var command = new SqlCommand("SELECT * FROM [dbo].[CustomersBySurname]", connection))
            {

                CustomerGridView.DataSource = command.ExecuteReader();
            }

            connection.Close();
        }

        private void CustomerGridView_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                object value = CustomerGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                tb_CustomerID.Text = CustomerGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_CustomerName.Text = CustomerGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_CustomerSurname.Text = CustomerGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_CustomerTelephone.Text = CustomerGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex) { }
        }


        public void send_OrdersObject(Form_Orders frm)
        {
            frmOrders = frm;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (frmOrders != null)
            {
                frmOrders.tb_CustomerID.Text = CustomerGridView.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
            else
                this.Close();
        }
    }
}
