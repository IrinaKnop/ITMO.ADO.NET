using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task03
{
    public partial class ClientForm : Form
    {
        private AdventureWorks2017Entities clientsContext;
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            clientsContext = new AdventureWorks2017Entities();
            var clients = clientsContext.People.Where(ct => ct.PersonType == "IN").OrderBy(ct => ct.LastName);
            clientGridView.DataSource = clients.ToList();

            clientGridView.Columns["BusinessEntityID"].Visible = false;
            clientGridView.Columns["PersonType"].Visible = false;
            clientGridView.Columns["NameStyle"].Visible = false;
            clientGridView.Columns["Title"].Visible = false;
            clientGridView.Columns["EmailPromotion"].Visible = false;
            clientGridView.Columns["AdditionalContactInfo"].Visible = false;
            clientGridView.Columns["Demographics"].Visible = false;
            clientGridView.Columns["rowguid"].Visible = false;
            clientGridView.Columns["ModifiedDate"].Visible = false;
            clientGridView.Columns["Suffix"].Visible = false;
            clientGridView.Columns["BusinessEntity"].Visible = false;
            clientGridView.Columns["BusinessEntityContacts"].Visible = false;
            clientGridView.Columns["EmailAddresses"].Visible = false;
            clientGridView.Columns["Password"].Visible = false;
            clientGridView.Columns["PersonPhones"].Visible = false;
            clientGridView.AllowUserToDeleteRows = false;
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientsContext.Dispose();
        }
    }
}
