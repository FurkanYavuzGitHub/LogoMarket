using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Teklifler
/// </summary>
public class Teklifler
{
    int uyeid;

    public int Uyeid
    {
        get { return uyeid; }
        set { uyeid = value; }
    }

    int teklifno;

    public int Teklifno
    {
        get { return teklifno; }
        set { teklifno = value; }
    }

    String teklifedenkisi;

    public String Teklifedenkisi
    {
        get { return teklifedenkisi; }
        set { teklifedenkisi = value; }
    }
    String teklifaciklamasi;

    public String Teklifaciklamasi
    {
        get { return teklifaciklamasi; }
        set { teklifaciklamasi = value; }
    }
    double tekliffiyati;

    public double Tekliffiyati
    {
        get { return tekliffiyati; }
        set { tekliffiyati = value; }
    }
    String teklifyaniti;

    public String Teklifyaniti
    {
        get { return teklifyaniti; }
        set { teklifyaniti = value; }
    }

	public Teklifler()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}