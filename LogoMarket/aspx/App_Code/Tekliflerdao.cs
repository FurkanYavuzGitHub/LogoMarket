using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
/// <summary>
/// Summary description for Tekliflerdao
/// </summary>
public class Tekliflerdao
{
    SqlConnection bag = new Baglanti().baglantiyagec();
    SqlCommand komut;

    public int teklifkaydet(int uyeid,String teklifedenkisi,String teklifaciklamasi, int tekliffiyati)
    {
        bag.Open();
        komut = new SqlCommand
 ("insert into Teklifler (uyeid,teklifedenkisi,teklifaciklamasi,tekliffiyati) values (" + uyeid + ",'" + teklifedenkisi +
 "','" +teklifaciklamasi+ "'," + tekliffiyati + ")", bag);
        int sayi = komut.ExecuteNonQuery();

        bag.Close();
        return sayi;
    }

    public ArrayList tumtekliflerigetir()
    {
        ArrayList teklifler = new ArrayList();
        bag.Open();
        SqlCommand komut;
        komut = new SqlCommand("select * from Teklifler", bag);
        SqlDataReader oku = komut.ExecuteReader();
        while (oku.Read())
        {
            Teklifler yeniteklif = new Teklifler();
            yeniteklif.Teklifno = Convert.ToInt32(oku["teklifno"]);
            yeniteklif.Teklifedenkisi = oku["teklifedenkisi"].ToString();
            yeniteklif.Teklifaciklamasi = oku["teklifaciklamasi"].ToString();
            yeniteklif.Tekliffiyati = Convert.ToInt32(oku["tekliffiyati"]);
            teklifler.Add(yeniteklif);
        }
        bag.Close();
        return teklifler;
    }
	public Tekliflerdao()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}