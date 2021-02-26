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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = adventureWorksProducts1.Product;
            sqlDataAdapter1.Fill(adventureWorksProducts1.Product);
        }

        private void UpdButton_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(adventureWorksProducts1);
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Visible = true;
        }
    }
}
