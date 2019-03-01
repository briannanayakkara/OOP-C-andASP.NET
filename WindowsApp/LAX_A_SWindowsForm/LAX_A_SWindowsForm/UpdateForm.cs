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
    public partial class UpdateForm : Form
    {
        SqlCommand scmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        String connetionSrting;
        SqlConnection cnn = new SqlConnection();
        DataTable dt = new DataTable();
        string Movie_ID;

        public UpdateForm(string MovieID)

        {
            Movie_ID = MovieID;
            InitializeComponent();
        }

        private void textBoxMovieID_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMovieID.Text != "")
            {
                buttonUpdateMovie.Enabled = true;
            }
            else
            {
                buttonUpdateMovie.Enabled = false;
            }
        }
        private void textBoxMovieID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                    displaydataUpdate();

            } 
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            textBoxMovieID.Text = Movie_ID;
            displaydataUpdate();
        }

        // Updata movies Title,Description,Released year,Views

        public void UpdateButton1()
        {
            try
            {
                connetionSrting = "Data Source = 10.0.5.109; database =LAX_AC; User ID=Admin; Password=Passw0rd;";
                cnn = new SqlConnection(connetionSrting);
                cnn.Open();

                string sql = "update Movie set Title  = '" + textBoxTitle.Text + "',Movie_Description  = '" + textBoxDescription.Text + "', Casts  = '" + textBoxCast.Text + "',ReleasedYear  = '" + textBoxReleaseYear.Text + "'where MovieID ='" + textBoxMovieID.Text + "'";
                sda.UpdateCommand = new SqlCommand(sql, cnn);
                sda.UpdateCommand.ExecuteNonQuery();
                scmd.Dispose();
                cnn.Close();
                MessageBox.Show("MovieID = " + textBoxMovieID.Text + " has been updated");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }

        }
        public void UpdateButton2()
        {
            try
            {
                connetionSrting = "Data Source = 10.0.5.109; database =LAX_AC; User ID=Admin; Password=Passw0rd;";
                cnn = new SqlConnection(connetionSrting);
                cnn.Open();

                string sql = "update Popularity set Clicks =" + textBoxViews.Text + "where Popularity.MovieID =" + textBoxMovieID.Text;
                sda.UpdateCommand = new SqlCommand(sql, cnn);
                sda.UpdateCommand.ExecuteNonQuery();
                scmd.Dispose();
                cnn.Close();
                MessageBox.Show("MovieID = " + textBoxMovieID.Text + " has been updated");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }
            
        }
        private void buttonUpdateMovie_Click(object sender, EventArgs e)
        {
            UpdateButton1();
        }

        private void buttonUpdatePopularity_Click(object sender, EventArgs e)
        {
            UpdateButton2();
        }

        public void displaydataUpdate()
        {
            // Title
            connetionSrting = "Data Source = 10.0.5.109; database =LAX_AC; User ID=Admin; Password=Passw0rd;";
            cnn = new SqlConnection(connetionSrting);
            cnn.Open();
            
            SqlCommand scmdT = new SqlCommand($"select Movie.Title from Movie where Movie.MovieID = '{textBoxMovieID.Text}'", cnn);
            object title;
            int i;
            if (int.TryParse(textBoxMovieID.Text, out i))
            {
                title = scmdT.ExecuteScalar();


                if (title == null)
                {
                    title = 0;
                    textBoxTitle.Text = title.ToString();
                }
                else
                {
                    textBoxTitle.Text = title.ToString();
                }
            }
            else
            {
                title = 0;
                textBoxTitle.Text = title.ToString();
            }
            // Description
            SqlCommand scmdD = new SqlCommand("select Movie.Movie_Description from Movie where Movie.MovieID =" + textBoxMovieID.Text, cnn);
            object Description;
            if (int.TryParse(textBoxMovieID.Text, out i))
            {
                Description = scmdD.ExecuteScalar();
                if (Description == null)
                {
                    Description = 0;
                    textBoxDescription.Text = Description.ToString();
                }
                else
                {
                    textBoxDescription.Text = Description.ToString();
                }
            }
            else
            {
                Description = 0;
                textBoxDescription.Text = Description.ToString();
            }
            // Cast
            SqlCommand scmdC = new SqlCommand("select Movie.Casts from Movie where Movie.MovieID =" + textBoxMovieID.Text, cnn);
            object Cast;
            if (int.TryParse(textBoxMovieID.Text, out i))
            {
                Cast = scmdC.ExecuteScalar();
                if (Cast == null)
                {
                    Cast = 0;
                    textBoxCast.Text = Cast.ToString();
                }
                else
                {
                    textBoxCast.Text = Cast.ToString();
                }
            }
            else
            {
                Cast = 0;
                textBoxCast.Text = Cast.ToString();
            }
            // Release Year
            SqlCommand scmdR = new SqlCommand("select Movie.ReleasedYear from Movie where Movie.MovieID =" + textBoxMovieID.Text, cnn);
            object ReleasedYear;
            if (int.TryParse(textBoxMovieID.Text, out i))
            {
                ReleasedYear = scmdR.ExecuteScalar();
                if (ReleasedYear == null)
                {
                    ReleasedYear = 0;
                    textBoxReleaseYear.Text = ReleasedYear.ToString();
                }
                else
                {
                    textBoxReleaseYear.Text = ReleasedYear.ToString();
                }
            }
            else
            {
                ReleasedYear = 0;
                textBoxViews.Text = ReleasedYear.ToString();
            }

            // Views
            SqlCommand scmdV = new SqlCommand("select Popularity.Clicks from Popularity where Popularity.MovieID =" + textBoxMovieID.Text, cnn);
            object Views;
            if (int.TryParse(textBoxMovieID.Text, out i))
            {
                Views = scmdV.ExecuteScalar();
                if (Views == null)
                {
                    Views = 0;
                    textBoxViews.Text = Views.ToString();
                    MessageBox.Show("MovieID invalid");
                }
                else
                {
                    textBoxViews.Text = Views.ToString();
                }
            }
            else
            {
                Views = 0;
                textBoxViews.Text = Views.ToString();
                MessageBox.Show("MovieID invalid");
            }
            

            cnn.Close();
        }

        // Activate update button

        public void activateInsertButton()
        {
            if (textBoxTitle.Text != "" || textBoxTitle.Text != "0" && textBoxDescription.Text != "" || textBoxDescription.Text != "0" &&  textBoxCast.Text != "" || textBoxCast.Text != "0" && textBoxReleaseYear.Text != "" || textBoxReleaseYear.Text != "0" && textBoxViews.Text != "" || textBoxViews.Text != "0")
            {
                buttonUpdateMovie.Enabled = true;
                buttonUpdatePopularity.Enabled = true;
            }
            else
            {
                buttonUpdateMovie.Enabled = false;
                buttonUpdatePopularity.Enabled = false;
            }
        }


        //textbox
        private void textBoxReleaseYear_TextChanged(object sender, EventArgs e)
        {
            activateInsertButton();
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            activateInsertButton();
        }

        private void textBoxCast_TextChanged(object sender, EventArgs e)
        {
            activateInsertButton();
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            activateInsertButton();
        }

        //textbox 2
    }
}
