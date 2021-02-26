using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clientDataSet11.Product;
            dataGridView1.Columns["ProductID"].Visible = false;
            dataGridView1.Columns["MakeFlag"].Visible = false;
            dataGridView1.Columns["FinishedGoodsFlag"].Visible = false;
            dataGridView1.Columns["SafetyStockLevel"].Visible = false;
            dataGridView1.Columns["ReorderPoint"].Visible = false;
            dataGridView1.Columns["StandardCost"].Visible = false;
            dataGridView1.Columns["DaysToManufacture"].Visible = false;
            dataGridView1.Columns["ProductLine"].Visible = false;
            dataGridView1.Columns["Class"].Visible = false;
            dataGridView1.Columns["Style"].Visible = false;
            dataGridView1.Columns["ProductSubcategoryID"].Visible = false;
            dataGridView1.Columns["ProductModelID"].Visible = false;
            dataGridView1.Columns["SellStartDate"].Visible = false;
            dataGridView1.Columns["SellEndDate"].Visible = false;
            dataGridView1.Columns["DiscontinuedDate"].Visible = false;
            dataGridView1.Columns["rowguid"].Visible = false;
            dataGridView1.Columns["ModifiedDate"].Visible = false;
            dataGridView1.Columns["Size UOM"].Visible = false;
            dataGridView1.Columns["weight UOM"].Visible = false;
            sqlDataAdapter1.Fill(clientDataSet11.Product);
        }
    }
}
