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
    public partial class Form_Main : Form
    {
        Form_LoginScreen ls = new Form_LoginScreen();
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            ls.Show();
            ls.send_MainObject(this);
        }

        private void btn_cars_Click(object sender, EventArgs e)
        {
            Form_Cars c = new Form_Cars();
            c.Show();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            Form_Customer cust = new Form_Customer();
            cust.Show();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            Form_Orders ord = new Form_Orders();
            ord.Show();
        }

        private void btn_Employers_Click(object sender, EventArgs e)
        {
            Form_Employers emp = new Form_Employers();
            emp.Show();
        }

        private void btn_services_Click(object sender, EventArgs e)
        {
            Form_Services serv = new Form_Services();
            serv.Show();
        }

        private void btn_faults_Click(object sender, EventArgs e)
        {
            Form_Faults fau = new Form_Faults();
            fau.Show();
        }

        private void btn_raport_Click(object sender, EventArgs e)
        {
            Form_Raport rap = new Form_Raport();
            rap.Show();

        }

        private void btn_loginScreen_Click(object sender, EventArgs e)
        {
            ls.Close();
            Form_LoginScreen ls2 = new Form_LoginScreen();
            ls2.Show();
            ls2.send_MainObject(this);
        }
    }
}
