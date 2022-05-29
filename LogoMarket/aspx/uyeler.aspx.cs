using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class index : System.Web.UI.Page
{
    ArrayList uyeler = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {


        if (Page.IsPostBack == false)
        {
            if (Session["uyeid"] != null)
            {
                profilayartable.Visible = true;
            }
          uyeler = new UyelerVeBilgileriDao().tumuyelerigetir();
            yaz();
        }
    }
       public void yaz()
    {
        foreach (UyelerVeBilgileri gelenuye in uyeler)
        {
            TableRow satir = new TableRow();
            for (int i = 0; i < 50; i++)
            {
                TableCell hucre = new TableCell();
                hucre.HorizontalAlign = HorizontalAlign.Center;
                satir.Cells.Add(hucre);
                i++;
            }
            satir.Cells[0].Text = gelenuye.Uyeadsoyad;
            satir.Cells[1].Text = gelenuye.Logosayisi.ToString();
            satir.Cells[2].Text = gelenuye.Teklifsayisi.ToString();
            uyelertable.Rows.Add(satir);
        }
    }

    protected void guvenlicikisimgbutton(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Session.Abandon();
        Response.Redirect("index.aspx");
    }
}
 