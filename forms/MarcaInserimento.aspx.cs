using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        // controlli formali
        if (String.IsNullOrEmpty(txtMarca.Text))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati non validi');", true);
            return;
        }

        // connessione al database
        // SqlConnection conn = new SqlConnection();
        // conn.ConnectionString = "Data Source = DESKTOP-0E2GJI9\\SQLEXPRESS; Initial Catalog=AUTOSALONI; Integrated Security=true";



        // SqlCommand cmd = new SqlCommand();
        // query di selezione
        // interrompo la stringa inserisco variabile c#

        DB db = new DB();
        db.query = "ControlloMarca";
        db.cmd.Parameters.AddWithValue("@marca", txtMarca.Text);

        
        // cmd.CommandType = CommandType.Text;
        // cmd.Connection = conn;

        // SqlDataAdapter DA = new SqlDataAdapter();
        // DA.SelectCommand = cmd;

        DataTable DT = new DataTable();
        DT = db.SQLselect();

       

        if ((int)DT.Rows[0]["CONTROLLO"] == 1)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati non validi');", true);
            return;


        }

        DB db2 = new DB();
        db2.query = "InserimentoMarca";
        db2.cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
        db2.SQLcommand();

        // cmd.CommandText = "insert into MARCHE values ('" + txtMarca.Text + "')";
        // conn.Open();
        // cmd.ExecuteNonQuery();
        // conn.Close();
        griglia.DataBind();
    }
}