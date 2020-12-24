using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieLibrary;

namespace MovieWindows
{
    public partial class MovieForm : Form
    {
        MovieList _movieList = new MovieList();
        public MovieForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MovieRefresh();

        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovieEditForm newForm = new MovieEditForm();
            newForm.ShowDialog();
            MovieRefresh();
        }

        void MovieRefresh()
        {
            _movieList = MovieList.GetDefaultMoviesList();
            movieListBindingSource.DataSource = null;
            movieListBindingSource.DataSource = _movieList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int movieID = (int)movieListDataGridView.SelectedRows[0].Cells[0].Value;
            foreach (MovieInfo movie in _movieList)
            {
                if (movie.MovieID == movieID)
                {
                    movie.DeleteMovie();
                }
            }
            MovieRefresh();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int movieID = (int)movieListDataGridView.SelectedRows[0].Cells[0].Value;

            MovieEditForm newform = new MovieEditForm();
            foreach (MovieInfo movie in _movieList)
            {
                movie.GetMovie(movieID);
                newform._newMovie = movie;
            }
            newform.ShowDialog();
            MovieRefresh();


        }
    }
}
