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
    public partial class Form_Raport : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Myjnia; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        MyjniaEntities1 myjnia = new MyjniaEntities1();
        public Form_Raport()
        {
            InitializeComponent();
        }

        private void Form_Raport_Load(object sender, EventArgs e)
        {

        }

        private void btn_createRaport_Click(object sender, EventArgs e)
        {
            string idorder, idcustomer, idcar, orderdate, starttime, endtime, price, workplacenr, paymenttype, documenttype;
            paymenttype = "";
            documenttype = "";
            try
            {
                string text = "";

                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT [ID_order],[ID_customer],[ID_car], [Order_date]," +
                    "  [Start_time], [End_time], [Price], [Workplace_nr], [Payment_type], [Document_type] FROM [Order]", connection))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            idorder = dt.Rows[i]["ID_order"].ToString();
                            idcustomer = dt.Rows[i]["ID_customer"].ToString();
                            idcar = dt.Rows[i]["ID_car"].ToString();
                            orderdate = dt.Rows[i]["Order_date"].ToString();
                            starttime = dt.Rows[i]["Start_time"].ToString();
                            endtime = dt.Rows[i]["End_time"].ToString();
                            price = dt.Rows[i]["Price"].ToString();
                            workplacenr = dt.Rows[i]["Workplace_nr"].ToString();
                            paymenttype = dt.Rows[i]["Payment_type"].ToString();
                            documenttype = dt.Rows[i]["Document_type"].ToString();

                            if (paymenttype == "True") paymenttype = "Karta";
                            else if (paymenttype == "False") paymenttype = "Gotowka";

                            if (documenttype == "True") documenttype = "Faktura";
                            else if (documenttype == "False") documenttype = "Paragon";


                            text += "ID: " + idorder + " | Nr stanowiska: \t" + workplacenr + "\n" + "Cena: \t" + price + " | " + "Typ platnosci:\t" +
                            paymenttype + " | Typ dokumentu: \t" + documenttype + "\n" +
                            "Godz. rozpoczecia: \t" + starttime + " | Godz. zakonczenia: \t" + endtime + "Data: \t" + orderdate + "\n\n";
                        }
                    }
                }
                connection.Close();



                using (var command = new SqlCommand("WriteToFile", connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    connection.Open();
                    command.Parameters.Add("@File", SqlDbType.VarChar).Value = @"C:\Users\Konrad\source\repos\Reczna_Myjnia_Samochodowa\test.txt";
                    command.Parameters.Add("@Text", SqlDbType.VarChar).Value = text;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
                connection.Close();
            }
        }
    }
}
