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
    public partial class Form2 : Form
    {
        SqlCommand scmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        String sql, connetionSrting;
        SqlConnection cnn = new SqlConnection();
        DataTable dt = new DataTable();

        public Form2()
        {
            InitializeComponent();
            DisplayData();
        }

        public Form2(string MovieID)
        {
            textBoxUpdate.Text = MovieID;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void DisplayData()
        {
            dt = new DataTable();
            connetionSrting = "Data Source = 10.0.5.109; database =LAX_AC; User ID=Admin; Password=Passw0rd;";
            cnn = new SqlConnection(connetionSrting);
            cnn.Open();
            sda = new SqlDataAdapter("select Movie.MovieID, Movie.Title, Movie.Movie_Description, Movie.Casts, Movie.ReleasedYear, Popularity.Clicks from Movie join Popularity on  Movie.MovieID = Popularity.MovieID", cnn);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxUpdate_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUpdate.Text == "")
            {
                buttonUpdate.Enabled = false;
            }
            else
            {
                buttonUpdate.Enabled = true;
            }
        }
        private void textBoxDelete_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDelete.Text == "")
            {
                buttonDelete.Enabled = false;
            }
            else
            {
                buttonDelete.Enabled = true;
            }
        }

        // Insert action
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                connetionSrting = "Data Source = 10.0.5.109; database =LAX_AC; User ID=Admin; Password=Passw0rd;";
                cnn = new SqlConnection(connetionSrting);
                cnn.Open();
                InsertForm Insert = new InsertForm();
                Insert.Show();
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            
        }

        // Update action
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connetionSrting = "Data Source = 10.0.5.109; database =LAX_AC; User ID=Admin; Password=Passw0rd;";
                cnn = new SqlConnection(connetionSrting);
                cnn.Open();
                sda = new SqlDataAdapter("select Movie.Title,Movie.Movie_Description, Movie.Casts, Movie.ReleasedYear, Popularity.Clicks from Movie, Popularity where Movie.MovieID =" + textBoxUpdate.Text , cnn);
                UpdateForm Uform = new UpdateForm(textBoxUpdate.Text);
                Uform.Show();
               
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand scmd = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter();
            String sql, connetionSrting;
            SqlConnection cnn = new SqlConnection();
            DataTable dt = new DataTable();

            connetionSrting = "Data Source = 10.0.5.109; database =LAX_AC; User ID=Admin; Password=Passw0rd;";
            cnn = new SqlConnection(connetionSrting);
            cnn.Open();
            sda = new SqlDataAdapter("select Movie.MovieID, Movie.Title,Movie.Movie_Description, Movie.Casts, Movie.ReleasedYear, Popularity.Clicks from Movie join Popularity on Popularity.MovieID = Movie.MovieID where Movie.Title like '%" + textBoxSearch.Text + "%' or Movie.Casts like '%" + textBoxSearch.Text + "%' or Movie.ReleasedYear like '%" + textBoxSearch.Text.ToString() + "%' ", cnn);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            DisplayData();
            
        }

        // Delete action

        public void DeleteData()
        {

            connetionSrting = "Data Source = 10.0.5.109; database =LAX_AC; User ID=Admin; Password=Passw0rd;";
            cnn = new SqlConnection(connetionSrting);
            cnn.Open();
            string sql1 = "delete Popularity where MovieID   =" + textBoxDelete.Text; //  sql delete comand1 
            scmd = new SqlCommand(sql1, cnn);
            sda.DeleteCommand = new SqlCommand(sql1, cnn); 
            sda.DeleteCommand.ExecuteNonQuery();
            scmd.Dispose();

            string sql2 = "delete Movie where MovieID  =" + textBoxDelete.Text; //  sql delete comand2
            scmd = new SqlCommand(sql1, cnn);
            sda.DeleteCommand = new SqlCommand(sql1, cnn);
            sda.DeleteCommand.ExecuteNonQuery();
            scmd.Dispose();

            cnn.Close();
            MessageBox.Show("MovieID = " + textBoxDelete.Text + " has been deleted");
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }
        }

    }
}
