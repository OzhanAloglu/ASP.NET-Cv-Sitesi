<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Yeteneklerim.aspx.cs" Inherits="CvSitesiAsp.Net_Entity.Hakkımda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table class="table table-bordered" style="margin-left: 20px; margin-right: 20px">
        <tr>
            <th>ID</th>
            <th>YETENEK</th>
            <th>Derece</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>

        <asp:Repeater ID="Repeater1" runat="server">

            <ItemTemplate>

                <tr>
                    <td><%#Eval("ID") %></td>
                    <td><%#Eval("Yetenek")%></td>
                    <td><%#Eval("Derece")%></td>
                    <td> 
                       <%-- Burada hyperlink ile eval kullanarak soru işareti ile ıd bilgisini diğer sayfaya taşıyoruz--%>
                        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-danger" NavigateUrl='<%#"YetenekSil.aspx?ID="+ Eval("ID") %>'>Sil</asp:HyperLink>
                    </td>

                    <td>

                        <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-warning" NavigateUrl='<%#"YetenekGüncelle.aspx?ID="+Eval("ID") %>'>Güncelle  </asp:HyperLink>

                    </td>
                </tr>

            </ItemTemplate>

        </asp:Repeater>


    </table>
    <br />

    <div>

        <a href="YetenekEkle.aspx" class="btn btn-success" style="margin-left: 20px">Yetenek Ekle  </a>

    </div>
















</asp:Content>
