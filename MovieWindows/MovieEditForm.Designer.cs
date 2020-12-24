namespace MovieWindows
{
    partial class MovieEditForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label movieNameLabel;
            System.Windows.Forms.Label movieDateLabel;
            System.Windows.Forms.Label moviePriceLabel;
            System.Windows.Forms.Label genreIDLabel;
            System.Windows.Forms.Label ageLimitIDLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.movieNameTextBox = new System.Windows.Forms.TextBox();
            this.movieDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.moviePriceTextBox = new System.Windows.Forms.TextBox();
            this.movieInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreIDComboBox = new System.Windows.Forms.ComboBox();
            this.ageLimitIDComboBox = new System.Windows.Forms.ComboBox();
            this.genrebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ageLimitbindingSource = new System.Windows.Forms.BindingSource(this.components);
            movieNameLabel = new System.Windows.Forms.Label();
            movieDateLabel = new System.Windows.Forms.Label();
            moviePriceLabel = new System.Windows.Forms.Label();
            genreIDLabel = new System.Windows.Forms.Label();
            ageLimitIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movieInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genrebindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageLimitbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(90, 290);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 290);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // movieNameLabel
            // 
            movieNameLabel.AutoSize = true;
            movieNameLabel.Location = new System.Drawing.Point(153, 55);
            movieNameLabel.Name = "movieNameLabel";
            movieNameLabel.Size = new System.Drawing.Size(67, 15);
            movieNameLabel.TabIndex = 3;
            movieNameLabel.Text = "Название:";
            // 
            // movieNameTextBox
            // 
            this.movieNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieInfoBindingSource, "MovieName", true));
            this.movieNameTextBox.Location = new System.Drawing.Point(239, 55);
            this.movieNameTextBox.Name = "movieNameTextBox";
            this.movieNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.movieNameTextBox.TabIndex = 4;
            // 
            // movieDateLabel
            // 
            movieDateLabel.AutoSize = true;
            movieDateLabel.Location = new System.Drawing.Point(180, 92);
            movieDateLabel.Name = "movieDateLabel";
            movieDateLabel.Size = new System.Drawing.Size(40, 15);
            movieDateLabel.TabIndex = 4;
            movieDateLabel.Text = "Дата:";
            // 
            // movieDateDateTimePicker
            // 
            this.movieDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.movieInfoBindingSource, "MovieDate", true));
            this.movieDateDateTimePicker.Location = new System.Drawing.Point(239, 92);
            this.movieDateDateTimePicker.Name = "movieDateDateTimePicker";
            this.movieDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.movieDateDateTimePicker.TabIndex = 5;
            // 
            // moviePriceLabel
            // 
            moviePriceLabel.AutoSize = true;
            moviePriceLabel.Location = new System.Drawing.Point(180, 130);
            moviePriceLabel.Name = "moviePriceLabel";
            moviePriceLabel.Size = new System.Drawing.Size(40, 15);
            moviePriceLabel.TabIndex = 6;
            moviePriceLabel.Text = "Цена:";
            // 
            // moviePriceTextBox
            // 
            this.moviePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieInfoBindingSource, "MoviePrice", true));
            this.moviePriceTextBox.Location = new System.Drawing.Point(239, 130);
            this.moviePriceTextBox.Name = "moviePriceTextBox";
            this.moviePriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.moviePriceTextBox.TabIndex = 7;
            // 
            // movieInfoBindingSource
            // 
            this.movieInfoBindingSource.DataSource = typeof(MovieLibrary.MovieInfo);
            // 
            // genreIDLabel
            // 
            genreIDLabel.AutoSize = true;
            genreIDLabel.Location = new System.Drawing.Point(161, 174);
            genreIDLabel.Name = "genreIDLabel";
            genreIDLabel.Size = new System.Drawing.Size(59, 15);
            genreIDLabel.TabIndex = 8;
            genreIDLabel.Text = "Genre ID:";
            // 
            // genreIDComboBox
            // 
            this.genreIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.movieInfoBindingSource, "GenreID", true));
            this.genreIDComboBox.DataSource = this.genrebindingSource;
            this.genreIDComboBox.DisplayMember = "GenreName";
            this.genreIDComboBox.FormattingEnabled = true;
            this.genreIDComboBox.Location = new System.Drawing.Point(238, 174);
            this.genreIDComboBox.Name = "genreIDComboBox";
            this.genreIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.genreIDComboBox.TabIndex = 9;
            this.genreIDComboBox.ValueMember = "GenreID";
            // 
            // ageLimitIDLabel
            // 
            ageLimitIDLabel.AutoSize = true;
            ageLimitIDLabel.Location = new System.Drawing.Point(144, 218);
            ageLimitIDLabel.Name = "ageLimitIDLabel";
            ageLimitIDLabel.Size = new System.Drawing.Size(76, 15);
            ageLimitIDLabel.TabIndex = 10;
            ageLimitIDLabel.Text = "Age Limit ID:";
            // 
            // ageLimitIDComboBox
            // 
            this.ageLimitIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.movieInfoBindingSource, "AgeLimitID", true));
            this.ageLimitIDComboBox.DataSource = this.ageLimitbindingSource;
            this.ageLimitIDComboBox.DisplayMember = "AgeLimitName";
            this.ageLimitIDComboBox.FormattingEnabled = true;
            this.ageLimitIDComboBox.Location = new System.Drawing.Point(238, 218);
            this.ageLimitIDComboBox.Name = "ageLimitIDComboBox";
            this.ageLimitIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.ageLimitIDComboBox.TabIndex = 11;
            this.ageLimitIDComboBox.ValueMember = "AgeLimitID";
            // 
            // genrebindingSource
            // 
            this.genrebindingSource.DataSource = typeof(MovieLibrary.MovieList);
            // 
            // ageLimitbindingSource
            // 
            this.ageLimitbindingSource.DataSource = typeof(MovieLibrary.MovieList);
            // 
            // MovieEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 376);
            this.Controls.Add(ageLimitIDLabel);
            this.Controls.Add(this.ageLimitIDComboBox);
            this.Controls.Add(genreIDLabel);
            this.Controls.Add(this.genreIDComboBox);
            this.Controls.Add(moviePriceLabel);
            this.Controls.Add(this.moviePriceTextBox);
            this.Controls.Add(movieDateLabel);
            this.Controls.Add(this.movieDateDateTimePicker);
            this.Controls.Add(movieNameLabel);
            this.Controls.Add(this.movieNameTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MovieEditForm";
            this.Text = "MovieEditForm";
            this.Load += new System.EventHandler(this.MovieEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genrebindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageLimitbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource movieInfoBindingSource;
        private System.Windows.Forms.TextBox movieNameTextBox;
        private System.Windows.Forms.DateTimePicker movieDateDateTimePicker;
        private System.Windows.Forms.TextBox moviePriceTextBox;
        private System.Windows.Forms.ComboBox genreIDComboBox;
        private System.Windows.Forms.ComboBox ageLimitIDComboBox;
        private System.Windows.Forms.BindingSource genrebindingSource;
        private System.Windows.Forms.BindingSource ageLimitbindingSource;
    }
}