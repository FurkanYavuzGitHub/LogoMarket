using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Collections;

public partial class index : System.Web.UI.Page
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
            int uyeid = Convert.ToInt32(Session["uyeid"]); 
            UyelerVeBilgileri uye = new UyelerVeBilgileriDao().tekuyegetir(uyeid);
            kuladitxt.Text = uye.Uyekuladi;
            sifretxt.Text = uye.Uyesifre.ToString();
            advesoyadtxt.Text = uye.Uyeadsoyad;
            dogumtarihitxt.Text = uye.Uyedt.ToShortDateString();
            emailtxt.Text = uye.Uyeemail;
            if (uye.Uyecinsiyet == true) bayanrbn.Checked = true;
            else bayrbn.Checked = true;

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
    protected void guvenlicikisimgbutton(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Session.Abandon();
        Response.Redirect("index.aspx");
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid == true)
        {
            int cinsiyet = 0;
            if (bayanrbn.Checked == true) cinsiyet = -1;
            int sayi = new UyelerVeBilgileriDao().uyedegistir(kuladitxt.Text, sifretxt.Text, advesoyadtxt.Text, dogumtarihitxt.Text, cinsiyet,
Convert.ToInt32(sehirdl.SelectedValue), emailtxt.Text,Convert.ToInt32(telnotxt.Text),Convert.ToInt32(Session["uyeid"]));
            if (sayi != 0)
            {
                Label1.Text="Kayıt değiştirildi";
                Session["uyeadsoyad"] = advesoyadtxt.Text;
            }
            else Label1.Text="kayıt değiştirilemiyor";
        }
    }
}