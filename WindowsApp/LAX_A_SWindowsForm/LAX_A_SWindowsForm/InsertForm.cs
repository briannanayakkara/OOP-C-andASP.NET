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
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }
        SqlCommand scmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        String sql, connetionSrting;
        SqlConnection cnn = new SqlConnection();
        DataTable dt = new DataTable();

        public void activateInsertButton()
        {
            if (textBoxTitle.Text != "" && textBoxDescription.Text != "" && textBoxCast.Text != "" && textBoxReleaseYear.Text != "" &&  textBoxViews.Text != "")
            {
                buttonInsertData.Enabled = true;
            }
            else
            {
                buttonInsertData.Enabled = false;
            }
        }

        // text boxes
    
        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            activateInsertButton();
        }
        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            activateInsertButton();
        }
        private void textBoxCast_TextChanged(object sender, EventArgs e)
        {
            activateInsertButton();
        }
        private void textBoxReleaseYear_TextChanged(object sender, EventArgs e)
        {
            activateInsertButton();
        }
        private void textBoxViews_TextChanged_1(object sender, EventArgs e)
        {
            activateInsertButton();
        }



        // get data from the text boxes
        public void InsertData()
        {
            connetionSrting = "Data Source = 10.0.5.109; database =LAX_AC; User ID=Admin; Password=Passw0rd;";
            cnn = new SqlConnection(connetionSrting);
            cnn.Open();

            string sql1 = "insert into Movie values('" + textBoxTitle.Text + "','" + textBoxDescription.Text + "','" + textBoxCast.Text + "'," + textBoxReleaseYear.Text + ")"; // sql comands for insert data 
            scmd = new SqlCommand(sql1, cnn);
            sda.InsertCommand = new SqlCommand(sql1, cnn);
            sda.InsertCommand.ExecuteNonQuery();
            scmd.Dispose();

            string sql2 = "insert into Popularity(Clicks) values(" + textBoxViews.Text + ")";
            scmd = new SqlCommand(sql2, cnn);
            sda.InsertCommand = new SqlCommand(sql2, cnn);
            sda.InsertCommand.ExecuteNonQuery();
            scmd.Dispose();

            cnn.Close();
            MessageBox.Show("New movie has been created");
            this.Close();

        }

        //insert buttton

        private void buttonInsertData_Click(object sender, EventArgs e)
        {
            InsertData();
        }
    }
}
