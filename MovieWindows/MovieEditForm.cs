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
    public partial class MovieEditForm : Form
    {
        public MovieInfo _newMovie = new MovieInfo();
        public MovieEditForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_newMovie.MovieID > 0)
            {
                _newMovie.UpdateMovie();
            }
            else
            {
                _newMovie.InsertNewMovie();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MovieEditForm_Load(object sender, EventArgs e)
        {
            GenreList _genreList = GenreList.GetDefaultGenreList();
            genrebindingSource.DataSource = _genreList;

            AgeLimitList _ageLimitList = AgeLimitList.GetDefaultAgeLimitList();
            ageLimitbindingSource.DataSource = _ageLimitList;

            movieInfoBindingSource.DataSource = _newMovie;
        }
    }
}
