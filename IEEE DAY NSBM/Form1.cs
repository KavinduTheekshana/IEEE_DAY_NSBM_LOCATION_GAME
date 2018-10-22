using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IEEE_DAY_NSBM
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public int id;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (num1.Text == "" && num2.Text == "" && num3.Text == "" && num4.Text == "")
            {
                MessageBox.Show("Please Fill Data", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                try
                {
                    //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=Baby;uid=root;sslMode = none");
                    MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=ieeedaynsbm;uid=root;sslMode = none");
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM `details` WHERE num1='"+num1.Text+"' AND num2='"+num2.Text+"' AND num3='"+num3.Text+"' AND num4='"+num4.Text+"'", conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Congratulations You Have Cracked First Task", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        
                        if (num4.Text == "909")
                        {
                            PopUpQR1 pq1 = new PopUpQR1();
                            pq1.Show();
                        }else if (num4.Text == "175")
                        {
                            PopUpQR2 pq2 = new PopUpQR2();
                            pq2.Show();
                        }
                        else if (num4.Text == "988")
                        {
                            PopUpQR3 pq3 = new PopUpQR3();
                            pq3.Show();
                        }
                        num1.Clear();
                        num2.Clear();
                        num3.Clear();
                        num4.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Answer", "Invalid Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        num1.Clear();
                        num2.Clear();
                        num3.Clear();
                        num4.Clear();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
