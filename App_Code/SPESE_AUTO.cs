using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class SPESE_AUTO
{
    public int K_Spesa;
    public int K_Auto;
    public string Spesa;
    public decimal Importo;
    public SPESE_AUTO()
    {

    }

    public DataTable SPESE_AUTO_SelezionaAutomobile()
    {
        DB db = new DB();
        db.query = "SPESE_AUTO_SelezionaAutomobile";
        db.cmd.Parameters.AddWithValue("@chiave", K_Auto);
        return db.SQLselect();
    }
}