using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CaricaDati();
        }
    }


    protected void CaricaDati()
    {
        STATISTICHE st = new STATISTICHE();
        griglia_2025.DataSource = st.Griglia2025();
        griglia_2025.DataBind();

        griglia_2024.DataSource = st.Griglia2024();
        griglia_2024.DataBind();


        DataTable dt = new DataTable();
        dt = st.SaldoTotale2025();
        txtCosti2025.Text = dt.Rows[0]["Costi"].ToString();
        txtRicavi2025.Text = dt.Rows[0]["Ricavi"].ToString();
        txtSaldoTotale2025.Text = dt.Rows[0]["SaldoTotale"].ToString();

        DataTable DT = new DataTable();
        DT = st.SaldoTotale2024();
        txtCosti2024.Text = DT.Rows[0]["Costi"].ToString();
        txtRicavi2024.Text = DT.Rows[0]["Ricavi"].ToString();
        txtSaldoTotale2024.Text = DT.Rows[0]["SaldoTotale"].ToString();
    }

    protected void griglia_2025_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //tolgo visibiltà a k_auto
        e.Row.Cells[13].Visible = false;
    }

    protected void griglia_2024_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //tolgo visibiltà a k_auto
        e.Row.Cells[13].Visible = false;
    }
}

