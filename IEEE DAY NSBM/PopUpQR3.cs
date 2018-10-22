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
    public partial class PopUpQR3 : MetroFramework.Forms.MetroForm
    {
        public PopUpQR3()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (txtans3.Text == "")
            {
                MessageBox.Show("Please Fill Data", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                try
                {
                    if (txtans3.Text== "QSBkcmVhbSB5b3UgZHJlYW0gYWxvbmUgaXMgb25seSBhIGRyZWFtLiBBIGRyZWFtIHlvdSBkcmVhbSB0b2dldGhlciBpcyByZWFsaXR5Lg==")
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
