﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="projHerrons_Website.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/Home.css" rel="stylesheet" />
    
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
    <title>Home</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div runat="server" id="HomeContent">
    <div id="introduction">
        <div id="textSizeChange">
            <asp:Label ID="lblGreeting" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
            Accessibility: 
            <asp:DropDownList ID="ddlAccessibility" runat="server">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>Standard</asp:ListItem>
                <asp:ListItem Value="#99CFE8">Light Blue</asp:ListItem>
                <asp:ListItem Value="#DB6F67">Light Red</asp:ListItem>
                <asp:ListItem Value="#F6E75F">Light Yellow</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btnSaveColour" runat="server" Text="Save" OnClick="btnSaveColour_Click"/>
        </div>
    </div>
    <div id="firstSlideShow">
      <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
          <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
          <li data-target="#myCarousel" data-slide-to="1"></li>
          <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>

        <!-- Wrapper for slides -->
        <div class="carousel-inner">

          <div class="item active">
            <img class="foodImages" src="Images/foodOne.jpg" alt="Los Angeles">
            <div class="carousel-caption">
              <h3>Burger</h3>
              <p>It's the way to go!</p>
            </div>
          </div>

          <div class="item">
            <img class="foodImages" src="Images/foodTwo.jpg" alt="Chicago">
            <div class="carousel-caption">
              <h3>Kebabs</h3>
              <p>Enjoy a Taste Kebab With Choice of Sause!</p>
            </div>
          </div>
    
          <div class="item">
            <img class="foodImages" src="Images/foodThree.jpg" alt="Food">
            <div class="carousel-caption">
              <h3>Meal</h3>
              <p>Get a Meal Deal cause your the real deal!</p>
            </div>
          </div>
  
        </div>

        <!-- Left and right controls -->
        <a class="left carousel-control" href="#myCarousel" data-slide="prev">
          <span class="glyphicon glyphicon-chevron-left"></span>
          <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#myCarousel" data-slide="next">
          <span class="glyphicon glyphicon-chevron-right"></span>
          <span class="sr-only">Next</span>
        </a>
      </div>
    </div>


    
    <div id="secondInfo">

        <h1>Herrons Country Fried Chicken,
        Northern Ireland's Local Takeaway</h1>
        <span style="color:red">Herrons CFC has been your preferred local fried chicken take-away since our first store opened
            in 1977 in Newcastle.
        </span>
    </div> 
</div>

    <%-- Second Option --%>
    <div id="ThreeOptions">
        <div class="optionsBorderWhiteSpace">
            </div>
        <%-- Third Option --%>
        <div class="optionsBorder">
            <div>
                <asp:Image class="OptionsImage" ID="imgProducts" runat="server" ImageUrl="~/Images/shopCounter.jpg" />
            </div>
            <div class="centerText">
                <span class="RedText">1.Products</span><br />
                To view all are available products.<br />
                <asp:Button CssClass="RedButton" ID="btnProducts" runat="server" Text="View Menu" OnClick="btnProducts_Click" />
            </div>
        </div>
        <div class="optionsBorderWhiteSpace">
            </div>
        <%-- Third Option --%>
        <div class="optionsBorder">
            <div>
                <asp:Image class="OptionsImage" ID="imgLogIn" runat="server" ImageUrl="~/Images/login.jpg" BackColor="#CCCCFF" />
            </div>
            <div class="centerText">
                <span class="RedText">2.Log In</span><br />
                To Log into your account.<br />
                <asp:Button CssClass="RedButton" ID="btnLogin" runat="server" Text="View Login" OnClick="btnLogin_Click" />
            </div>
        </div>
        <div class="optionsBorderWhiteSpace">
            </div>
        <%-- Third Option --%>
        <div class="optionsBorder marginbottom">
            <div>
                <asp:Image class="OptionsImage" ID="imgBasket" runat="server" ImageUrl="~/Images/basket.jpg" />
            </div>
            <div class="centerText">
                <span class="RedText">3.Basket</span><br />
                To view all the items you have added to basket.<br />
                <asp:Button CssClass="RedButton" ID="btnBasket" runat="server" Text="View Basket" OnClick="btnBasket_Click" />
            </div>
        </div>

    </div>


    

    
</asp:Content>
