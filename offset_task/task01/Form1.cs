﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace task01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            {
                try
                {
                    sqlCommand1.Parameters["@FirstDate"].Value = FirstDate.Value;
                    sqlCommand1.Parameters["@LastDate"].Value = LastDate.Value;
                    sqlConnection1.Open(); 
                    SqlDataReader reader = sqlCommand1.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            results.Append(reader[i].ToString() + "\t");
                        }
                        results.Append(Environment.NewLine);
                    }
                    
                    ResultsTextBox.Text = "Product name\t\t Product number  Unit price  Order date" + "\r\n" + results.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection1.Close();
                }
            }
        }
    }
}
