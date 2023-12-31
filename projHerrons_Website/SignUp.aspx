﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="projHerrons_Website.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="Styles/SignUp.css" rel="stylesheet" />

    <title>Sign Up</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="Testing">
        <section class="vh-100 bg-image"
          style="background-image: url('https://mdbcdn.b-cdn.net/img/Photos/new-templates/search-box/img4.webp');">
          <div id="changeStyle" class="mask d-flex align-items-center h-100 gradient-custom-3">
            <div class="container h-100">
              <div class="row d-flex justify-content-center align-items-center h-100">
                <div class="col-12 col-md-9 col-lg-7 col-xl-6">
                  <div class="card" style="border-radius: 15px;">
                    <div class="card-body p-5">
                      <h2 id="changeFont" class="text-uppercase text-center mb-5">Create an account</h2>



                        <div class="form-outline mb-4">
                            <label class="form-label" for="form3Example1cg">First Name</label>
                            <asp:TextBox  ID="txtFirstName" class="form-control form-control-lg" runat="server"></asp:TextBox>
                          
                        </div>

                        <div class="form-outline mb-4">
                            <label class="form-label" for="form3Example1cg">Last Name</label>
                            <asp:TextBox ID="txtLastName" class="form-control form-control-lg" runat="server"></asp:TextBox>
                          
                        </div>

                        <div class="form-outline mb-4">
                            <label class="form-label" for="form3Example3cg">Your Email</label>
                            <asp:TextBox ID="txtEmail" class="form-control form-control-lg" runat="server" TextMode="Email"></asp:TextBox>
                          
                        </div>

                        <div class="form-outline mb-4">
                            <label class="form-label" for="form3Example4cg">Password</label>
                            <asp:textbox id="txtPassword" class="form-control form-control-lg" runat="server" TextMode="Password"></asp:textBox>
                          
                        </div>

                        <div class="form-outline mb-4">
                            <label class="form-label" for="form3Example4cdg">Repeat your password</label>
                            <asp:textbox id="txtPasswordRepeat" class="form-control form-control-lg" runat="server" TextMode="Password"></asp:textBox>
                          
                        </div>

                        <div class="form-check d-flex justify-content-center mb-5">
                            <asp:CheckBox ID="chkTerms" class="form-check-input me-2" runat="server" />
                          <label class="form-check-label" for="form2Example3g">
                            I agree all statements in <a href="#!" class="text-body"><u>Terms of service</u></a>
                          </label>
                        </div>

                        <div class="d-flex justify-content-center">
                            <asp:Button ID="btnSignUp" class="btn btn-success btn-block btn-lg gradient-custom-4 text-body" runat="server" Text="Sign Up" OnClick="btnSignUp_Click" />
                        </div>

                        <p class="text-center text-muted mt-5 mb-0">Have already an account? <a href="Login.aspx"
                            class="fw-bold text-body"><u>Login here</u></a></p>
                       

                        <div id="output">
                        <asp:Label ID="lblOuput" runat="server" Text=""></asp:Label>
                            </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </section>

    </div>

    


</asp:Content>
