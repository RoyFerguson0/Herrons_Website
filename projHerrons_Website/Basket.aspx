<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Basket.aspx.cs" Inherits="projHerrons_Website.Basket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/Basket.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="homeContent">
        <p>
            <asp:Label ID="lblOrderSummary" runat="server"></asp:Label>
        </p>
        <div id="tabIN">
            <asp:Panel ID="pnlOrders" runat="server">
            </asp:Panel>
        </div>
        <p>
            <asp:Label ID="lblTotalCost" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnClear" runat="server"  Text="Clear Basket" OnClick="btnClear_Click" OnClientClick="return areyousure()" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnPurchase" runat="server" Text="Purchase Items" OnClick="btnPurchase_Click" OnClientClick="return areyousurePurchase()" />
            <br />
        </p>
    </div>
    
</asp:Content>
