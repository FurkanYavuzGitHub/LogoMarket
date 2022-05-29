using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class index : System.Web.UI.Page
{
    int hatasayi = 2;
    ArrayList teklifler = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {


        if (Page.IsPostBack == false)
        {
            if (Session["uyeid"] != null)
            {
                profilayartable.Visible = true;
            }
          teklifler = new  Tekliflerdao().tumtekliflerigetir();
            yaz();
        }
    }
       public void yaz()
    {
        foreach (Teklifler gelenteklif in teklifler)
        {
            TableRow satir = new TableRow();
            for (int i = 0; i < 50; i++)
            {
                TableCell hucre = new TableCell();
                hucre.HorizontalAlign = HorizontalAlign.Center;
                satir.Cells.Add(hucre);
                i++;
            }
            satir.Cells[0].Text = gelenteklif.Teklifedenkisi;
            satir.Cells[1].Text = gelenteklif.Teklifaciklamasi;
            satir.Cells[2].Text = gelenteklif.Tekliffiyati.ToString();
            Button yanitgonder = new Button();
            yanitgonder.Text = "YANIT GÖNDER";
            yanitgonder.PostBackUrl = "hata.aspx?hatasayi=" + hatasayi;
            satir.Cells[3].Controls.Add(yanitgonder);
            tekliflertable.Rows.Add(satir);
        }
    }

    protected void guvenlicikisimgbutton(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Session.Abandon();
        Response.Redirect("index.aspx");
    }
}
 