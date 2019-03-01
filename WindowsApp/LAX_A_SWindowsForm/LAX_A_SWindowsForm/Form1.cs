using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LAX_A_SWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxUserID_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUserID.Text == "Admin" && textBoxPass.Text == "Passw0rd")
            {
                buttonConnect.Enabled = true;
            }
            else
            {
                buttonConnect.Enabled = false;
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUserID.Text == "Admin" && textBoxPass.Text == "Passw0rd")
            {
                buttonConnect.Enabled = true;
            }
            else
            {
                buttonConnect.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = true;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {

                string connectionString;
                SqlConnection cnn;

                connectionString = "Data Source = 10.0.5.109; database =LAX_AC; User ID=Admin; Password=Passw0rd;";
                cnn = new SqlConnection(connectionString);

               // this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }


       
    }
}
