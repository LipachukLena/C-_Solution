using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MovieLibrary
{
    public class AgeLimitInfo
    {
        private int _ageLimitID = 0;
        private string _ageLimitName = "";
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
    }
}