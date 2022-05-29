using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

/// <summary>
/// Summary description for YapilanLogolardao
/// </summary>
public class YapilanLogolardao
{
    SqlConnection bag = new Baglanti().baglantiyagec();
    SqlCommand komut;

    public int logokaydet(int uyeid,String logoaaciklama, String olusturankisi, String teklifedenkisi,int logofiyati,String logourl)
    {
        bag.Open();
        komut = new SqlCommand
 ("insert into YapilanLogolar (uyeid,logoaciklama,olusturankisi,teklifedenkisi,logofiyati,logourl) values (" + uyeid + ",'" + 
  logoaaciklama + "','" + olusturankisi + "','" + teklifedenkisi + "'," + logofiyati + ",'" + logourl + "')", bag);
        int sayi = komut.ExecuteNonQuery();
       

        bag.Close();
        return sayi;
    }
    public ArrayList tumlogolarigetir()
    {
        ArrayList logolar = new ArrayList();
        bag.Open();
        SqlCommand komut;
        komut = new SqlCommand("select * from YapilanLogolar", bag);
        SqlDataReader oku = komut.ExecuteReader();
        while (oku.Read())
        {
            YapilanLogolar yenilogo = new YapilanLogolar();
            yenilogo.Logoid = Convert.ToInt32(oku["logoid"]);
            yenilogo.Logourl = oku["logourl"].ToString();
            yenilogo.Olusturankisi = oku["olusturankisi"].ToString();
            yenilogo.Teklifedenkisi = oku["teklifedenkisi"].ToString();
            yenilogo.Logofiyati = Convert.ToInt32(oku["logofiyati"]);
            yenilogo.Logoaciklama = oku["logoaciklama"].ToString();
            logolar.Add(yenilogo);
        }
        bag.Close();
        return logolar;
    }
    public ArrayList logosayisigetir()
    {
        ArrayList logosayilari = new ArrayList();
        bag.Open();
        SqlCommand komut;
        komut = new SqlCommand("select * from YapilanLogolar where uyelogosayisi", bag);
        SqlDataReader oku = komut.ExecuteReader();
        bag.Close();
        return logosayilari;
    }
	public YapilanLogolardao()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}