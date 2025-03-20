using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class AUTOMOBILI
{
    public int K_Auto;
    public int K_Modello;
    public string Stato;
    public DateTime Data_Acquisto;
    public int K_Cliente_Acquisto;
    public decimal Prezzo_Acquisto;
    public int K_Salone;
    public int K_Responsabile;
    public int K_Venditore;
    public string Alimentazione;
    public string Colore;
    public int KM;
    public string Cambio;
    public string Targa;
    public string Telaio;
    public string Condizione;
    public string Optional;
    public decimal Prezzo_Offerto;
    public decimal Prezzo_Vendita;
    public DateTime Data_Vendita;
    public int K_Cliente_Vendita;
    public int K_Marca;
   
    public AUTOMOBILI()
    {
        
    }
    
    //lista
    public DataTable SelectAll()
    {
        DB db = new DB();
        db.query = "AUTOMOBILI_SelectAll";
        return db.SQLselect();
    }

    public DataTable AUTOMOBILI_ddlModelli()
    {
        DB db = new DB();
        db.query = "AUTOMOBILI_ddlModelli";
        db.cmd.Parameters.AddWithValue("@marca", K_Marca);
        return db.SQLselect();
    }
}