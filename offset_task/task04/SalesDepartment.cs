using CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task04
{
    public partial class SalesDepartment : Form
    {
        SampleContext context = new SampleContext();
        public SalesDepartment()
        {
            InitializeComponent();
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SampleContext>());
        }

        private void Output() 
        { 
            if (this.CustomerradioButton.Checked == true) 
                GridView.DataSource = context.Customers.ToList(); 
            else if (this.OrderradioButton.Checked == true) 
                GridView.DataSource = context.Orders.ToList(); }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    FirstName = this.textBoxname.Text,
                    LastName = this.textBoxlastname.Text,
                    Email = this.textBoxmail.Text,
                    Orders = orderlistBox.SelectedItems.OfType<Order>().ToList()
                };
                context.Customers.Add(customer);
                context.SaveChanges();
                Output();
                textBoxname.Text = String.Empty;
                textBoxlastname.Text = String.Empty;
                textBoxmail.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            Output();
            var query = from b in context.Customers
                        orderby b.FirstName
                        select b;
            customerList.DataSource = query.ToList();
        }

        private void SalesDepartment_Load(object sender, EventArgs e)
        {
            context.Orders.Add(new Order { ProductName = "Гарнитура APPLE AirPods", UnitPrice = "12 790", Quantity = 12, PurchaseDate = DateTime.Parse("15.01.2021") });
            context.Orders.Add(new Order { ProductName = "Ноутбук APPLE MacBook Air 13.3\"", UnitPrice = "70 990", Quantity = 22, PurchaseDate = DateTime.Parse("03.02.2021") });
            context.Orders.Add(new Order { ProductName = "Планшет APPLE iPad 32Gb", UnitPrice = "36 990", Quantity = 17, PurchaseDate = DateTime.Parse("14.02.2021") });
            context.SaveChanges(); 
            orderlistBox.DataSource = context.Orders.ToList();
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridView.CurrentRow == null) return;
            var customer = GridView.CurrentRow.DataBoundItem as Customer;
            if (customer == null) return;
            labelid.Text = Convert.ToString(customer.CustomerId);
            textBoxCustomer.Text = customer.ToString();
            textBoxname.Text = customer.FirstName;
            textBoxlastname.Text = customer.LastName;
            textBoxmail.Text = customer.Email;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (labelid.Text == String.Empty) return;
            var id = Convert.ToInt32(labelid.Text); 
            var customer = context.Customers.Find(id); 
            if (customer == null) return;
            customer.FirstName = this.textBoxname.Text; 
            customer.LastName = this.textBoxlastname.Text; 
            customer.Email = this.textBoxmail.Text;
            context.Entry(customer).State = EntityState.Modified;
            context.SaveChanges(); 
            Output();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (labelid.Text == String.Empty) return;
            var id = Convert.ToInt32(labelid.Text); 
            var customer = context.Customers.Find(id);
            context.Entry(customer).State = EntityState.Deleted; 
            context.SaveChanges(); Output();
        }
    }
}
