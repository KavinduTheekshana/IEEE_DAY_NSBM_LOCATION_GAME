﻿using System;
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
    public partial class PopUpQR2 : MetroFramework.Forms.MetroForm
    {
        public PopUpQR2()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (txtans2.Text == "")
            {
                MessageBox.Show("Please Fill Data", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                try
                {
                    if (txtans2.Text== "S25vd2luZyBpcyBub3QgZW5vdWdoLCB3ZSBtdXN0IGFwcGx5LiBXaWxsaW5nIGlzIG5vdCBlbm91Z2gsIHdlIG11c3QgZG8u")
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
