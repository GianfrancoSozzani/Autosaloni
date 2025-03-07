using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


// system funzioni base framework .net
// data rigurda solo data

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAccedi_Click(object sender, EventArgs e)
    {
        // controlli formali

        // Trim() è una funzione che toglie gli spazi all'inizio e al fondo

        if(txtUSR.Text.Trim() == "" || txtPWD.Text == "")
        {
            lblMessaggio.Text = "Dati non validi";
            return;
        }

        string wUSR = txtUSR.Text.Trim();
        string wPWD = txtPWD.Text;

        //connessione

        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = "Data Source = DESKTOP-0E2GJI9\\SQLEXPRESS; Initial Catalog=AUTOSALONI; Integrated Security=true";



        SqlCommand cmd = new SqlCommand();
        // query di selezione
        // interrompo la stringa inserisco variabile c#
        //cmd.CommandText = "select count(*) as QUANTI from UTENTI where USR='" + wUSR + "' and PWD='" + wPWD + "'"; 

        //cmd.CommandType = CommandType.Text;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "LoginAutoSaloni";
        cmd.Parameters.AddWithValue("@usr", wUSR);
        cmd.Parameters.AddWithValue("@pwd", wPWD);
        cmd.Connection = conn;

        SqlDataAdapter DA = new SqlDataAdapter();
        DA.SelectCommand = cmd;

        DataTable DT = new DataTable();

        DA.Fill(DT);

        // controllo login

        // rows è un array
        int trovati =(int)DT.Rows[0]["QUANTI"];

        if (trovati == 0)
        {
            lblMessaggio.Text = "Dati non validi";
            return;
        }

        Session["USR"] = wUSR;

        // se l'utente è loggato vado a default
        Response.Redirect("Default.aspx");
    }
}