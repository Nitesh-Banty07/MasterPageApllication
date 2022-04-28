<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MasterPagetech.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentWelocmePage" runat="server">
    <asp:Label for="" ID="lblLoginError" runat="server" class="form-label m-2"></asp:Label>

    <center><h3 class="topTitle">logIn here</h3></center>
    <div class="container d-flex justify-content-center loginView">
        <div class="formView">
            <form id="form" runat="server">
                <div class="row">
                    <div class="col-4">
                        <asp:Label for="exampleInputEmail1" ID="LblEmail" runat="server" class="form-label m-2">Email</asp:Label>
                    </div>
                    <div class="col-8">
                        <asp:TextBox type="email" class="form-control m-2" ID="TxtEmail" runat="server" ></asp:TextBox>
              
                    </div>
                </div>
                 <div class="row">
                    <div class="col-4">
                        <asp:Label for="exampleInputPassword1" ID="LblPass" runat="server" class="form-label m-2">Password</asp:Label>
                    </div>
                    <div class="col-8">
                        <asp:TextBox type="password" class="form-control m-2" ID="TxtPassword" runat="server" ></asp:TextBox>
                        <asp:Label ID="LblMassege" runat="server" class="form-label m-2"></asp:Label>
                    </div>
                </div>
                <asp:Button ID="Btnlogin" runat="server" class="btn btn-primary m-2" Text="Login" BorderStyle="Solid"  OnClick="UserAuth"/>  
                <a href="RegisterUsers.aspx" class="form-label m-2">Register here</a>
                <asp:Button ID="Btnrestore" runat="server" class="btn btn-danger m-2" Text="Restore" OnClick="BtnRestore_Click"/>                  
            </form>
        </div>
       
    </div>
     
</asp:Content>
