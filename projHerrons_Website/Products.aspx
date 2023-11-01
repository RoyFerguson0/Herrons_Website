<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="projHerrons_Website.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <%#Eval("ProductName")%>
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.4/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>

    <%#Eval("ProductName")%>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

    <link href="Styles/Products.css" rel="stylesheet" />

    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div id="HomeContent">
    
    <h1>Products Available</h1>
    <br />
    Categories: <asp:LinkButton ID="lbnChips" runat="server" OnClick="lbnChips_Click">Chips</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="lbnAllProducts" runat="server" OnClick="lbnAllProducts_Click">View All Products</asp:LinkButton>
    <br />
    <br />
    
   
    <asp:ListView ID="lvProducts"  runat="server" DataSourceID="SqlDataSource1" OnItemCommand="lvProducts_ItemCommand">
        <ItemTemplate >
        
            <HeaderTemplate>
            </HeaderTemplate>
            <ItemTemplate >
                <div class="col-sm-4 product ">
                    
                    <asp:Image id="imgProducts" CssClass="imgProducts" runat="server" ImageUrl='<%#Eval("ProductImage")%>'/>
                    
                    <p><%#Eval("ProductName")%></p>
                
                    <p><%#Eval("ProductPrice")%></p>

                    <asp:Button ID="btnSelectedProduct" runat="server" Text="Button" CommandArgument='<%# Eval("ProductID")%>'/>
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
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [tblProducts] WHERE [ProductID] = ?" InsertCommand="INSERT INTO [tblProducts] ([ProductID], [ProductName], [ProductDescription], [ProductPrice], [ProductImage], [ProductCategory]) VALUES (?, ?, ?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [tblProducts]" UpdateCommand="UPDATE [tblProducts] SET [ProductName] = ?, [ProductDescription] = ?, [ProductPrice] = ?, [ProductImage] = ?, [ProductCategory] = ? WHERE [ProductID] = ?">
        <DeleteParameters>
            <asp:Parameter Name="ProductID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ProductID" Type="Int32" />
            <asp:Parameter Name="ProductName" Type="String" />
            <asp:Parameter Name="ProductDescription" Type="String" />
            <asp:Parameter Name="ProductPrice" Type="Decimal" />
            <asp:Parameter Name="ProductImage" Type="String" />
            <asp:Parameter Name="ProductCategory" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="ProductName" Type="String" />
            <asp:Parameter Name="ProductDescription" Type="String" />
            <asp:Parameter Name="ProductPrice" Type="Decimal" />
            <asp:Parameter Name="ProductImage" Type="String" />
            <asp:Parameter Name="ProductCategory" Type="String" />
            <asp:Parameter Name="ProductID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <br />
    <br />
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [tblProducts]"></asp:SqlDataSource>
    <br />
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [tblProducts] WHERE ([ProductCategory] = ?)">
        <SelectParameters>
            <asp:QueryStringParameter Name="ProductCategory" QueryStringField="cat" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <br />
    <br />
    <br />
    

    
    </div>

</asp:Content>
