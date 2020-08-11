﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper; //dapper for SQL connections and functions
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DataLibrary.DataAccess
{
    public static class SQLDataAccess
    {
        // connection string function

        public static string GetConnectionString(string connectionString = "SchedlrDB")
        {
            return ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
           
            
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList(); // pulling all data into a list
            }
        }

        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data); // executing sql to database and returns number of rows affected
            }
        }
    }
}
