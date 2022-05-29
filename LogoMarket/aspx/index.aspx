<%@ Page Title="" Language="C#" MasterPageFile="~/Ziyaretci.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Profilayar" Runat="Server">
<asp:Table ID="profilayartable" runat="server" Height="16px" Width="339px" 
          HorizontalAlign="Left" Visible="False">
          <asp:TableRow ID="TableRow1" runat="server">
              <asp:TableCell ID="TableCell1" runat="server"><li><a href="ayarlar.aspx">AYARLAR</a></li></asp:TableCell>
              <asp:TableCell ID="profilcikishucre" runat="server">
                  <asp:ImageButton ID="profilcikis" runat="server" ImageUrl="~/img/profilcikis.png" OnClick="guvenlicikisimgbutton" />
</asp:TableCell>
                     <asp:TableCell ID="logoolusturhucre" runat="server">
                  <a href="logoolustur.aspx"><asp:ImageButton ID="logoolusturimg" runat="server" ImageUrl="~/img/logoolustur.png" PostBackUrl="~/logoolustur.aspx"/>
</a></asp:TableCell>
                     <asp:TableCell ID="teklifolusturhucre" runat="server">
                  <a href="teklifolustur.aspx"><asp:ImageButton ID="teklifolusturimg" runat="server" ImageUrl="~/img/teklifolustur.png" PostBackUrl="~/teklifolustur.aspx" />
</a></asp:TableCell>
          </asp:TableRow>
      </asp:Table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="icerik" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td align="center" style="height: 23px; width: 493px">
                </td>
            <td style="width: 113px; height: 23px;" align="center">
                </td>
            <td style="width: 260px; height: 23px;" align="center">
                </td>
            <td align="center" style="height: 23px">
                </td>
        </tr>
        <tr>
            <td style="width: 493px">
                &nbsp;</td>
            <td style="width: 113px" align="center">
                Kullanıcı Adı :</td>
            <td style="width: 260px" align="center">
                <asp:TextBox ID="kuladitxt" runat="server"></asp:TextBox>
            </td>
            <td rowspan="2" align="left">
                <asp:ImageButton ID="kayitolimg" runat="server" DescriptionUrl="kayitol.aspx" 
                    ImageUrl="~/img/kayitol.png" PostBackUrl="kayitol.aspx" />
            </td>
        </tr>
        <tr>
            <td style="width: 493px">
                &nbsp;</td>
            <td style="width: 113px" align="center">
                Sifre :</td>
            <td style="width: 260px" align="center">
                <asp:TextBox ID="sifretxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 493px">
                &nbsp;</td>
            <td align="center" colspan="2">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="GİRİŞ" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 493px">
                &nbsp;</td>
            <td align="center" colspan="2">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Courier New" 
                    Font-Size="Large" ForeColor="#3366FF"></asp:Label>
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>

