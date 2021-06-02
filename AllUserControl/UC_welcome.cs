using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.AllUserControl
{
    public partial class UC_welcome : UserControl
    {
        public UC_welcome()
        {
            InitializeComponent();
        }
        int num = 0;
        private void label2_Click(object sender, EventArgs e)
        {
            if (num == 0)
            {
                labelBanner.Location = new Point(3, 361);
                labelBanner.ForeColor = Color.Orange;
                num++;
            }
            else if (num == 1)
            {
                labelBanner.Location = new Point(91, 387);
                labelBanner.ForeColor = Color.Green;
                num++;
            }
            else if (num ==2)
            {
                labelBanner.Location = new Point(220, 424);
                labelBanner.ForeColor = Color.RoyalBlue;
                num=0;
            }
        }

        private void UC_welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
