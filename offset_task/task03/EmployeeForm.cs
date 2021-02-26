using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace task03
{
    public partial class EmployeeForm : Form
    {
        private AdventureWorks2017Entities clientsContext;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            clientsContext = new AdventureWorks2017Entities();
            
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                var clients = clientsContext.People.Where(ct => ct.PersonType == "IN").OrderBy(ct => ct.LastName);
                clientsGridView.DataSource = clients.ToList();
                editGridView.DataSource = clientsContext.People.Local.ToBindingList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                clientsContext.SaveChanges();
                MessageBox.Show("Changes saved to the database.");
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            clientsContext.Dispose();
        }
    }
}
