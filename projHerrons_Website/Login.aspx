﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="projHerrons_Website.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="Styles/Login.css" type="text/css" rel="stylesheet" />

    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="backgroundImg">
        <div id="loginLogo">
            <asp:Image ID="imgLoginLogo" runat="server" ImageUrl="~/Images/loginLogo.jpg" />
        </div>
        <div id="username">
            <asp:Label CssClass="boxes" Width="20%"  ID="lblUsername" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox CssClass="boxes" ID="txtUsername" runat="server"></asp:TextBox>
        </div>
        <div id="password">
            <asp:Label CssClass="boxes" Width="20%" ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox CssClass="boxes" ID="txtPassword" runat="server"></asp:TextBox>
        </div>
        <div id="RememberMe">
            <asp:CheckBox CssClass="boxes" Width="20%" ID="chkRememberMe" runat="server" Text="Remember Me" />
        </div>
        <div id="loginButton">
            <asp:Button  CssClass="boxes" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </div>
</asp:Content>
