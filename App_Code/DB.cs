﻿using System.Data;
using System.Data.SqlClient;


public class DB
{


    SqlConnection conn = new SqlConnection();
    SqlDataAdapter DA = new SqlDataAdapter();
    public SqlCommand cmd = new SqlCommand();
    public string query;
    public DB()
    {
        conn.ConnectionString = "Data Source = DESKTOP-705G4DM\\SQLEXPRESS; Initial Catalog=AUTOSALONI; Integrated Security=true";
        cmd.Connection = conn;
        cmd.CommandType = CommandType.StoredProcedure;
    }
    public DataTable SQLselect()
    {
        DataTable DT = new DataTable();
        cmd.CommandText = query;
        DA.SelectCommand = cmd;
        DA.Fill(DT);
        return DT;
    }
    public void SQLCommand()
    {
        cmd.CommandText = query;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
}