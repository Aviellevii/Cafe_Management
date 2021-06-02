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
    public partial class UC_update : UserControl
    {
        function fn = new function();
        String query;
        public UC_update()
        {
            InitializeComponent();
        }

        private void guna2DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UC_update_Load(object sender, EventArgs e)
        {
            
            loadData();
        }
        public void loadData()
        {
            query = "select * from item";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }

        private void txtInsert_TextChanged(object sender, EventArgs e)
        {
            query = "select * from item where name like '"+txtInsert.Text+"%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }
        int id;
        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = guna2DataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            String name = guna2DataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            int price = int.Parse(guna2DataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtcategory.Text = category;
            txtItem.Text = name;
            txtprice.Text = price.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            query = "update item set name='" + txtItem.Text + "',category='" + txtcategory.Text + "',price='" + txtprice.Text + "' where id=" + id + "";
            fn.setData(query);
            loadData();
            txtcategory.Clear();
            txtItem.Clear();
            txtprice.Clear();
        }
    }
}
