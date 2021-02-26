
namespace task01
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.LoadButton = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstDate = new System.Windows.Forms.DateTimePicker();
            this.LastDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-SHKM9OT\\SQLEXPRESS;Initial Catalog=AdventureWorks2017;Integra" +
    "ted Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FirstDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"),
            new System.Data.SqlClient.SqlParameter("@LastDate", System.Data.SqlDbType.DateTime, 8, "OrderDate")});
            // 
            // LoadButton
            // 
            this.LoadButton.AutoSize = true;
            this.LoadButton.Location = new System.Drawing.Point(472, 12);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(110, 23);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Загрузить данные";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsTextBox.Location = new System.Drawing.Point(13, 43);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ReadOnly = true;
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(775, 395);
            this.ResultsTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите диапазон дат с:";
            // 
            // FirstDate
            // 
            this.FirstDate.Location = new System.Drawing.Point(141, 15);
            this.FirstDate.Name = "FirstDate";
            this.FirstDate.Size = new System.Drawing.Size(138, 20);
            this.FirstDate.TabIndex = 3;
            this.FirstDate.Value = new System.DateTime(2011, 6, 12, 0, 0, 0, 0);
            // 
            // LastDate
            // 
            this.LastDate.Location = new System.Drawing.Point(307, 15);
            this.LastDate.Name = "LastDate";
            this.LastDate.Size = new System.Drawing.Size(137, 20);
            this.LastDate.TabIndex = 4;
            this.LastDate.Value = new System.DateTime(2014, 7, 12, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "по: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LastDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.LoadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FirstDate;
        private System.Windows.Forms.DateTimePicker LastDate;
        private System.Windows.Forms.Label label2;
    }
}

