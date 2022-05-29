using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UyelerVeBilgileri
/// </summary>
public class UyelerVeBilgileri
{
    int uyeid;

    public int Uyeid
    {
        get { return uyeid; }
        set { uyeid = value; }
    }
    String uyekuladi;

    public String Uyekuladi
    {
        get { return uyekuladi; }
        set { uyekuladi = value; }
    }
    String uyesifre;

    public String Uyesifre
    {
        get { return uyesifre; }
        set { uyesifre = value; }
    }
    String uyeadsoyad;

    public String Uyeadsoyad
    {
        get { return uyeadsoyad; }
        set { uyeadsoyad = value; }
    }
    DateTime uyedt;

    public DateTime Uyedt
    {
        get { return uyedt; }
        set { uyedt = value; }
    }
    String uyeemail;

    public String Uyeemail
    {
        get { return uyeemail; }
        set { uyeemail = value; }
    }
    int uyetelno;

    public int Uyetelno
    {
        get { return uyetelno; }
        set { uyetelno = value; }
    }
    Boolean uyecinsiyet;

    public Boolean Uyecinsiyet
    {
        get { return uyecinsiyet; }
        set { uyecinsiyet = value; }
    }
    String uyesehir;

    public String Uyesehir
    {
        get { return uyesehir; }
        set { uyesehir = value; }
    }

    int logosayisi;

    public int Logosayisi
    {
        get { return logosayisi; }
        set { logosayisi = value; }
    }
    int teklifsayisi;

    public int Teklifsayisi
    {
        get { return teklifsayisi; }
        set { teklifsayisi = value; }
    }
	public UyelerVeBilgileri()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}