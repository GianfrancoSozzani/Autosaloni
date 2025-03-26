using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public static class LOG
{
    //errori
    public static void Errori_Insert(string errore)
    {
        DB db = new DB();
        db.query = "LOG_ERRORI_Insert";
        db.cmd.Parameters.AddWithValue("@ip", System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"]);
        db.cmd.Parameters.AddWithValue("@errore", errore);
        db.SQLCommand();
    }

    //eventi

    public static void Eventi_Insert(string usr, string form, string evento)
    {
        DB db = new DB();
        db.query = "LOG_EVENTI_Insert";
        db.cmd.Parameters.AddWithValue("@usr", usr);
        db.cmd.Parameters.AddWithValue("@errore", form);
        db.cmd.Parameters.AddWithValue("@evento", evento);
        db.SQLCommand();
    }
}