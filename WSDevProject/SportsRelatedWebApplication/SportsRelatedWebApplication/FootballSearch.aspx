<%@ Page Title="" Language="C#" MasterPageFile="~/Sports.Master" AutoEventWireup="true" CodeBehind="FootballSearch.aspx.cs" Inherits="SportsRelatedWebApplication.FootballSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server">
</asp:GridView>
    <asp:GridView ID="GridView2" runat="server">
    </asp:GridView>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:Button ID="BtnFixture" runat="server" Text="Fixtures" />
</asp:Content>
