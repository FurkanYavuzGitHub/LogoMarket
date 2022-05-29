using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.IO;

public partial class logoolustur : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uyeadsoyad"] == null)
        {
            Response.Redirect("index.aspx");
            profilayartable.Visible = false;
        }
        else
        {
            profilayartable.Visible = true;
            olusturankisilbl.Text = Session["uyeadsoyad"].ToString();
        }
        
    }
    protected void dosyayukle(object sender, EventArgs e)
    {

        logoyuvasiimg.ImageUrl = "logolar/" + logoyükleup.FileName;
    
    }
     protected void guvenlicikisimgbutton(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Session.Abandon();
        Response.Redirect("index.aspx");
    }
     protected void Button1_Click(object sender, EventArgs e)
     { 
         int sayi = resimekle();

         try
         {
             if (sayi != 0)
             {
                 olusturankisilbl.Text = Session["uyeadsoyad"].ToString();
                 int s = new YapilanLogolardao().logokaydet(Convert.ToInt32(Session["uyeid"]), aciklamatxt.Text, olusturankisilbl.Text, teklifedenkisitxt.Text, Convert.ToInt32(logofiyattxt.Text), logoyükleup.FileName);
                 
                 if (s == 1) mesajlbl.Text = "Logo Yüklendi";
                 else mesajlbl.Text = "Logo Yüklenemedi Tekrar Deneyiniz";
             }
         }
         catch
         {
             mesajlbl.Text = "Logo Yükleme Başarısız.Lütfen Gerekli Bilgileri Doldurunuz.";
         }
     }
 public int resimekle()
    {
        int sayi = 0;
        try
        {
            String uzanti = Path.GetExtension(logoyükleup.FileName);
            if (uzanti.Equals(".jpg") || uzanti.Equals(".png") || uzanti.Equals(".gif"))
            {
                if (logoyükleup.HasFile == true)
                {
                    logoyükleup.SaveAs(Server.MapPath("logolar/") + logoyükleup.FileName);
                   logoyuvasiimg.ImageUrl = "logolar/" + logoyükleup.FileName;
                    sayi = 1;
                }
                else
                {
                    mesajlbl.Text = "Seçtiğiniz Dosya Yerinde Yok , Silinmiş";
                }
            }
            else
            {
                mesajlbl.Text = "Lütfen Resim Dosyası Seçiniz";
            }
        }
        catch (Exception)
        {
            sayi = 0;
        }
      return sayi;
    }
 protected void Button2_Click(object sender, EventArgs e)
 {
     Response.Redirect("logoolustur.aspx");
 }
}
     