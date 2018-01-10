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
    public partial class Form_Orders : Form
    {
        public Form_Orders()
        {
            InitializeComponent();
        }

        private void Form_Orders_Load(object sender, EventArgs e)
        {

        }

        private void btn_CustomerIDChoose_Click(object sender, EventArgs e)
        {
            Form_Customer frm = new Form_Customer();
            frm.send_OrdersObject(this);
            frm.Show();
        }
    }
}
