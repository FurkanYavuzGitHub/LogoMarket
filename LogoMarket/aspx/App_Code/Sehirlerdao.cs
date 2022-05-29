using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Sehirlerdao
/// </summary>
public class Sehirlerdao
    {
    SqlConnection bag = new Baglanti().baglantiyagec();

    public ArrayList tumsehirlerigetir()
    { 
        ArrayList sehirtorbasi = new ArrayList();
       
        bag.Open();
 SqlCommand komut = new SqlCommand("select * from Sehirler order by sehiradi asc", bag);
 SqlDataReader oku = komut.ExecuteReader();
 while (oku.Read() == true)
 {
     Sehirler yenisehir = new Sehirler();
     yenisehir.Sehirplaka =Convert.ToByte( oku["sehirplaka"]);
     yenisehir.Sehiradi = oku["sehiradi"].ToString();
     sehirtorbasi.Add(yenisehir);
 }

 oku.Close();
 bag.Close();
 return sehirtorbasi;
    }

    public int sehirkaydet(byte sehirplaka, String sehiradi)
    {
        int sayi = 0;
        try
        {
           
            SqlCommand komut = new SqlCommand();
            bag.Open();
            komut.Connection = bag;
     komut.CommandText = "insert into Sehirler (sehirplaka,sehiradi) values (" + sehirplaka + ",'" + sehiradi + "')";
            sayi = komut.ExecuteNonQuery();
            bag.Close();
        }
        catch (SqlException)
        {
            sayi = -1;
        }
      return sayi;
    }
	public Sehirlerdao()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}