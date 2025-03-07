using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Forms_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        string codicescelto = ddlMarche.SelectedValue;
        string marcascelta = ddlMarche.Text;

        // controlli formali
        if (String.IsNullOrEmpty(txtModello.Text))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati non validi');", true);
            return;
        }

        // connessione al database
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = "Data Source = DESKTOP-0E2GJI9\\SQLEXPRESS; Initial Catalog=AUTOSALONI; Integrated Security=true";



        SqlCommand cmd = new SqlCommand();
        // query di selezione
        // interrompo la stringa inserisco variabile c#
        cmd.CommandText = "select count (*) as [CONTROLLO] from MODELLI where MODELLO ='" + txtModello.Text + "' AND K_Marca = '"+marcascelta+"'";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = conn;

        SqlDataAdapter DA = new SqlDataAdapter();
        DA.SelectCommand = cmd;

        DataTable DT = new DataTable();

        DA.Fill(DT);

        if ((int)DT.Rows[0]["CONTROLLO"] == 1)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati non validi');", true);
            return;


        }

        cmd.CommandText = "insert into MODELLI values ('" + txtModello.Text + "','"+marcascelta+"')";
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        griglia.DataBind();
    }
}
