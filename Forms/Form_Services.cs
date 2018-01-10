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
    public partial class Form_Services : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Myjnia; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        MyjniaEntities1 myjnia = new MyjniaEntities1();
        public Form_Services()
        {
            InitializeComponent();
        }

        private void Form_Services_Load(object sender, EventArgs e)
        {
            display_services();
        }

        private void display_services()
        {
            connection.Open();
            IQueryable<Service> show = myjnia.Service.Select(n => n);
            ServiceGridView.DataSource = show.ToList();
            connection.Close();
        }

        private void tb_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 44 && tb_price.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void btn_InsertService_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_name.Text.Length < 1) throw new Exception("Wprowadź nazwę usługi.");

                connection.Open();
                if(tb_price.Text == "" || tb_price.Text == " ") { tb_price.Text = "0,00"; }
                if (tb_realizationtime.Text == "" || tb_realizationtime.Text == " ") { tb_realizationtime.Text = "0"; }
                Service usluga = new Service()
                {
                    Name = tb_name.Text,
                    Price = Convert.ToDecimal(tb_price.Text),
                    Realization_time = Convert.ToInt32(tb_realizationtime.Text)
                    
                };

                myjnia.Service.Add(usluga);
                myjnia.SaveChanges();
                connection.Close();
                display_services();
            }
            catch (Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
                connection.Close();
            }
        }

        private void btn_DeleteService_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_ServiceID.Text == "" || tb_ServiceID.Text == " ") throw new Exception("Podaj ID usługi lub zaznacz rekord z tabeli!");
                connection.Open();
                int id = Convert.ToInt32(tb_ServiceID.Text);
                List<Service> usun = myjnia.Service.Where
                                      (p => (p.ID_service == id)).ToList();
                foreach (var p in usun)
                {
                    myjnia.Service.Remove(p);
                }
                myjnia.SaveChanges();
                connection.Close();
                display_services();
            }

            catch (Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void ServiceGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                object value = ServiceGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                tb_ServiceID.Text = ServiceGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_name.Text = ServiceGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_price.Text = ServiceGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_realizationtime.Text = ServiceGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void btn_UpdateService_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_price.Text == "" || tb_price.Text == " ") { tb_price.Text = "0,00"; }
                if (tb_realizationtime.Text == "" || tb_realizationtime.Text == " ") { tb_realizationtime.Text = "0"; }
                if (tb_ServiceID.Text == "" || tb_ServiceID.Text == " ") throw new Exception("Podaj ID usługi lub zaznacz rekord z tabeli!");
                if (tb_name.Text.Length < 1) throw new Exception("Wprowadź nazwę usługi.");
                connection.Open();
                int id = Convert.ToInt32(tb_ServiceID.Text);
                var query = myjnia.Service.Where(p => (p.ID_service == id)).FirstOrDefault();
                query.Name = tb_name.Text;
                query.Price = Convert.ToDecimal(tb_price.Text);
                query.Realization_time = Convert.ToInt32(tb_realizationtime.Text);

                myjnia.SaveChanges();
                connection.Close();
                display_services();
            }
            catch (Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
            }
            connection.Close();
        }
    }
}
