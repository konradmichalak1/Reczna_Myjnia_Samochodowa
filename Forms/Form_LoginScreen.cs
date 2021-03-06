﻿using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson;
using MongoDB.Driver;
namespace Reczna_Myjnia_Samochodowa
{
    public partial class Form_LoginScreen : Form
    {
        public static Form_Main frmMain;

        private static string login = String.Empty;
        private static string password = String.Empty;
        public static int flag = 0;
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
            this.CenterToScreen();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login = tb_login.Text;
            password = tb_password.Text;
            Login();
            timer1.Start();
        }


        static async Task Login()
        {
            try
            {
                MongoClient client = new MongoClient("mongodb://localhost:27017");
                var db = client.GetDatabase("Myjnia");
                var collection = db.GetCollection<BsonDocument>("Employees");
                var builder = Builders<BsonDocument>.Filter;
                var filter = new BsonDocument("Name", login);
                using (var cursor = await collection.FindAsync(filter))
                {                  
                    while (await cursor.MoveNextAsync())
                    {
                        var batch = cursor.Current;
                        foreach (var document in batch)
                        {
                            if (login == document[1].ToString() && password == document[2].ToString())
                                flag = 1;
                            else
                                flag = 0;                
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                lb_info.Visible = false;
                frmMain.btn_orders.Enabled = true;
                frmMain.btn_cars.Enabled = true;
                frmMain.btn_customers.Enabled = true;
                frmMain.btn_Employers.Enabled = true;
                frmMain.btn_faults.Enabled = true;
                frmMain.btn_raport.Enabled = true;
                frmMain.btn_services.Enabled = true;
                this.Visible = false;
                timer1.Stop();
            }
            else if (flag == 0)
            {
                lb_info.Visible = true;
                timer1.Stop();
            }
        }
    }
}
