<%@ Page Title="" Language="C#" MasterPageFile="~/Ziyaretci.master" AutoEventWireup="true" CodeFile="hata.aspx.cs" Inherits="index" %>

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
            <td colspan="3">
                <hr />
            </td>
        </tr>
        <tr>
            <td style="height: 23px">
            </td>
            <td style="height: 23px; width: 1309px">
            </td>
            <td style="height: 23px">
            </td>
        </tr>
        <tr>
            <td style="height: 23px">
                &nbsp;</td>
            <td align="center" style="height: 23px; width: 1309px">
                <asp:Image ID="hatakutusu" runat="server" />
            </td>
            <td style="height: 23px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 23px">
                &nbsp;</td>
            <td align="center" style="height: 23px; width: 1309px">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" 
                    Text="ANASAYFAYA DÖN" />
            </td>
            <td style="height: 23px">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <hr />
            </td>
        </tr>
    </table>
</asp:Content>

