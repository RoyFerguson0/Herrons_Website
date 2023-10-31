<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="projHerrons_Website.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="Styles/SignUp.css" rel="stylesheet" />


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="CenterText">
        <h1 id="heading">CREATE AN ACCOUNT</h1>
        <%-- First Name --%>
        <div class="center" id="FirstName">
            <div class="floatingR">
            <asp:Label  ID="lblFirstName" runat="server" Text="First Name:"></asp:Label>
            </div>
            <div class="floatingL">
            <asp:TextBox  ID="txtFirstName" runat="server"></asp:TextBox>
            </div>
        </div>
        <%-- Last Name --%>
        <div class="center" id="LastName">
            <div class="floatingR"> 
            <asp:Label ID="lblLastName" runat="server" Text="Last Name:"></asp:Label>
            </div>
            <div class="floatingL">
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            </div>
        </div>
        <%-- Email --%>
        <div class="center" id="Email">
            <div class="floatingR">
            <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
            </div>
            <div class="floatingL">
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </div>
        </div>
        <%-- Password --%>
        <div class="center" id="Password">
            <div class="floatingR">
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:label>
            </div>
            <div class="floatingL">
            <asp:textbox id="txtPassword" runat="server"></asp:textBox>
            </div>
        </div>
        <%-- Button - SignUP --%>
        <div class="center" id="SignUp">
            <asp:Button ID="btnSignUp" runat="server" Text="Sign Up" OnClick="btnSignUp_Click" />
        </div>
        <div class="center">
            <asp:Label ID="lblOuput" runat="server" Text="Label"></asp:Label>
        </div>
    </div>

    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br />

    <div id="Testing">
        <section class="vh-100 bg-image"
          style="background-image: url('https://mdbcdn.b-cdn.net/img/Photos/new-templates/search-box/img4.webp');">
          <div class="mask d-flex align-items-center h-100 gradient-custom-3">
            <div class="container h-100">
              <div class="row d-flex justify-content-center align-items-center h-100">
                <div class="col-12 col-md-9 col-lg-7 col-xl-6">
                  <div class="card" style="border-radius: 15px;">
                    <div class="card-body p-5">
                      <h2 class="text-uppercase text-center mb-5">Create an account</h2>

                      <form>

                        <div class="form-outline mb-4">
                          <input type="text" id="form3Example1cg" class="form-control form-control-lg" />
                          <label class="form-label" for="form3Example1cg">First Name</label>
                        </div>

                        <div class="form-outline mb-4">
                          <input type="text" id="form3Example1cdg" class="form-control form-control-lg" />
                          <label class="form-label" for="form3Example1cg">Last Name</label>
                        </div>

                        <div class="form-outline mb-4">
                          <input type="email" id="form3Example3cg" class="form-control form-control-lg" />
                          <label class="form-label" for="form3Example3cg">Your Email</label>
                        </div>

                        <div class="form-outline mb-4">
                          <input type="password" id="form3Example4cg" class="form-control form-control-lg" />
                          <label class="form-label" for="form3Example4cg">Password</label>
                        </div>

                        <div class="form-outline mb-4">
                          <input type="password" id="form3Example4cdg" class="form-control form-control-lg" />
                          <label class="form-label" for="form3Example4cdg">Repeat your password</label>
                        </div>

                        <div class="form-check d-flex justify-content-center mb-5">
                          <input class="form-check-input me-2" type="checkbox" value="" id="form2Example3cg" />
                          <label class="form-check-label" for="form2Example3g">
                            I agree all statements in <a href="#!" class="text-body"><u>Terms of service</u></a>
                          </label>
                        </div>

                        <div class="d-flex justify-content-center">
                          <button type="button"
                            class="btn btn-success btn-block btn-lg gradient-custom-4 text-body">Register</button>
                        </div>

                        <p class="text-center text-muted mt-5 mb-0">Have already an account? <a href="#!"
                            class="fw-bold text-body"><u>Login here</u></a></p>

                      </form>

                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </section>
    </div>




</asp:Content>
