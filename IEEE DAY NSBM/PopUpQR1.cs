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
    public partial class PopUpQR1 : MetroFramework.Forms.MetroForm
    {
        public PopUpQR1()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (txtans1.Text == "")
            {
                MessageBox.Show("Please Fill Data", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                try
                {
                    
                    if (txtans1.Text== "TW9uZXkgbWF5IG5vdCBidXkgaGFwcGluZXNzLCBidXQgaXQgY2FuIGRhbW4gd2VsbCBnaXZlIGl0")
                    {
                        label1.Text = "YOUR TEAM IS WIN";
                    }
                    else
                    {
                        label1.Text = "TRY AGAIN";
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
