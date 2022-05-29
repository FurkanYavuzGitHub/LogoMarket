using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class kayitol : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            ArrayList sehirlistesi = new ArrayList();
            sehirlistesi = new Sehirlerdao().tumsehirlerigetir();
            int i = 1;
            foreach (Sehirler gelensehir in sehirlistesi)
            {

                sehirdl.Items.Add(gelensehir.Sehiradi);
                sehirdl.Items[i].Value = gelensehir.Sehirplaka.ToString();
                i++;
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid == true)
        {
            int uyecinsiyet = 0;
            if (bayrbn.Checked == true) uyecinsiyet = -1;
            {
                int sayi = new UyelerVeBilgileriDao().uyekaydet(kuladitxt.Text, sifretxt.Text, advesoyadtxt.Text, dogumtarihitxt.Text, Convert.ToInt32(uyecinsiyet), Convert.ToInt32(sehirdl.SelectedValue),
                emailtxt.Text);
                if (sayi != 0) Response.Redirect("index.aspx");
                else Label1.Text = "Kayıt Başarısız . Tekrar Deneyiniz.";
                }
        }
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (bayrbn.Checked == false && bayanrbn.Checked == false)
        {
            args.IsValid = false;
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = true;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        
        dogumtarihitxt.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = false;
    }
}