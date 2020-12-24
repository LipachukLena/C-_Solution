using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MovieLibrary
{
    public class GenreInfo
    {
        private int _genreID = 0;
        private string _genreName = "";
        public int GenreID
        {
            get
            {
                return _genreID;
            }
            set
            {
                _genreID = value;
            }
        }
        public string GenreName
        {
            get
            {
                return _genreName;
            }
            set
            {
                _genreName = value;
            }
        }
    }
}