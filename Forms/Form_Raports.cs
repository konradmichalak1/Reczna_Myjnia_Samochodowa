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
using System.IO;
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
            try
            {
                string idorder, idcustomer, idcar, orderdate, starttime, endtime, price, workplacenr, paymenttype, documenttype;
                paymenttype = "";
                documenttype = "";
                var from = dtp_dateFrom.Value;
                var to = dtp_dateTo.Value;
                string text = "";
                connection.Open();

                IQueryable<Order> list = myjnia.Order.Where(x => (x.Order_date >= from) && (x.Order_date <= to));

                foreach (var x in list)
                {
                    idorder = x.ID_order.ToString();
                    idcustomer = x.ID_customer.ToString();
                    idcar = x.ID_car.ToString();
                    orderdate = x.Order_date.ToString();
                    starttime = x.Start_time.ToString();
                    endtime = x.End_time.ToString();
                    price = x.Price.ToString();
                    workplacenr = x.Workplace_nr.ToString();
                    paymenttype = x.Payment_type.ToString();
                    documenttype = x.Document_type.ToString();

                    if (paymenttype == "True") paymenttype = "Karta";
                    else if (paymenttype == "False") paymenttype = "Gotowka";

                    if (documenttype == "True") documenttype = "Faktura";
                    else if (documenttype == "False") documenttype = "Paragon";

                    text += "ID: " + idorder + " | Nr stanowiska: \t" + workplacenr + Environment.NewLine + "Cena: \t" + price + " | " + "Typ platnosci: \t" +
                                    paymenttype + " | Typ dokumentu: \t" + documenttype + Environment.NewLine +
                                    "Godz. rozpoczecia: \t" + starttime + " | Godz. zakonczenia: \t" + endtime + " | Data: \t" + orderdate + Environment.NewLine + Environment.NewLine;


                    connection.Close();

                    using (var command = new SqlCommand("WriteToFile", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        connection.Open();
                        var pomFrom = from.ToShortDateString();
                        var pomTo = to.ToShortDateString();
                        string path = @"C:\Users\Hubert\source\repos\Reczna_Myjnia_Samochodowa\bin\Debug\";
                        string raport = "Raport_" + pomFrom + "-" + pomTo + ".txt";

                        string combination = Path.Combine(path, raport);
                        command.Parameters.Add("@File", SqlDbType.VarChar).Value = combination;
                        command.Parameters.Add("@Text", SqlDbType.VarChar).Value = text;
                        command.ExecuteNonQuery();
                        connection.Close();
                        text = String.Empty;

                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException == null) MessageBox.Show(ex.Message);
                else MessageBox.Show(ex.InnerException.InnerException.Message);
                connection.Close();
            }
            
        }
        private static void CombinePaths(string p1, string p2)
        {

            try
            {
                string combination = Path.Combine(p1, p2);

                Console.WriteLine("When you combine '{0}' and '{1}', the result is: {2}'{3}'",
                            p1, p2, Environment.NewLine, combination);
            }
            catch (Exception e)
            {
                if (p1 == null)
                    p1 = "null";
                if (p2 == null)
                    p2 = "null";
                Console.WriteLine("You cannot combine '{0}' and '{1}' because: {2}{3}",
                            p1, p2, Environment.NewLine, e.Message);
            }

            Console.WriteLine();
        }


        private void btn_daily_Click(object sender, EventArgs e)
        {
            dtp_timeFrom.Value = DateTime.Now.Date;
            dtp_dateFrom.Value = DateTime.Now.Date;
            dtp_timeTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            dtp_dateTo.Value = DateTime.Now;
        }

        private void btn_weekly_Click(object sender, EventArgs e)
        {
            dtp_timeFrom.Value = DateTime.Now.Date;
            dtp_dateFrom.Value = DateTime
                          .Today
                          .AddDays(-(DateTime.Today.DayOfWeek - DayOfWeek.Monday))
                          .AddHours(10);
            dtp_timeTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            dtp_dateTo.Value = DateTime
              .Today
              .AddDays(-(DateTime.Today.DayOfWeek - DayOfWeek.Monday)+6)
              .AddHours(10);
        }

        private void btn_monthly_Click(object sender, EventArgs e)
        {
            var firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            dtp_timeFrom.Value = DateTime.Now.Date;
            dtp_dateFrom.Value = firstDayOfMonth;
            dtp_dateTo.Value = lastDayOfMonth;
            dtp_timeTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
        }


    }
}
