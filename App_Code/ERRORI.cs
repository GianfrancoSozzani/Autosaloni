using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ERRORI
/// </summary>
public class ERRORI
{
    public string iperrore;
    public string errore;
    public ERRORI()
    {
      
    }

    //errori
    public void Errori_Insert()
    {
        DB db = new DB();
        db.query = "LOG_ERRORI_Insert";
        db.cmd.Parameters.AddWithValue("@ip", iperrore);
        db.cmd.Parameters.AddWithValue("@errore", errore);
        db.SQLCommand();
    }
}