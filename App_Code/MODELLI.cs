using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
/// <summary>
/// Classe MODELLI sulla base della tabella SQL 
/// </summary>

public class MODELLI
{
    public int K_Modello;
    public string Modello;
    public int K_Marca;
    public MODELLI()
    {

    }
    /// <summary>
    /// restituisce sotto forma di DataTable la lista dei modelli presenti in db
    /// </summary>
    //lista
    public DataTable SelectAll()
    {
        DB db = new DB();
        db.query = "MODELLI_SelectAll";
        return db.SQLselect();
    }

    //seleziona per  modello e chiave marca
    /// <summary>
    /// indentifica se il modello che si prova ad inserire (ex-novo) è già prsente nel db
    /// </summary>
    public DataTable SelezionaModello()
    {
        DB db = new DB();
        db.query = "MODELLI_SelezionaModello";
        db.cmd.Parameters.AddWithValue("@modello", Modello);
        db.cmd.Parameters.AddWithValue("@marca", K_Marca);
        return db.SQLselect();
    }


    //inserimento

    /// <summary>
    /// permette di inserire il modello in db
    /// </summary>
    public void Inserimento()
    {
        DB db = new DB();
        db.query = "MODELLI_Inserimento";
        db.cmd.Parameters.AddWithValue("@modello", Modello);
        db.cmd.Parameters.AddWithValue("@marca", K_Marca);
        db.SQLCommand();
    }

    //seleziona per chiave
    public DataTable SelezionaChiave()
    {
        DB db = new DB();
        db.query = "MODELLI_SelezionaChiave";
        db.cmd.Parameters.AddWithValue("@chiave", K_Modello);
        return db.SQLselect();
    }

    //modifica
    public void Modifica()
    {
        DB db = new DB();
        db.query = "MODELLI_Update";
        db.cmd.Parameters.AddWithValue("@chiave", K_Modello);
        db.cmd.Parameters.AddWithValue("@marca", K_Marca);
        db.cmd.Parameters.AddWithValue("@modello", Modello);
        db.SQLCommand();
    }

    public DataTable CheckRedundantRecords()
    {
        DB db = new DB();
        db.query = "MODELLI_CheckRedundantRecords";
        db.cmd.Parameters.AddWithValue("@chiave", K_Modello);
        db.cmd.Parameters.AddWithValue("@marca", K_Marca);
        db.cmd.Parameters.AddWithValue("@modello", Modello);
        return db.SQLselect();
    }
}