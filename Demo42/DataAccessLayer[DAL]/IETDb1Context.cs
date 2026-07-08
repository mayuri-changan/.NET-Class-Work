using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Demo42.Models;
namespace Demo42.DataAccessLayer
{
    public class IETDb1Context
    {
        string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=IETDb1;Integrated Security=True;Encrypt=False";
        public List<Emp> SelectRecords()
        {
            SqlConnection con = new SqlConnection(_connectionString);

            string selectQuery = "Select * from Emp";

            //SqlCommand cmd = new SqlCommand(selectQuery,con);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = selectQuery;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            List<Emp> emps = new List<Emp>();

            while (reader.Read())
            {
                // if reader represents a row and a row is a collection of columns
                int id = Convert.ToInt32(reader[0]);//Id
                string? nm = Convert.ToString(reader["Name"]);
                string? add = Convert.ToString(reader["Address"]);

                emps.Add(new Emp() { Id = id, Name = nm, Address = add });
            }

            con.Close();

            return emps;
        }
        public Emp SelectEmpById(int id)
        {
            SqlConnection con = new SqlConnection(_connectionString);

            string selectQuery = $"Select * from Emp where Id ={id}";

            //SqlCommand cmd = new SqlCommand(selectQuery,con);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = selectQuery;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            Emp emp = new Emp();

            while (reader.Read())
            {
                emp.Id = Convert.ToInt32(reader["Id"]);
                emp.Name = Convert.ToString(reader["Name"]);
                emp.Address = Convert.ToString(reader["Address"]);




            }

            con.Close();

            return emp;
        }
        //public int InsertRecord(Emp obj)
        //{
        //    int noRowsAfftected = 0;

        //    using (SqlConnection con = new SqlConnection(_connectionString))
        //    {
        //        string insertQuery = $"insert into Emp values({obj.Id},'{obj.Name}','{obj.Address}')";
        //        // "values(1,'HJ','NYC')"

        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.CommandText = insertQuery;
        //            cmd.CommandType = System.Data.CommandType.Text;
        //            cmd.Connection = con;

        //            con.Open();
        //            noRowsAfftected = cmd.ExecuteNonQuery();
        //        }
        //    }
        //    return noRowsAfftected;
        //}

        public int UpdateRecord(int id, Emp obj)
        {
            int noRowsAfftected = 0;

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string updateQuery = $"update Emp set Name ='{obj.Name}', Address ='{obj.Address}' where Id = {id}";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = updateQuery;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = con;

                    con.Open();

                    noRowsAfftected = cmd.ExecuteNonQuery();
                }
            }

            return noRowsAfftected;
        }

        //public int DeleteRecord(int id)
        //{
        //    int noRowsAfftected = 0;

        //    using (SqlConnection con = new SqlConnection(_connectionString))
        //    {
        //        string deleteQuery = $"Delete Emp where Id = {id}";

        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.CommandText = deleteQuery;
        //            cmd.CommandType = System.Data.CommandType.Text;
        //            cmd.Connection = con;

        //            con.Open();

        //            noRowsAfftected = cmd.ExecuteNonQuery();
        //        }
        //    }

        //    return noRowsAfftected;
        //}
    }
}
