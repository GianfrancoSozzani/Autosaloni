using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Forms_RecuperaPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRecupera_Click(object sender, EventArgs e)
    {
        // controlli formali

        if (txtUSR.Text.Trim() == "")
        {
            lblMessaggio.Text = "Dati non validi";
            return;
        }

        // riempio la datable

        string wUSR = txtUSR.Text.Trim();
       

        //connessione

        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = "Data Source = DESKTOP-0E2GJI9\\SQLEXPRESS; Initial Catalog=AUTOSALONI; Integrated Security=true";



        SqlCommand cmd = new SqlCommand();
        // query di selezione
        // query: select * from utenti where usr = txtUsername.Text

        cmd.CommandText = "SELECT PWD FROM UTENTI WHERE USR = '"+wUSR+"'";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = conn;

        SqlDataAdapter DA = new SqlDataAdapter();
        DA.SelectCommand = cmd;

        DataTable DT = new DataTable();
        DA.Fill(DT);

        // testare se dt.rows.count == 0

        if (DT.Rows.Count == 0)
        {
            lblMessaggio.Text = "Dati non validi";
            return;
        }

        // altrimento leggo la pwd e la imposto nella label --> dt.rows [0] ["PWD"].toString();

        lblMessaggio.Text = "La tua password è: " + DT.Rows [0]["PWD"].ToString();
    }

}