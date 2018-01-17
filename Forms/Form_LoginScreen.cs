using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reczna_Myjnia_Samochodowa
{
    public partial class Form_LoginScreen : Form
    {
        public static Form_Main frmMain;
        public Form_LoginScreen()
        {
            InitializeComponent();
        }
        public void send_MainObject(Form_Main frm)
        {
            frmMain = frm;
            frmMain.btn_orders.Enabled = false;
            frmMain.btn_cars.Enabled = false;
            frmMain.btn_customers.Enabled = false;
            frmMain.btn_Employers.Enabled = false;
            frmMain.btn_faults.Enabled = false;
            frmMain.btn_raport.Enabled = false;
            frmMain.btn_services.Enabled = false;
        }
        private void Form_LoginScreen_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            frmMain.btn_orders.Enabled = true;
            frmMain.btn_cars.Enabled = true;
            frmMain.btn_customers.Enabled = true;
            frmMain.btn_Employers.Enabled = true;
            frmMain.btn_faults.Enabled = true;
            frmMain.btn_raport.Enabled = true;
            frmMain.btn_services.Enabled = true;
            this.Visible = false;
        }
    }
}
