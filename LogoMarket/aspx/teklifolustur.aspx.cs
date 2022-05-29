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
            teklifedenkisitxt.Text = Session["uyeadsoyad"].ToString();
        }
    }
     protected void guvenlicikisimgbutton(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Session.Abandon();
        Response.Redirect("index.aspx");
    }
     protected void Button1_Click(object sender, EventArgs e)
     {
         try
         {
             int s = new Tekliflerdao().teklifkaydet(Convert.ToInt32(Session["uyeid"]), teklifedenkisitxt.Text, aciklamatxt.Text, Convert.ToInt32(tekliffiyattxt.Text));
             label1.Text = "Yükleme Başarılı";
         }
         catch
         {
             label1.Text = "Lütfen FİYAT Kutucuğuna Sayı Giriniz";
         }
         }
     protected void Button2_Click(object sender, EventArgs e)
     {
         Response.Redirect("teklifolustur.aspx");
     }
}
     