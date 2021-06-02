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
    public partial class UC_placeorder : UserControl
    {
        function fn = new function();
        String query;
        public UC_placeorder()
        {
            InitializeComponent();
        }

        private void txtAddToCart_Click(object sender, EventArgs e)
        {
            string category = comboCategory.Text;
            query = "select name from item where category ='" + category + "'";
            showItem(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string category = comboCategory.Text;
            query = "select name from item where category ='" + category + "' and name like '" +txtSearch.Text+"%'";
            showItem(query);
        }
        private void showItem(String query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuentity.ResetText();
            txtTotal.Clear();
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;
            query = "select price from item where name= '"+text+"'";
            DataSet ds = fn.getData(query);
            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        private void txtQuentity_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtQuentity.Value.ToString());
            Int64 price= Int64.Parse(txtPrice.Text);
            txtTotal.Text = (quan * price).ToString();

        }

        int amount;
        private void guna2DataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(guna2DataGridView4.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView4.Rows.RemoveAt(this.guna2DataGridView4.SelectedRows[0].Index);

            }
            catch {  }
            total -= amount;
            labelTotalAmount.Text = "RS. " + total;
        }
        protected int n, total = 0;

        private void labelTotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = guna2DataGridView4.Rows.Add();
                guna2DataGridView4.Rows[n].Cells[0].Value = txtItemName.Text;
                guna2DataGridView4.Rows[n].Cells[1].Value = txtPrice.Text;
                guna2DataGridView4.Rows[n].Cells[2].Value = txtQuentity.Value;
                guna2DataGridView4.Rows[n].Cells[3].Value = txtTotal.Text;
                total += int.Parse(txtTotal.Text);
                labelTotalAmount.Text = "RS. " + total;
            }
            else
            {
                MessageBox.Show("minimum quantity need be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
