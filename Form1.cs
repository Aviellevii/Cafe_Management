using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Aviel" && txtPassword.Text == "pass")
            {
                Form2 d = new Form2("Admin");
                d.Show();
                this.Hide();
            }

        }

        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 d = new Form2("Guest");
            d.Show();
            this.Hide();
        }
    }
}
