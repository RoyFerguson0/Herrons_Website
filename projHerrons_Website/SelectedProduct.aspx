<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SelectedProduct.aspx.cs" Inherits="projHerrons_Website.SelectedProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="Styles/SelectedProduct.css" rel="stylesheet" />
    <title>Selected Product</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <div id="content">
        <div id="firstSection">
            <asp:Image ID="imgProductImage" runat="server" />
        </div>
        <div id="secondSection">
            <div id="headOne" class="headings">
                Name:
                <asp:Label ID="lblProductName" runat="server" Text="Label"></asp:Label>
            </div>
            <div id="headTwo" class="headings">
                Description:
                <asp:Label ID="lblProductDesc" runat="server" Text="Label"></asp:Label>
            </div>
            <div id="headThree" class="headings">
                Size:
                <asp:DropDownList ID="ddlSize" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSize_SelectedIndexChanged">
                    <asp:ListItem>Small</asp:ListItem>
                    <asp:ListItem Selected="True">Medium</asp:ListItem>
                    <asp:ListItem>Large</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div id="headFour" class="headings">
                £<asp:Label ID="lblProductPrice" runat="server"></asp:Label>
            </div>
            <div id="headFive" class="headings">
                <asp:Button ID="btnPurchase" runat="server" Text="Purchase" OnClick="btnPurchase_Click" />
            </div>
            
        </div>
















    </div>

        
        
    
   
    


</asp:Content>
