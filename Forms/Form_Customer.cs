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
                connection.Open();
                DateTime localDate = DateTime.Now;
                Customer customer = new Customer()
                {
                    Name = tb_CustomerName.Text,
                    Surname = tb_CustomerSurname.Text,
                    Telephone = tb_CustomerTelephone.Text

                };
                myjnia.Customer.Add(customer);
                myjnia.SaveChanges();
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

        private void btn_DeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_CustomerID.Text == "" || tb_CustomerID.Text == " ") throw new Exception("Podaj ID klienta lub zaznacz rekord z tabeli!");
                connection.Open();
                int id = Convert.ToInt32(tb_CustomerID.Text);
                List<Customer> usun = myjnia.Customer.Where
                                      (p => (p.ID_customer == id)).ToList();
                foreach (var p in usun)
                {
                    myjnia.Customer.Remove(p);
                }
                myjnia.SaveChanges();
                connection.Close();
                display_customer();
            }

            catch (Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
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

        private void CustomerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                object value = CustomerGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                tb_CustomerID.Text = CustomerGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_CustomerName.Text = CustomerGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_CustomerSurname.Text = CustomerGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_CustomerTelephone.Text = CustomerGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception ex) { }
        }
    }
}
