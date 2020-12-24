using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace MovieLibrary
{
    public class MovieList : List<MovieInfo>
    {
        public static MovieList GetDefaultMoviesList()
        {
            MovieList myList = new MovieList();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-DS55KH6\SQLEXPRESS;Initial Catalog=Cinema;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetMovieList";
            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                MovieInfo newMovie = new MovieInfo();
                newMovie.MovieID = (int)dr["MovieID"];
                newMovie.MovieName = dr["MovieName"].ToString();
                newMovie.MovieDate = (DateTime)dr["MovieDate"];
                newMovie.MoviePrice = (int)dr["MoviePrice"];
                newMovie.GenreID = (int)dr["GenreID"];
                newMovie.GenreName = dr["GenreName"].ToString();
                newMovie.AgeLimitID = (int)dr["AgeLimitID"];
                newMovie.AgeLimitName = dr["AgeLimitName"].ToString();

                myList.Add(newMovie);

            }

            return myList;
        }

    }
}