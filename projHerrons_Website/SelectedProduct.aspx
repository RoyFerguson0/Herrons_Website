<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SelectedProduct.aspx.cs" Inherits="projHerrons_Website.SelectedProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="Styles/SelectedProduct.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Image ID="Image1" runat="server" />
    <br />
    <br />
    <br />
    <asp:ListView ID="lvProduct"  runat="server" DataSourceID="SqlDataSource1">
        <ItemTemplate >
        
            <HeaderTemplate>
            </HeaderTemplate>
            <ItemTemplate >
                <div class="col-sm-4 product ">
                    
                    <asp:Image id="imgProducts" CssClass="imgProducts" runat="server" ImageUrl='<%#Eval("ProductImage")%>'/>

                    
                    <p><%#Eval("ProductName")%></p>
                
                    <p><%#Eval("ProductPrice")%></p>

                    <asp:Button ID="btnSelectedProduct" runat="server" Text="Button" CommandArgument='<%# Eval("ProductID")%>' CommandName="addtocart" />
                </div>
            </ItemTemplate>
            <FooterTemplate>
            </FooterTemplate>
           
            </ItemTemplate>
        
    </asp:ListView>
    <br />
    <br />
    <br />
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [tblProducts] WHERE ([ProductID] = ?)">
        <SelectParameters>
            <asp:QueryStringParameter Name="ProductID" QueryStringField="id" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <br />

    


</asp:Content>
