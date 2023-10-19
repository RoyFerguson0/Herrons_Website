<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="projHerrons_Website.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <%-- Links for the Bootstrap Cards --%>
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.4/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>

    <link href="Styles/Products.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 20px;
        }
        .auto-style2 {
            width: 100%;
            height: 178px;
            background-color: #FFFF99;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="card" style="width:400px">
        <img class="card-img-top" src="Images/foodOne.jpg" alt="Card image" style="width:100%">
        <div class="card-body">
          <h4 class="card-title">John Doe</h4>
          <p class="card-text">Some example text some example text. John Doe is an architect and engineer</p>
          <a href="#" class="btn btn-primary">See Profile</a>
        </div>
    </div>
    <div class="card" style="width:400px">
        <img class="card-img-top" src="Images/foodOne.jpg" alt="Card image" style="width:100%">
        <div class="card-body">
          <h4 class="card-title">John Doe</h4>
          <p class="card-text">Some example text some example text. John Doe is an architect and engineer</p>
          <a href="#" class="btn btn-primary">See Profile</a>
        </div>
    </div>
    <br />
    <br />
    Testing That the product and categories works<br />
    <br />
    Product Categories: <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Chips</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">View All Products</asp:LinkButton>
    <br />
    <br />
    <asp:DataList ID="DataList1" runat="server" DataKeyField="ProductID" DataSourceID="SqlDataSource1" Height="244px" RepeatDirection="Horizontal" Width="592px">
        <ItemTemplate>
            <table border="1" class="auto-style2">
                <tr>
                    <td class="auto-style1">Product ID:
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("ProductID") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Name:
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Description:
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("ProductDescription") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ProductImage") %>' />
                    </td>
                </tr>
                <tr>
                    <td>Price:
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("ProductPrice") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" />
                    </td>
                </tr>
            </table>
            <br />
        </ItemTemplate>
    </asp:DataList>
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [tblProducts]"></asp:SqlDataSource>
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
    <br />
    <br />
    

</asp:Content>
