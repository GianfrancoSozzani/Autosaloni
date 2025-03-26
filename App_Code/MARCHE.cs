using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class MARCHE
{
    public int K_Marca;
    public string Marca;
    public MARCHE()
    {

    }

    //inserimento
    public void Inserimento()
    {
        DB db = new DB();
        db.query = "MARCHE_InserimentoMarca";
        db.cmd.Parameters.AddWithValue("@marca", Marca);
        db.SQLCommand();
    }
    //modifica
    public void Modifica()
    {
        DB db = new DB();
        db.query = "MARCHE_Update";
        db.cmd.Parameters.AddWithValue("@chiave", K_Marca);
        db.cmd.Parameters.AddWithValue("@marca", Marca);
        db.SQLCommand();

    }

    //lista
    public DataTable SelectAll()
    {
        DB db = new DB();
        db.query = "MARCHE_SelectAll";
        return db.SQLselect();

    }
    //seleziona marca
    public DataTable SelezionaMarca()
    {
        DB db = new DB();
        db.query = "MARCHE_SelezionaMarca";
        db.cmd.Parameters.AddWithValue("@marca", Marca);
        return db.SQLselect();
    }

    //seleziona chiave
    public DataTable SelezionaChiave()
    {
        DB db = new DB();
        db.query = "MARCHE_Selezionachiave";
        db.cmd.Parameters.AddWithValue("@chiave", K_Marca);
        return db.SQLselect();
    }




    //marche_CheckRedundantRecords

    public DataTable CheckRedundantRecords()
    {
        DB db = new DB();
        db.query = "MARCHE_CheckRedundantRecords";
        db.cmd.Parameters.AddWithValue("@marca", Marca);
        db.cmd.Parameters.AddWithValue("@chiave", K_Marca);
        return db.SQLselect();
    }



}