using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MovieLibrary
{
    public class GenreList: List<GenreInfo>
    {
        public static GenreList GetDefaultGenreList()
        {
            GenreList myList = new GenreList();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-DS55KH6\SQLEXPRESS;Initial Catalog=Cinema;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetGenreList";
            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                GenreInfo newGenre = new GenreInfo();
                newGenre.GenreID = (int)dr["GenreID"];
                newGenre.GenreName = dr["GenreName"].ToString();

                myList.Add(newGenre);

            }

            return myList;
        }
    }
}