<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SelectedProduct.aspx.cs" Inherits="projHerrons_Website.SelectedProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="Styles/SelectedProduct.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblProductID" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblProductName" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblProductDesc" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblProductPrice" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblProductCategory" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Image ID="imgProductImage" runat="server" />
    <br />
    <asp:DropDownList ID="ddlSize" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSize_SelectedIndexChanged">
        <asp:ListItem>Small</asp:ListItem>
        <asp:ListItem Selected="True">Medium</asp:ListItem>
        <asp:ListItem>Large</asp:ListItem>
</asp:DropDownList>
    <br />
    <br />
    <br />

    


</asp:Content>
