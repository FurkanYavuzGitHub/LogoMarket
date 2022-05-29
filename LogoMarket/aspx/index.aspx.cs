using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uyeadsoyad"] == null)
        {
            Label1.Text = "Hoşgeldin Ziyaretçi";
            profilayartable.Visible = false;
            kayitolimg.Visible = true;
        }
        else
        {
            Label1.Text = " Hoşgeldin  " + Session["uyeadsoyad"];
            profilayartable.Visible = true;
            kayitolimg.Visible = false;

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        UyelerVeBilgileri uye = new UyelerVeBilgileriDao().uyegiriskontrol(kuladitxt.Text, sifretxt.Text);
        if (uye.Uyeadsoyad == null) Label1.Text = "Kullanıcı Adı Veya Şifre Yanlış";
        else
        {
            Session["uyeadsoyad"] = uye.Uyeadsoyad;
            Session["uyeid"] = uye.Uyeid;
            Label1.Text = "Tekrardan Hoşgeldin " + uye.Uyeadsoyad + " :) ";
            profilayartable.Visible = true;
            kayitolimg.Visible = false;
            if (Session["uyeadsoyad"] == null)
            {
                kayitolimg.Visible = true;
            }
        }
    }
    protected void guvenlicikisimgbutton(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Session.Abandon();
        Response.Redirect("index.aspx");
    }
}