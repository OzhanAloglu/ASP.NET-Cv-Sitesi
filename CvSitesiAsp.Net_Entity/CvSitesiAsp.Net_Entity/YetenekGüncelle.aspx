<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="YetenekGüncelle.aspx.cs" Inherits="CvSitesiAsp.Net_Entity.YetenekGüncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div style="margin-left: 40px">
        <label>Yetenek Adı</label>
        <br />


        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>

        <br />
        <br />


        <label>Derecesi</label>
        <br />


        <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>

    </div>

    <div style="margin-top:30px" >

        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-success" style="margin-left:40px" OnClick="Button1_Click"  />

    </div>






</asp:Content>
