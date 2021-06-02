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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(String user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                btnAdd.Hide();
                btnRemove.Hide();
                btnUpdate.Hide();
            }
            else if (user == "Admin")
            {
                btnPlace.Show();
                btnRemove.Show();
                btnUpdate.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ucAddItem1.Visible = false;
            uC_placeorder1.Visible = false;
            uC_update2.Visible = false;
            uC_remove1.Visible = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_placeorder1);
            uC_placeorder1.Visible=true;
            uC_placeorder1.BringToFront();
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucAddItem1.Visible = true;
            ucAddItem1.BringToFront();
        }

        private void uC_placeorder1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uC_update2.Visible = true;
            uC_update2.BringToFront();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            uC_remove1.Visible = true;
            uC_remove1.BringToFront();
        }
    }
}
