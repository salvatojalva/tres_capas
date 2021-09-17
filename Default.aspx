<%@ Page Title="Login" Language="C#" MasterPageFile="~/Auth.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-sm mt-4">
        <div class="row mt-4">
            <div class="col-md-4"></div>

            <div class="col-md-4 mt-4">
                <div class="card text-center mt-4">

                    <div class="card-body mt-4">

                        <div class="row mt-4" style="padding-top: 120px;">

                            <div class="form-group">
                                <label for="exampleInputEmail1">Email address</label>
                                <input type="text" class="form-control" id="userInput" aria-describedby="emailHelp" placeholder="Ingrese su usuario" runat="server">
                                <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
                            </div>
                            <div class="form-group">
                                <label for="exampleInputPassword1">Password</label>
                                <input type="password" class="form-control" id="passwordInput" placeholder="Password" runat="server">
                            </div>


                            <button OnClientClick="login()" id="Button1" runat="server" class="btn btn-primary">Submit</button>
                        </div>
                    </div>
                </div>
                <asp:Label ID="msg" runat="server" Text=""></asp:Label>
            </div>

            <div class="col-md-4"></div>
        </div>
    </div>
</asp:Content>
