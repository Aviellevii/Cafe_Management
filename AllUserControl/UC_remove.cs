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
    public partial class UC_remove : UserControl
    {
        function fn = new function();
        String query;
        public UC_remove()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_remove_Load(object sender, EventArgs e)
        {
            label3.Text = "How To Delete?";
            label3.ForeColor = Color.Blue;
            loadData();
        }
        public void loadData()
        {
            query = "select * from item";
            DataSet ds = fn.getData(query);
            guna2DataGridView3.DataSource = ds.Tables[0];
        }

        private void txtInsert_TextChanged(object sender, EventArgs e)
        {
            query = "select * from item where name like '"+txtInsert.Text+"%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView3.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Item?","delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                int id = int.Parse(guna2DataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from item where id="+ id +"";
                fn.setData(query);
                loadData();
            }
        }
    }
}
