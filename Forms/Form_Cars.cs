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
    public partial class Form_Cars : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Myjnia; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        MyjniaEntities1 myjnia = new MyjniaEntities1();
        Form_Orders frmOrders;
        public Form_Cars()
        {
            InitializeComponent();
        }

        private void Form_Cars_Load(object sender, EventArgs e)
        {
            display_samochod();
        }

        private void display_samochod()
        {
            connection.Open();
            IQueryable<Car> show = myjnia.Car.Select(n => n);
            CarGridView.DataSource = show.ToList();
            connection.Close();
        }

        private void btn_CreateCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_CarLicense.Text == "") throw new Exception("Podaj numer rejestracyjny!");
                else if (tb_CarLicense.Text.Length < 7) { throw new Exception("Nieprawidłowy numer rejestracyjny!"); }

                connection.Open();
                Car samochod = new Car()
                {
                    Mark = tb_CarMark.Text,
                    Model = tb_CarModel.Text,
                    License_number = tb_CarLicense.Text,
                    Note = tb_CarNote.Text,
                };
                myjnia.Car.Add(samochod);
                myjnia.SaveChanges();
                connection.Close();
                display_samochod();
            }
            catch (Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
                connection.Close();
            }
        }

        private void btn_DeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_CarID.Text == "" || tb_CarID.Text == " ") throw new Exception("Podaj ID samochodu lub zaznacz rekord z tabeli!");
                connection.Open();
                int id = Convert.ToInt32(tb_CarID.Text);
                List<Car> usun = myjnia.Car.Where
                                      (p => (p.ID_car == id)).ToList();
                foreach (var p in usun)
                {
                    myjnia.Car.Remove(p);
                }
                myjnia.SaveChanges();
                connection.Close();
                display_samochod();
            }

            catch (Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }


        private void btn_UpdateCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_CarLicense.Text == "" || tb_CarLicense.Text.Length < 7) throw new Exception("Podaj prawidłowy numer rejestracyjny!");
                if (tb_CarID.Text == "" || tb_CarID.Text == " ") throw new Exception("Podaj ID samochodu lub zaznacz rekord z tabeli!");
                connection.Open();
                int id = Convert.ToInt32(tb_CarID.Text);
                var query = myjnia.Car.Where(p => (p.ID_car == id)).FirstOrDefault();
                query.Mark = tb_CarMark.Text;
                query.Model = tb_CarModel.Text;
                query.License_number = tb_CarLicense.Text;
                query.Note = tb_CarNote.Text;
                myjnia.SaveChanges();
                connection.Close();
                display_samochod();
            }
            catch (Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
            }
            connection.Close();
        }

        private void CarGridView_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                object value = CarGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                tb_CarID.Text = CarGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_CarMark.Text = CarGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_CarModel.Text = CarGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_CarLicense.Text = CarGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_CarNote.Text = CarGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception ex) { }
        }

        public void sendOrdersObjectToCar(Form_Orders form)
        {
            frmOrders = form;
        }

        private void btn_OkCar_Click(object sender, EventArgs e)
        {
            if (frmOrders != null)
            {
                frmOrders.tb_CustomerID.Text = CarGridView.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
            else
                this.Close();
        }
    }
}
