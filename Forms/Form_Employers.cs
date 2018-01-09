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
    public partial class Form_Employers : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Myjnia; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        MyjniaEntities1 myjnia = new MyjniaEntities1();
        public Form_Employers()
        {
            InitializeComponent();
        }

        private void Form_Employers_Load(object sender, EventArgs e)
        {
            display_employers();
        }

        private void display_employers()
        {
            connection.Open();
            IQueryable<Employee> show = myjnia.Employee.Select(n => n);
            EmployersGridView.DataSource = show.ToList();
            connection.Close();
        }

        private void btn_InsertEmployee_Click(object sender, EventArgs e)
        {
                try
                {
                    if (tb_name.Text.Length < 1) throw new Exception("Wprowadź imię pracownika.");
                    if (tb_surname.Text.Length < 1) throw new Exception("Wprowadź nazwisko pracownika.");
                    if (tb_pesel.Text.Length < 1) throw new Exception("Wprowadź PESEL pracownika.");
                    if (tb_pesel.Text.Length != 11) throw new Exception("Wprowadź prawidłowy PESEL!");

                    connection.Open();
                    Employee pracownik = new Employee()
                    {
                        Name = tb_name.Text,
                        Surname = tb_surname.Text,
                        PESEL = tb_pesel.Text,
                        Job_title = cb_jobtitle.Text,
                        Salary = Convert.ToDecimal(tb_salary.Text)
                    };

                    myjnia.Employee.Add(pracownik);
                    myjnia.SaveChanges();
                    connection.Close();
                    display_employers();
                }
                catch (Exception ex)
                {
                    if (ex.InnerException == null) MessageBox.Show(ex.Message);
                    else MessageBox.Show(ex.InnerException.InnerException.Message);
                    connection.Close();
                }
        }



        private void btn_DeleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_EmployeeID.Text == "" || tb_EmployeeID.Text == " ") throw new Exception("Podaj ID pracownika lub zaznacz rekord z tabeli!");
                connection.Open();
                int id = Convert.ToInt32(tb_EmployeeID.Text);
                List<Employee> usun = myjnia.Employee.Where
                                      (p => (p.ID_employee == id)).ToList();
                foreach (var p in usun)
                {
                    myjnia.Employee.Remove(p);
                }
                myjnia.SaveChanges();
                connection.Close();
                display_employers();
            }

            catch (Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void EmployersGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                object value = EmployersGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                tb_EmployeeID.Text = EmployersGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_name.Text = EmployersGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_surname.Text = EmployersGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_pesel.Text = EmployersGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                cb_jobtitle.Text = EmployersGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                tb_salary.Text = EmployersGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void btn_UpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_name.Text.Length < 1) throw new Exception("Wprowadź imię pracownika.");
                if (tb_surname.Text.Length < 1) throw new Exception("Wprowadź nazwisko pracownika.");
                if (tb_pesel.Text.Length < 1) throw new Exception("Wprowadź PESEL pracownika.");
                if (tb_pesel.Text.Length != 11) throw new Exception("Wprowadź prawidłowy PESEL!");
                connection.Open();
                int id = Convert.ToInt32(tb_EmployeeID.Text);
                var query = myjnia.Employee.Where(p => (p.ID_employee == id)).FirstOrDefault();
                query.Name = tb_name.Text;
                query.Surname = tb_surname.Text;
                query.PESEL = tb_pesel.Text;
                query.Job_title = cb_jobtitle.Text;
                query.Salary = Convert.ToDecimal(tb_salary.Text);

                myjnia.SaveChanges();
                connection.Close();
                display_employers();
            }
            catch (Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
            }
            connection.Close();
        }

        private void tb_pesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (tb_pesel.Text.Length<11) {
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

        private void tb_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 44 && tb_salary.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }
    }
}
