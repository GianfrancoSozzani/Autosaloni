using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        string NOMESALONE = txtNome_Salone.Text.Trim();
        string INDIRIZZO = txtIndirizzo.Text.Trim();
        string CAP = txtCap.Text;
        string CITTA = txtCitta.Text.Trim();
        string PROVINCIA = txtProvincia.Text;

        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = "Data Source = DESKTOP-0E2GJI9\\SQLEXPRESS; Initial Catalog=AUTOSALONI; Integrated Security=true";

        SqlCommand cmd = new SqlCommand();

        // query di selezione

        cmd.CommandText = "Select count(*) as [CONTROLLO] from SALONI where NOME_SALONE = '" + NOMESALONE + "' AND CITTA = '" + CITTA + "'";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = conn;

        SqlDataAdapter DA = new SqlDataAdapter();
        DA.SelectCommand = cmd;

        DataTable DT = new DataTable();
        DA.Fill(DT);

        // controllo utente non registrato

        if ((int)DT.Rows[0]["CONTROLLO"] == 1)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati già esistenti');", true);
            return;
        }

        //salvo i dati

        cmd.CommandText = "insert into SALONI values ('" + NOMESALONE+ "','" + INDIRIZZO + "','" + CAP + "','" + CITTA + "','" + PROVINCIA + "')";
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        griglia.DataBind();

        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Salone Aggiunto');", true);


        txtNome_Salone.Text = "";
        txtIndirizzo.Text = "";
        txtCap.Text = "";
        txtCitta.Text = "";
        txtProvincia.Text = "";


    }
}