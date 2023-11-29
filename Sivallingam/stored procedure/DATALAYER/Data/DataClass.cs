using DATALAYER.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using SPStore_DTO.viewmodal;
using Microsoft.AspNetCore.Mvc;
using StoreProcedure_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALAYER.Data
{
    public class DataClass : IDataInterface
    {
      //  private readonly SPDbcontext _sPDbContext;
        private readonly IConfiguration _con;
        public DataClass(IConfiguration con)
        {
           // _sPDbContext = sPDbcontext;
            _con = con;
        }
        public async Task<object>POST(ViewModal details)
        {
            SqlConnection sqlCon = null;
            String SqlconString = _con.GetConnectionString("MVC6CrudConnectionString");
            using (sqlCon = new SqlConnection(SqlconString))
            {
               sqlCon.Open();
                SqlCommand sql_cmnd = new SqlCommand("store_twoprocedure", sqlCon);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@KAPILAN_ID", details.KAPILAN_ID);
                sql_cmnd.Parameters.AddWithValue("@KAPILAN_NAME", details.KAPILAN_NAME);
                sql_cmnd.Parameters.AddWithValue("@KAPILAN_DEPARTMENT", details.KAPILAN_DEPARTMENT);
                sql_cmnd.Parameters.AddWithValue("@KAPILAN_CITY", details.KAPILAN_CITY);
                sql_cmnd.Parameters.AddWithValue("@SIVA_AGE",  details.SIVA_AGE);
                sql_cmnd.Parameters.AddWithValue("@SIVA_GENDER", details.SIVA_GENDER);
                sql_cmnd.ExecuteNonQuery();
                sqlCon.Close();
            }
            return details;
        }
        public async Task<object> Update(ViewModal Update_details)
        {
            SqlConnection sqlCon = null;
            String SqlconString = _con.GetConnectionString("MVC6CrudConnectionString");
            using (sqlCon = new SqlConnection(SqlconString))
            {
                sqlCon.Open();

                SqlCommand sql_cmnd = new SqlCommand("store_twoUPDATEprocedure", sqlCon);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@KAPILAN_ID", Update_details.KAPILAN_ID);
                sql_cmnd.Parameters.AddWithValue("@KAPILAN_NAME", Update_details.KAPILAN_NAME);
                sql_cmnd.Parameters.AddWithValue("@KAPILAN_DEPARTMENT", Update_details.KAPILAN_DEPARTMENT);
                sql_cmnd.Parameters.AddWithValue("@KAPILAN_CITY", Update_details.KAPILAN_CITY);
                sql_cmnd.Parameters.AddWithValue("@SIVA_AGE", Update_details.SIVA_AGE);
                sql_cmnd.Parameters.AddWithValue("@SIVA_GENDER", Update_details.SIVA_GENDER);
                await sql_cmnd.ExecuteNonQueryAsync();
                sqlCon.Close();
            }
            return Update_details;
        }
        public async Task<object> GET()
        {
            SqlConnection sqlCon = null;
            String SqlconString = _con.GetConnectionString("MVC6CrudConnectionString");
            var sql = new List<ViewModal>();
            using (sqlCon = new SqlConnection(SqlconString))
            {
                sqlCon.Open();

                using (SqlCommand command = new SqlCommand("store_twoGETprocedure", sqlCon))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ViewModal ss = new ViewModal
                            {
                                KAPILAN_ID = reader.GetInt32("KAPILAN_ID"),
                                KAPILAN_NAME = reader.GetString("KAPILAN_NAME"),
                                KAPILAN_DEPARTMENT = reader.GetString("KAPILAN_DEPARTMENT"),
                                KAPILAN_CITY = reader.GetString("KAPILAN_CITY"),
                                SIVA_ID = reader.GetInt32("SIVA_ID"),
                                SIVA_AGE = reader.GetInt32("SIVA_AGE"),
                                SIVA_GENDER = reader.GetString("SIVA_GENDER")
                            };
                            sql.Add(ss);
                        }
                    }
                }
            }
            return sql;
        }
        public async Task<int> Delete(int KAPILAN_ID)
        {
            SqlConnection sqlCon = null;
            String SqlconString = _con.GetConnectionString("MVC6CrudConnectionString");

            using (sqlCon = new SqlConnection(SqlconString))
            {
                using (SqlCommand command = new SqlCommand("store_deleteprocedure", sqlCon))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@KAPILAN_ID", SqlDbType.Int);
                    command.Parameters["@KAPILAN_ID"].Value = (KAPILAN_ID);
                    sqlCon.Open();
                    command.ExecuteNonQuery();
                    sqlCon.Close();
                }
            }
            return KAPILAN_ID;
        }
    }
}

