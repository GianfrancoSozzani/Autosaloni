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

    public DataTable DatiCliente()
    {
        DB db = new DB();
        db.query = "SPESE_AUTO_DatiCliente";
        db.cmd.Parameters.AddWithValue("@chiave", K_Auto);
        return db.SQLselect();
    }

    public DataTable SelezionaDatiAutomobile()
    {
        DB db = new DB();
        db.query = "SPESE_AUTO_SelezionaDatiAutomobile";
        db.cmd.Parameters.AddWithValue("@chiave", K_Auto);
        return db.SQLselect();
    }

    public void Inserimento()
    {
        DB db = new DB();
        db.query = "SPESE_AUTO_Inserimento";
        db.cmd.Parameters.AddWithValue("@chiave", K_Auto);
        db.cmd.Parameters.AddWithValue("@spesa", Spesa);
        db.cmd.Parameters.AddWithValue("@importo", Importo);
        db.SQLCommand();
    }

    //seleziona chiave
    public DataTable SelezionaSpesa()
    {
        DB db = new DB();
        db.query = "SPESE_AUTO_SelezionaSpesa";
        db.cmd.Parameters.AddWithValue("@chiave", K_Spesa);
        return db.SQLselect();
    }

    //modifica
    public void Modifica()
    {
        DB db = new DB();
        db.query = "SPESE_AUTO_Update";
        db.cmd.Parameters.AddWithValue("@chiave", K_Spesa);
        db.cmd.Parameters.AddWithValue("@spesa", Spesa);
        db.cmd.Parameters.AddWithValue("@importo", Importo);
        db.SQLCommand();
    }

}