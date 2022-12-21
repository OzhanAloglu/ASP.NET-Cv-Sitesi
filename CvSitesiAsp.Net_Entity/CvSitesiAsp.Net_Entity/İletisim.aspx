<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="İletisim.aspx.cs" Inherits="CvSitesiAsp.Net_Entity.İletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table table-bordered" style="margin-left: 20px; height: 167px;">
        <tr style="background-color: antiquewhite">
            <th>Adı Soyadı</th>
            <th>Konu</th>
            <th>Mail</th>
            <th>Mesaj</th>
            <th>Sil</th>



        </tr>

        <asp:Repeater ID="Repeater1" runat="server">

            <ItemTemplate>

                <tr>
                    <td><%#Eval("AdSoyad") %> </td>
                    <td><%#Eval("Konu") %> </td>
                    <td><%#Eval("Mail") %> </td>
                    <td>

                        <%--Hyperlink ile Mesaj Göster sayfasına gidip Eval komutu ile ID sini aldık ve diğer sayfada ID i Request.querystring["ID"] yaparak sayfalar arası taşıdık.--%>

                        <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-info" NavigateUrl='<%#("MesajGöster.aspx?ID=")+Eval("ID") %>'>Mesajı Göster</asp:HyperLink>


                    </td>

                    <td>

                        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-danger" NavigateUrl='<%#("İletisimSil.aspx?ID=")+Eval("ID") %>'>Sil</asp:HyperLink>



                    </td>


                </tr>


            </ItemTemplate>




        </asp:Repeater>









    </table>











</asp:Content>
