using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_ModificaProfilo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Session["USR"] as string))
        {
            Response.Redirect("Login.aspx");
        }
        // carico i dati dell'utente dal DB

        // guarda che se per caso l'ho già caricata non lo rifare

        if (!IsPostBack)
        {


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = DESKTOP-0E2GJI9\\SQLEXPRESS; Initial Catalog=AUTOSALONI; Integrated Security=true";

            SqlCommand cmd = new SqlCommand();

            // query di selezione

            cmd.CommandText = "Select * from UTENTI where USR ='" + Session["USR"] + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = cmd;

            DataTable DT = new DataTable();
            DA.Fill(DT);

            txtUSR.Text = DT.Rows[0]["USR"].ToString();
            txtCognome.Text = DT.Rows[0]["COGNOME"].ToString();
            txtNome.Text = DT.Rows[0]["NOME"].ToString();
            txtCitta.Text = DT.Rows[0]["CITTA"].ToString();
        }
    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        // cotrolli formali
        string USR = txtUSR.Text;
        string PWD = txtPWD.Text;
        string PWD2 = txtPWD2.Text;
        string COGNOME = txtCognome.Text.Trim();
        string NOME = txtNome.Text.Trim();
        string CITTA = txtCitta.Text.Trim();


        // controllo che tutti i campi sono pieni

        if (
            String.IsNullOrEmpty(PWD) ||
            String.IsNullOrEmpty(PWD2) ||
            String.IsNullOrEmpty(COGNOME) ||
            String.IsNullOrEmpty(NOME) ||
            String.IsNullOrEmpty(CITTA))
        {
            lblMessaggio.Text = "Dati non validi";
            return;
        }

        // se c'è qualcosa nelle due password, se si controllare se coincidono

       
        
            if (PWD != PWD2)
            {
                lblMessaggio.Text = "Password non coincidenti";
                return;
            }
        

        // la connessione

        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = "Data Source = DESKTOP-0E2GJI9\\SQLEXPRESS; Initial Catalog=AUTOSALONI; Integrated Security=true";

        SqlCommand cmd = new SqlCommand();

        cmd.CommandType = CommandType.Text;
        cmd.Connection = conn;

        // query di selezione
        if (!String.IsNullOrEmpty(PWD) && !String.IsNullOrEmpty(PWD2))
        {
            cmd.CommandText = "update UTENTI set PWD = '"+PWD+"',COGNOME = '"+COGNOME+"', NOME = '"+NOME+"', CITTA = '"+CITTA+"' where USR = '"+USR+"'";
        } else
        {
            cmd.CommandText = "update UTENTI set COGNOME = '"+COGNOME+"', NOME = '"+NOME+"', CITTA = '"+CITTA+"' where USR = '"+USR+"'";
        }

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

        // modifico i dati
        // confermo la modifica

        lblMessaggio.Text = "Dati modificati";
    }
}