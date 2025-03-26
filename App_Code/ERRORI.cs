using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class ERRORI
{
    public string errore;
    public ERRORI()
    {
      
    }

    //errori
    public void Errori_Insert()
    {
        DB db = new DB();
        db.query = "LOG_ERRORI_Insert";
        db.cmd.Parameters.AddWithValue("@ip", System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"]);
        db.cmd.Parameters.AddWithValue("@errore", errore);
        db.SQLCommand();
    }
}