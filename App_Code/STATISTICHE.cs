using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class STATISTICHE
{
    public STATISTICHE()
    {

    }

    public DataTable Griglia2025()
    {
        DB dB = new DB();
        dB.query = "AUTOMOBILI_StatisticheAutomobile2025";
        return dB.SQLselect();
    }

    public DataTable Griglia2024()
    {
        DB dB = new DB();
        dB.query = "AUTOMOBILI_StatisticheAutomobile2024";
        return dB.SQLselect();
    }
}