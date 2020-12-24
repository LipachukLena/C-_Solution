using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MovieLibrary
{
    public class AgeLimitList : List<AgeLimitInfo>
    {
        public static AgeLimitList GetDefaultAgeLimitList()
        {
            AgeLimitList myList = new AgeLimitList();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-DS55KH6\SQLEXPRESS;Initial Catalog=Cinema;Integrated Security=True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetAgeLimitList";
            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                AgeLimitInfo newAgeLimit = new AgeLimitInfo();
                newAgeLimit.AgeLimitID = (int)dr["AgeLimitID"];
                newAgeLimit.AgeLimitName = dr["AgeLimitName"].ToString();

                myList.Add(newAgeLimit);

            }

            return myList;
        }
    }
}