<%@ Page Title="" Language="C#" MasterPageFile="~/aspNetWebsite/Sports.Master" AutoEventWireup="true" CodeBehind="RunClac.aspx.cs" Inherits="SportsRelatedWebApplication.RunClac" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            margin-top: 6px;
        }
        .auto-style9 {
            width: 225px;
        }
        .auto-style10 {
            width: 92px;
        }
        .auto-style11 {
            width: 114px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style10">
                <asp:Label ID="Label1" runat="server" Text="Distance:"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtDist" runat="server" Width="195px"></asp:TextBox>
            </td>
            <td class="auto-style11">
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click1" Text="Calculate" />
            </td>
            <td>
                <asp:Label ID="lblDist" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Label ID="Label2" runat="server" Text="Time:"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtTime" runat="server" CssClass="auto-style8" Width="194px"></asp:TextBox>
            </td>
            <td class="auto-style11">
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Calculate" />
            </td>
            <td>
                <asp:Label ID="lblTime" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Label ID="Label3" runat="server" Text="Pace:"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtPace" runat="server" Width="193px"></asp:TextBox>
            </td>
            <td class="auto-style11">
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Calculate" />
            </td>
            <td>
                <asp:Label ID="lblPace" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
