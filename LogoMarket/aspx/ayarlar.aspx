<%@ Page Title="" Language="C#" MasterPageFile="~/Ziyaretci.master" AutoEventWireup="true" CodeFile="ayarlar.aspx.cs" Inherits="index" %>

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
            <td colspan="6" align="center">
                <hr />HESAP AYARI<hr />
            </td>
        </tr>
        <tr>
            <td style="width: 600px">
                &nbsp;</td>
            <td style="width: 131px">
                <br />Kullanıcı Adı :<br />
            </td>
            <td style="width: 256px">
                <br />
                <asp:TextBox ID="kuladitxt" runat="server"></asp:TextBox>
                <br />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="kuladitxt" ErrorMessage="Boş Geçmeyelim :)" 
                    ForeColor="#0066FF" ValidationGroup="x">*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 600px">
                &nbsp;</td>
            <td style="width: 131px">
                <br />Sifre :
                <br />
            </td>
            <td style="width: 256px">
                <br />
                <asp:TextBox ID="sifretxt" runat="server"></asp:TextBox>
                <br />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="sifretxt" ErrorMessage="Boş Geçmeyelim :)" 
                    ForeColor="#0066FF" ValidationGroup="x">*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 600px">
                &nbsp;</td>
            <td style="width: 131px">
                <br />Ad ve Soyad :<br />
            </td>
            <td style="width: 256px">
                <br />
                <asp:TextBox ID="advesoyadtxt" runat="server"></asp:TextBox>
                <br />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="advesoyadtxt" ErrorMessage="Boş Geçmeyelim :)" 
                    ForeColor="#0066FF" ValidationGroup="x">*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 600px">
                &nbsp;</td>
            <td style="width: 131px">
                <br />Dogum Tarihi :<br />
            </td>
            <td style="width: 256px">
                <br />&nbsp;
                <asp:TextBox ID="dogumtarihitxt" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/tarihbtn.png" 
                    onclick="ImageButton1_Click" Width="35px" />
                <asp:Calendar ID="Calendar1" runat="server" 
                    onselectionchanged="Calendar1_SelectionChanged" Visible="False">
                </asp:Calendar>
                <br />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                    ControlToValidate="dogumtarihitxt" ErrorMessage="Boş Geçmeyelim :)" 
                    ForeColor="#0066FF" ValidationGroup="x">*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 600px">
                &nbsp;</td>
            <td style="width: 131px">
                E-Posta : 
            </td>
            <td style="width: 256px">
                <asp:TextBox ID="emailtxt" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="emailtxt" ErrorMessage="Boş Geçmeyelim :)" 
                    ForeColor="#0066FF" ValidationGroup="x">*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 600px">
                &nbsp;</td>
            <td style="width: 131px">
                <br />Telefon Numarası :<br />
            </td>
            <td style="width: 256px">
                <br />
                <asp:TextBox ID="telnotxt" runat="server"></asp:TextBox>
                <br />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 600px">
                &nbsp;</td>
            <td style="width: 131px">
                <br />Cinsiyet :<br />
            </td>
            <td style="width: 256px">
                <br />
                <asp:RadioButton ID="bayrbn" runat="server" GroupName="cinsiyet" Text="Bay" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="bayanrbn" runat="server" GroupName="cinsiyet" 
                    Text="Bayan" />
                <br />
            </td>
            <td>
                <asp:CustomValidator ID="CustomValidator1" runat="server" 
                    ErrorMessage="Boş Geçmeyelim :)" ForeColor="#0066FF" 
                    onservervalidate="CustomValidator1_ServerValidate" ValidationGroup="x">*</asp:CustomValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 600px">
                &nbsp;</td>
            <td style="width: 131px">
                <br />Şehir :<br />
            </td>
            <td style="width: 256px">
                <br />
                <asp:DropDownList ID="sehirdl" runat="server">
                    <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                </asp:DropDownList>
                <br />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="sehirdl" ErrorMessage="RequiredFieldValidator" 
                    ForeColor="#0066FF" ValidationGroup="x">*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" colspan="6">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server"
                    Text="KAYDET" onclick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
        </tr>
        <tr>
            <td align="center" colspan="6">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="6">
                <hr />
            </td>
        </tr>
    </table>
</asp:Content>

