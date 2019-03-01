namespace LAX_A_SWindowsForm
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMovieID = new System.Windows.Forms.TextBox();
            this.MovieID = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxCast = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxViews = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonUpdateMovie = new System.Windows.Forms.Button();
            this.buttonUpdatePopularity = new System.Windows.Forms.Button();
            this.textBoxReleaseYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMovieID
            // 
            this.textBoxMovieID.Location = new System.Drawing.Point(48, 41);
            this.textBoxMovieID.Name = "textBoxMovieID";
            this.textBoxMovieID.Size = new System.Drawing.Size(100, 20);
            this.textBoxMovieID.TabIndex = 0;
            this.textBoxMovieID.TextChanged += new System.EventHandler(this.textBoxMovieID_TextChanged);
            this.textBoxMovieID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMovieID_KeyDown);
            // 
            // MovieID
            // 
            this.MovieID.AutoSize = true;
            this.MovieID.Location = new System.Drawing.Point(75, 25);
            this.MovieID.Name = "MovieID";
            this.MovieID.Size = new System.Drawing.Size(47, 13);
            this.MovieID.TabIndex = 1;
            this.MovieID.Text = "MovieID";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(48, 179);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 2;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(154, 179);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(218, 20);
            this.textBoxDescription.TabIndex = 3;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // textBoxCast
            // 
            this.textBoxCast.Location = new System.Drawing.Point(402, 179);
            this.textBoxCast.Name = "textBoxCast";
            this.textBoxCast.Size = new System.Drawing.Size(239, 20);
            this.textBoxCast.TabIndex = 4;
            this.textBoxCast.TextChanged += new System.EventHandler(this.textBoxCast_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cast";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "MovieTabe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Popularity";
            // 
            // textBoxViews
            // 
            this.textBoxViews.Location = new System.Drawing.Point(48, 320);
            this.textBoxViews.Name = "textBoxViews";
            this.textBoxViews.Size = new System.Drawing.Size(100, 20);
            this.textBoxViews.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Views";
            // 
            // buttonUpdateMovie
            // 
            this.buttonUpdateMovie.Enabled = false;
            this.buttonUpdateMovie.Location = new System.Drawing.Point(686, 176);
            this.buttonUpdateMovie.Name = "buttonUpdateMovie";
            this.buttonUpdateMovie.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateMovie.TabIndex = 12;
            this.buttonUpdateMovie.Text = "Update";
            this.buttonUpdateMovie.UseVisualStyleBackColor = true;
            this.buttonUpdateMovie.Click += new System.EventHandler(this.buttonUpdateMovie_Click);
            // 
            // buttonUpdatePopularity
            // 
            this.buttonUpdatePopularity.Enabled = false;
            this.buttonUpdatePopularity.Location = new System.Drawing.Point(686, 318);
            this.buttonUpdatePopularity.Name = "buttonUpdatePopularity";
            this.buttonUpdatePopularity.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdatePopularity.TabIndex = 13;
            this.buttonUpdatePopularity.Text = "Update";
            this.buttonUpdatePopularity.UseVisualStyleBackColor = true;
            this.buttonUpdatePopularity.Click += new System.EventHandler(this.buttonUpdatePopularity_Click);
            // 
            // textBoxReleaseYear
            // 
            this.textBoxReleaseYear.Location = new System.Drawing.Point(48, 225);
            this.textBoxReleaseYear.Name = "textBoxReleaseYear";
            this.textBoxReleaseYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxReleaseYear.TabIndex = 14;
            this.textBoxReleaseYear.TextChanged += new System.EventHandler(this.textBoxReleaseYear_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Release  Year";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxReleaseYear);
            this.Controls.Add(this.buttonUpdatePopularity);
            this.Controls.Add(this.buttonUpdateMovie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxViews);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCast);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.MovieID);
            this.Controls.Add(this.textBoxMovieID);
            this.Name = "UpdateForm";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMovieID_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMovieID;
        private System.Windows.Forms.Label MovieID;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxCast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxViews;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonUpdateMovie;
        private System.Windows.Forms.Button buttonUpdatePopularity;
        private System.Windows.Forms.TextBox textBoxReleaseYear;
        private System.Windows.Forms.Label label7;
    }
}