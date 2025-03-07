using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descrizione di riepilogo per DB
/// </summary>
public class DB
{
    SqlConnection conn = new SqlConnection();
    public SqlCommand cmd = new SqlCommand();
    SqlDataAdapter DA = new SqlDataAdapter();
    //DataTable DT = new DataTable();

    public string query;

    public DB()
    {
        //
        // TODO: aggiungere qui la logica del costruttore
        //
        conn.ConnectionString = "Data Source = DESKTOP-0E2GJI9\\SQLEXPRESS; Initial Catalog=AUTOSALONI; Integrated Security=true;";
        cmd.Connection = conn;
        cmd.CommandType = CommandType.StoredProcedure;
    }

    public DataTable SQLselect()

    {
        DataTable DT = new DataTable();
        //DT.Clear();
        cmd.CommandText = query;
        DA.SelectCommand = cmd;
        DA.Fill(DT);
        return DT;
    }

    public void SQLcommand()
    {

        cmd.CommandText = query;
        // parametri
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();


    }
}