<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="projHerrons_Website.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <link href="../Styles/Admin.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content">
        <div id="updateUser">
            <h2>Update User</h2>
            <div id="findUser">
                
                <asp:Label ID="lblUpdateID" runat="server" Text="Enter ID: "></asp:Label>
                <asp:TextBox CssClass="marginBottom" ID="txtUpdateID" runat="server" TextMode="Number"></asp:TextBox>
                &nbsp;<asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" /><br />
            </div>
            <div id="foundNot">
                <asp:Label ID="lblUserFound" runat="server" Font-Bold="True" ForeColor="Red" Font-Size="Medium"></asp:Label>
            </div>
            <div id="details">
                First Name: <asp:TextBox CssClass="marginBottom" ID="txtUpdateFName" runat="server"></asp:TextBox><br />
                Last Name: <asp:TextBox CssClass="marginBottom" ID="txtUpdateLName" runat="server"></asp:TextBox><br />
                Email: <asp:TextBox CssClass="marginBottom" ID="txtUpdateEmail" runat="server" TextMode="Email"></asp:TextBox><br />
                Password: <asp:TextBox CssClass="marginBottom" ID="txtUpdatePassword" runat="server" TextMode="Password"></asp:TextBox><br />
                Status: <asp:TextBox ID="txtUpdateStatus" runat="server"></asp:TextBox><br /><br />
                <asp:Button ID="btnUpdateUser" runat="server" Text="Update Details" OnClick="btnUpdateUser_Click" />
                &nbsp;<asp:Button ID="btnDeleteUser" runat="server" Text="Delete User" OnClick="btnDeleteUser_Click" />
            </div>
        </div>
        <br />
        <br />
        <br />
        <div id="createProduct">
            <h2>Create Product</h2>
            <div id="detailsProductCreate">
                <div>
                Product Name: <asp:TextBox ID="txtCreateProductName" runat="server"></asp:TextBox><br />
                </div>
                <div>
                Product Description: <asp:TextBox ID="txtCreateProductDesc" runat="server"></asp:TextBox><br />
                </div>
                <div>
                Price: <asp:TextBox ID="txtCreateProductPrice" runat="server"></asp:TextBox><br />
                </div>
                <div>
                    <asp:Label ID="lblFileUploadCreate" runat="server" Text="Image: "></asp:Label>
                    <asp:FileUpload ID="fuCreateProductImage" runat="server" /><br />
                </div>
                <div>
                    <asp:Label ID="lblCreateCategory" runat="server" Text="Category: "></asp:Label>
                    <asp:TextBox ID="txtCreateProductCategory" runat="server"></asp:TextBox><br /><br />
                </div>
                <asp:Button ID="btnCreateProduct" runat="server" Text="Create Product" />
                
            </div>
        </div>
        <br />
        <br />
        <br />
        <div id="updateProduct">
            <h2>Update Product</h2>
            <div id="findProduct">
                
                <asp:Label ID="lblUpdateProductID" runat="server" Text="Enter Product ID: "></asp:Label>
                <asp:TextBox ID="txtUpdateProductID" runat="server" TextMode="Number"></asp:TextBox>
                &nbsp;<asp:Button ID="btnFindProductID" runat="server" Text="Find" /><br /><br />
            </div>
            <div id="foundNotProduct">
                <asp:Label ID="lblProductFound" runat="server"></asp:Label>
            </div>
            <div id="detailsProduct">
                Product Name: <asp:TextBox ID="txtDeleteProductName" runat="server"></asp:TextBox><br />
                Product Description: <asp:TextBox ID="txtDeleteProductDesc" runat="server"></asp:TextBox><br />
                Price: <asp:TextBox ID="txtDeleteProductPrice" runat="server" TextMode="Email"></asp:TextBox><br />
                Image: <asp:TextBox ID="txtDeleteProductImage" runat="server" TextMode="Password"></asp:TextBox><br />
                Category: <asp:TextBox ID="txtDeleteProductCategory" runat="server"></asp:TextBox><br /><br />
                <asp:Button ID="btnUpdateProduct" runat="server" Text="Update Product Information" />
                &nbsp;<asp:Button ID="btnDeleteProduct" runat="server" Text="Delete Product" />
            </div>
        </div>
        <br />
        <br />
        <br />
    </asp:Content>
