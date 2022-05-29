using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections;

/// <summary>
/// Summary description for UyelerVeBilgileriDao
/// </summary>
public class UyelerVeBilgileriDao
{
    ArrayList uyelistesi = new ArrayList();
    SqlConnection bag = new Baglanti().baglantiyagec();
    SqlCommand komut;
    SqlDataReader oku;
    public ArrayList tumuyelerigetir()
    {
        bag.Open();
        komut = new SqlCommand("select * from UyelerVeBilgileri", bag);
        yaz();
        return uyelistesi;
    }
    public void yaz()
    {
        oku = komut.ExecuteReader();
        while (oku.Read() == true)
        {
            UyelerVeBilgileri yeniuye = new UyelerVeBilgileri();
            yeniuye.Uyeadsoyad = oku["uyeadsoyad"].ToString();
            uyelistesi.Add(yeniuye);
        }//while
        oku.Close();
        bag.Close();

    }

    public int uyekaydet
(String uyekuladi, String uyesifre, String uyeadsoyad,
String uyedogtar, int uyecinsiyet,int uyesehir,String uyeemail)
    {
        int uyetelno = 0;
        int sayi = 0;
        bag.Open();
        komut = new SqlCommand();
        komut.Connection = bag;
        {
            komut.CommandText =
     "insert into UyelerVeBilgileri(uyekuladi,uyesifre,uyeadsoyad,uyedt,uyeemail,uyetelno,uyecinsiyet,uyesehir) values ('" +
     uyekuladi + "','" + uyesifre + "','" + uyeadsoyad + "',convert(datetime,'" + uyedogtar + "',103)," +
     "'" + uyeemail + "'," + uyetelno + "," + uyecinsiyet + "," + uyesehir + ")";
        }
        sayi = komut.ExecuteNonQuery();
        bag.Close();
        return sayi;

    }
    public UyelerVeBilgileri uyegiriskontrol(String uyekuladi, String uyesifre)
    {
        UyelerVeBilgileri uye = new UyelerVeBilgileri();
        try
        {
            bag.Open();
            komut = new SqlCommand("select * from UyelerVeBilgileri where uyekuladi='" + uyekuladi
                + "' and uyesifre='" + uyesifre + "'", bag);
            oku = komut.ExecuteReader();
            oku.Read();

            uye.Uyeadsoyad = oku["uyeadsoyad"].ToString();
            uye.Uyeid = Convert.ToInt32(oku["uyeid"]);
            bag.Close();

        }

        catch (Exception)
        {

        }
        return uye;
    }
    public UyelerVeBilgileri tekuyegetir(int uyeid)
    {
        bag.Open();
        komut = new SqlCommand("select * from UyelerVeBilgileri,Sehirler where UyelerVeBilgileri.uyesehir=Sehirler.sehirplaka and uyeid=" + uyeid, bag);
        oku = komut.ExecuteReader();
        oku.Read();
        UyelerVeBilgileri yeniuye = new UyelerVeBilgileri();
        yeniuye.Uyeid = Convert.ToInt32(oku["uyeid"]);
        yeniuye.Uyekuladi = oku["uyekuladi"].ToString();
        yeniuye.Uyesifre = oku["uyesifre"].ToString();
        yeniuye.Uyeadsoyad = oku["uyeadsoyad"].ToString();
        yeniuye.Uyedt = Convert.ToDateTime(oku["uyedt"]);
        yeniuye.Uyeemail = oku["uyeemail"].ToString();
        yeniuye.Uyetelno = Convert.ToInt32(oku["uyetelno"]);
        Sehirler s = new Sehirler();
        s.Sehiradi = oku["sehiradi"].ToString();
        s.Sehirplaka = Convert.ToByte(oku["sehirplaka"]);
        yeniuye.Uyesehir = s.ToString();
        oku.Close();
        bag.Close();
        return yeniuye;
    }
    public int uyedegistir
 (String uyekuladi, String sifre, String adsoyad,
  String dogtar, int cinsiyet,int sehir, String email,int telno,int uyeid)
    {
        int sayi = 0;
        bag.Open();
        komut = new SqlCommand();
        komut.Connection = bag;
        komut.CommandText = "update UyelerVeBilgileri set uyekuladi='" + uyekuladi + "',uyesifre='" + sifre
    + "',uyeadsoyad='" + adsoyad + "',uyedt=convert(datetime,'" + dogtar + "',103),uyecinsiyet="
    + cinsiyet +",uyeemail='" + email +"',uyetelno=" + telno + ",uyesehir=" + sehir
    + " where uyeid=" + uyeid;

        sayi = komut.ExecuteNonQuery();
        bag.Close();
        return sayi;
    }
	public UyelerVeBilgileriDao()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}