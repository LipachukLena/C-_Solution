using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MovieLibrary
{
    public class MovieInfo
    {
        private int _movieID = 0;
        private string _movieName = "";
        private System.DateTime _movieDate = DateTime.Today;
        private int _moviePrice = 0;
        private int _genreID = 0;
        private string _genreName = "";
        private int _ageLimitID = 0;
        private string _ageLimitName = "";

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
        public int AgeLimitID
        {
            get
            {
                return _ageLimitID;
            }
            set
            {
                _ageLimitID = value;
            }
        }
        public string AgeLimitName
        {
            get
            {
                return _ageLimitName;
            }
            set
            {
                _ageLimitName = value;
            }
        }
        public int MovieID
        {
            get
            {
                return _movieID;
            }
            set
            {
                _movieID = value;
            }
        }

        public string MovieName
        {
            get
            {
                return _movieName;
            }

            set
            {
                _movieName = value;
            }
        }

        public DateTime MovieDate
        {
            get
            {
                return _movieDate;
            }
            set
            {
                _movieDate = value;
            }
        }

        public int MoviePrice
        {
            get
            {
                return _moviePrice;
            }
            set
            {
                _moviePrice = value;
            }
        }
        public void GetMovie(int movieId)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-DS55KH6\SQLEXPRESS;Initial Catalog=Cinema;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetMovie";

            cm.Parameters.Add(new SqlParameter("@MovieID", _movieID));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                _movieName = dr["MovieName"].ToString();
                _movieDate = (DateTime)dr["MovieDate"];
                _movieID = (int)dr["MovieID"];
                _moviePrice = (int)dr["MoviePrice"];
                _genreID = (int)dr["GenreID"];
                _genreName = dr["GenreName"].ToString();
                _ageLimitID = (int)dr["AgeLimitID"];
                _ageLimitName = dr["AgeLimitName"].ToString();
            }
        }

        public void InsertNewMovie()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-DS55KH6\SQLEXPRESS;Initial Catalog=Cinema;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertMovie";

            cm.Parameters.Add(new SqlParameter("@MovieName", _movieName));
            cm.Parameters.Add(new SqlParameter("@MovieDate", _movieDate));
            cm.Parameters.Add(new SqlParameter("@MoviePrice", _moviePrice));
            cm.Parameters.Add(new SqlParameter("@GenreID", _genreID));
            cm.Parameters.Add(new SqlParameter("@AgeLimitID", _ageLimitID));

            cm.ExecuteNonQuery();
        }
        public void DeleteMovie()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-DS55KH6\SQLEXPRESS;Initial Catalog=Cinema;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "DeleteMovie";

            cm.Parameters.Add(new SqlParameter("@MovieID", _movieID));

            cm.ExecuteNonQuery();
        }

        public void UpdateMovie()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-DS55KH6\SQLEXPRESS;Initial Catalog=Cinema;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "UpdateMovie";

            cm.Parameters.Add(new SqlParameter("@MovieID", _movieID));
            cm.Parameters.Add(new SqlParameter("@MovieName", _movieName));
            cm.Parameters.Add(new SqlParameter("@MovieDate", _movieDate));
            cm.Parameters.Add(new SqlParameter("@MoviePrice", _moviePrice));
            cm.Parameters.Add(new SqlParameter("@GenreID", _genreID));
            cm.Parameters.Add(new SqlParameter("@AgeLimitID", _ageLimitID));

            cm.ExecuteNonQuery();
        }

    }
}