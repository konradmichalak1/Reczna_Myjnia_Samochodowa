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

        private void cb_EmployeeList_DropDown(object sender, EventArgs e)
        {
            checklist_employers.Location = new Point(cb_EmployeeList.Location.X + 30, cb_EmployeeList.Location.Y + 40);
            
            checklist_employers.Visible = true;
        }
    }
}
