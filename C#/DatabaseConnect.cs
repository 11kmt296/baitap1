using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;

namespace baitap1.C_
{
    class DatabaseConnect
    {
        private string _user;
        private string _password;
        private string _serverurl;
        private string _database;
        private string _connectionstring;
        public string SqlQuery { get; set; }
        public string ErrorConnect { get; private set; }
        public string Status { get; private set; }   

        public DatabaseConnect()
        {   
            try
        {
            this._user = ConfigurationManager.AppSettings.Get("user");
            this._password = ConfigurationManager.AppSettings.Get("password");
            this._serverurl = ConfigurationManager.AppSettings.Get("serverurl");
            this._database = ConfigurationManager.AppSettings.Get("database");

            this._connectionstring = "user id =" + this._user + ";" +
                                        "password =" + this._password + ";" +
                                        "server=" + this._serverurl + ";" +
                                        "Trusted_Connection=no;" +
                                        "database=" + this._database + ";" +
                                        "connection timeout=30";
            SqlConnection SqlConnect = new SqlConnection(this._connectionstring);
            SqlConnect.Open();
            this.Status = SqlConnect.State.ToString();
    }
            catch(Exception e)
    {
        this.ErrorConnect = e.ToString();
    }
        }
    }
    
}
