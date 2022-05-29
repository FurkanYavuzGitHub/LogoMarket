using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Baglanti
/// </summary>
public class Baglanti
{
    public SqlConnection baglantiyagec()
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\logomarket.mdf;Integrated Security=True;User Instance=True");
        return baglanti;
    }
	public Baglanti()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}