using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class index : System.Web.UI.Page
{
    ArrayList logolar = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {


        if (Page.IsPostBack == false)
        {
            if (Session["uyeid"] != null)
            {
                profilayartable.Visible = true;
            }
         
          logolar = new YapilanLogolardao().tumlogolarigetir();
            yaz();
        }
    }
       public void yaz()
    {
        foreach (YapilanLogolar gelenlogo in logolar)
        {
            TableRow satir = new TableRow();
            for (int i = 0; i < 60; i++)
            {
                TableCell hucre = new TableCell();
                hucre.HorizontalAlign = HorizontalAlign.Center;
                satir.Cells.Add(hucre);
                i++;
            }

            Image logofoto = new Image();
            logofoto.ImageUrl = "logolar/" + gelenlogo.Logourl;
            logofoto.Height = 80;
            logofoto.Width = 80;
            satir.Cells[0].Controls.Add(logofoto);
            satir.Cells[1].Text = gelenlogo.Logoaciklama;
            satir.Cells[2].Text = gelenlogo.Olusturankisi;
            satir.Cells[3].Text = gelenlogo.Teklifedenkisi;
            satir.Cells[4].Text = gelenlogo.Logofiyati.ToString();
            Button satinal = new Button();
            satinal.Text = "SATIN AL";
            satinal.PostBackUrl = "hata.aspx?hatasayi=" + 1;
            satir.Cells[5].Controls.Add(satinal);
            logolartable.Rows.Add(satir);
        }
    }

    protected void guvenlicikisimgbutton(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Session.Abandon();
        Response.Redirect("index.aspx");
    }
}
 