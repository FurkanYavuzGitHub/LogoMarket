using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    int hatasayi;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uyeid"] != null)
        {
            Session["hatasayi"] = hatasayi;
            profilayartable.Visible = true;
            if (hatasayi == 1)
            {
                hatakutusu.ImageUrl = "img/hata.png";
            }
            if (hatasayi == 2)
            {
                hatakutusu.ImageUrl = "img/hata1.png";
            }
            if (hatasayi == 3)
            {
                hatakutusu.ImageUrl = "img/hata.png";
            }
        }
    }
    protected void guvenlicikisimgbutton(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Session.Abandon();
        Response.Redirect("index.aspx");
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }
}