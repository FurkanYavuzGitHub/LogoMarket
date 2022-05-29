using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Sehirler
/// </summary>
public class Sehirler
{
    byte sehirplaka;

    public byte Sehirplaka
    {
        get { return sehirplaka; }
        set { sehirplaka = value; }
    }
    String sehiradi;

    public String Sehiradi
    {
        get { return sehiradi; }
        set { sehiradi = value; }
    }
	public Sehirler()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}