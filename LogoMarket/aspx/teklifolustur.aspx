<%@ Page Title="" Language="C#" MasterPageFile="~/Ziyaretci.master" AutoEventWireup="true" CodeFile="teklifolustur.aspx.cs" Inherits="logoolustur" %>

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
    <table align="center" style="width: 75%;">
        <tr>
            <td colspan="2">
                <hr />
            </td>
        </tr>
        <tr>
            <td style="width: 793px; height: 74px;" align="center">
                AÇIKLAMA</td>
            <td align="center" rowspan="2" style="height: 74px">
                FİYATI<br />
                <hr />
                <asp:TextBox ID="tekliffiyattxt" runat="server"></asp:TextBox>
                <hr />
            </td>
        </tr>
        <tr>
            <td style="width: 793px; height: 74px;">
                <asp:TextBox ID="aciklamatxt" runat="server" Height="141px" 
                    TextMode="MultiLine" Width="787px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 26px; width: 793px">
                &nbsp;</td>
            <td align="center" rowspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                TEKLİFEDEN KİŞİ</td>
        </tr>
        <tr>
            <td align="center" style="width: 793px">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" style="height: 9px; width: 793px">
                <hr />
                <asp:Button ID="Button1" runat="server" Text="YÜKLE" onclick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="TEMİZLE" 
                    onclick="Button2_Click" />
                <hr />
            </td>
            <td align="center" style="height: 9px">
                <hr />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="teklifedenkisitxt" runat="server" Text="kisi"></asp:Label>
                <hr />
            </td>
        </tr>
        <tr>
            <td align="center" style="height: 9px; width: 793px">
                <asp:Label ID="label1" runat="server"></asp:Label>
            </td>
            <td align="center" style="height: 9px">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <hr />
            </td>
        </tr>
    </table>
</asp:Content>

