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
    public partial class Form_Faults : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Myjnia; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        MyjniaEntities1 myjnia = new MyjniaEntities1();
        public Form_Faults()
        {
            InitializeComponent();
        }

        private void Form_Faults_Load(object sender, EventArgs e)
        {
            display_fault();

        }

        private void display_fault()
        {
            connection.Open();
            IQueryable<Fault> show = myjnia.Fault.Select(n => n);
            faultGridView.DataSource = show.ToList();
            connection.Close();
        }

        private void btn_InsertFault_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_CarNote.Text.Length < 1) throw new Exception("Wprowadź informacje o usterce");

                connection.Open();
                Fault usterka = new Fault()
                {
                    Description = tb_CarNote.Text,
                };
                myjnia.Fault.Add(usterka);
                myjnia.SaveChanges();
                connection.Close();
                display_fault();
            }
            catch (Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
                connection.Close();
            }
        }

        private void faultGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                object value = faultGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                tb_FaultID.Text = faultGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_CarNote.Text = faultGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void btn_DeleteFault_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_FaultID.Text == "" || tb_FaultID.Text == " ") throw new Exception("Podaj ID usterki lub zaznacz rekord z tabeli!");
                connection.Open();
                int id = Convert.ToInt32(tb_FaultID.Text);
                List<Fault> usun = myjnia.Fault.Where
                                      (p => (p.ID_fault == id)).ToList();
                foreach (var p in usun)
                {
                    myjnia.Fault.Remove(p);
                }
                myjnia.SaveChanges();
                connection.Close();
                display_fault();
            }

            catch (Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void btn_UpdateFault_Click(object sender, EventArgs e)
        {
            try
            {
                if(tb_FaultID.Text == "") throw new Exception("Podaj ID usterki lub zaznacz rekord z tabeli!");
                if (tb_CarNote.Text.Length < 1) throw new Exception("Wprowadź informacje o usterce");
                connection.Open();
                int id = Convert.ToInt32(tb_FaultID.Text);
                var query = myjnia.Fault.Where(p => (p.ID_fault == id)).FirstOrDefault();
                query.Description = tb_CarNote.Text;
                myjnia.SaveChanges();
                connection.Close();
                display_fault();
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
