<%@ Page Title="" Language="C#" MasterPageFile="~/Ziyaretci.master" AutoEventWireup="true" CodeFile="uyeler.aspx.cs" Inherits="index" %>

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
    <asp:Table ID="uyelertable" runat="server" Height="50px" Width="1200px" 
    Font-Names="Courier New" Font-Overline="False" Font-Size="Larger" 
    Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Center"><hr />Adı Ve Soyadı<hr /></asp:TableCell>
            <asp:TableCell runat="server" HorizontalAlign="Center"><hr />Oluşturulan Logo Sayısı<hr /></asp:TableCell>
            <asp:TableCell runat="server" HorizontalAlign="Center"><hr />Oluşturulan Teklif Sayısı<hr /></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>

