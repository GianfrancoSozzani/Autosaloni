using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.DynamicData;

public partial class Registrati : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        string USR = txtUSR.Text.Trim();
        string PWD = txtPWD.Text;
        string PWD2 = txtPWD2.Text;
        string COGNOME = txtCognome.Text.Trim();
        string NOME = txtNome.Text.Trim();
        string CITTA = txtCitta.Text.Trim();


        // controllo che tutti i campi sono pieni

        if (String.IsNullOrEmpty(USR) ||
            String.IsNullOrEmpty(PWD) ||
            String.IsNullOrEmpty(PWD2) ||
            String.IsNullOrEmpty(COGNOME) ||
            String.IsNullOrEmpty(NOME) ||
            String.IsNullOrEmpty(CITTA))
        {
            lblMessaggio.Text = "Dati non validi";
            return;
        }

        // controllo password

        if (PWD != PWD2)
        {
            lblMessaggio.Text = "Password non coincidenti";
            return;
        }

        //SqlConnection conn = new SqlConnection();
        //conn.ConnectionString = "Data Source = DESKTOP-0E2GJI9\\SQLEXPRESS; Initial Catalog=AUTOSALONI; Integrated Security=true";

        //SqlCommand cmd = new SqlCommand();

        // query di selezione
        DB db = new DB();
        db.query = "ControlloRegistrazione";
        db.cmd.Parameters.AddWithValue("@usr", USR);
        

        //cmd.CommandType = CommandType.Text;
        //cmd.Connection = conn;

        //SqlDataAdapter DA = new SqlDataAdapter();
        //DA.SelectCommand = cmd;

        DataTable DT = new DataTable();
        DT = db.SQLselect();

        // controllo utente non registrato

        if ((int)DT.Rows[0]["QUANTI"] == 1)
        {
            lblMessaggio.Text = "Utente già registrato";
            return;
        }

        // salvo i dati
        DB db2 = new DB();
        db2.query = "RegistrazioneUtente";
        db2.cmd.Parameters.AddWithValue("@usr", USR);
        db2.cmd.Parameters.AddWithValue("@pwd", PWD);
        db2.cmd.Parameters.AddWithValue("@cognome", COGNOME);
        db2.cmd.Parameters.AddWithValue("@nome", NOME);
        db2.cmd.Parameters.AddWithValue("@citta", CITTA);

        db2.SQLcommand();


        //cmd.CommandText = "insert into UTENTI values ('"+USR+"','"+PWD+"','"+COGNOME+"','"+NOME+"','"+CITTA+"')";
        //conn.Open();
        //cmd.ExecuteNonQuery();
        //conn.Close();

        lblMessaggio.Text = "Utente registrato";
        return;
    }
}

// ctrl + D; alt + freccia;