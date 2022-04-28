<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="RegisterUsers.aspx.cs" Inherits="MasterPagetech.RegisterUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="FormValidation.js" type="text/javascript"></script>
    <link href="StyleSheet1.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentWelocmePage" runat="server">
    <asp:Label for="" ID="lblRegisterError" runat="server" class="form-label m-2"></asp:Label>

    <center>
        <h3 style="margin-top: 30px">SignUp here</h3>
    </center>
    <div class="container d-flex justify-content-center loginView">
        <div class="formView">
            <form id="form" runat="server" onsubmit="return validateform();">
                <div class="row">
                    <div class="col-4">
                        <asp:Label for="" ID="LblFname" runat="server" class="form-label m-2">First name</asp:Label>
                    </div>
                    <div class="col-8">
                        <asp:TextBox type="txt" class="form-control m-2" ID="TxtFname" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-4">
                        <asp:Label for="" ID="Lblname" runat="server" class="form-label m-2">last name</asp:Label>
                    </div>
                    <div class="col-8">
                        <asp:TextBox type="txt" class="form-control m-2" ID="TxtLname" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-4">
                        <asp:Label ID="lblEmail" runat="server" class="form-label m-2">Email</asp:Label>
                    </div>
                    <div class="col-8">
                        <asp:TextBox class="form-control m-2" ID="TxtEmail" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-4">
                        <asp:Label for="exampleInputPassword1" ID="LblPassword" runat="server" class="form-label m-2">Password</asp:Label>
                    </div>
                    <div class="col-8">
                        <asp:TextBox type="password" class="form-control m-2" ID="TxtPassword" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-4">
                        <asp:Label ID="LblConfirmPass" runat="server" class="form-label m-2"> Confirm Password</asp:Label>
                    </div>
                    <div class="col-8">
                        <asp:TextBox type="password" class="form-control m-2" ID="TxtConfirmPass" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-4">
                        <asp:Label for="" ID="LblGender" runat="server" class="form-label m-2">Gender</asp:Label>
                    </div>
                    <div class="col-8">
                        <asp:RadioButton ID="RdMale" runat="server" Text="Male" GroupName="gender" />
                        <asp:RadioButton ID="RdFemale" runat="server" Text="female" GroupName="gender" />
                    </div>
                </div>

                <asp:Button ID="BtnRegister" runat="server" class="btn btn-primary m-2" Text="Register" OnClick="BtnRegister_Click" />
                <a href="Login.aspx">
                    <asp:Label runat="server" class="btn btn-warning m-2" Text="Login" />
                </a>

            </form>
        </div>

    </div>
</asp:Content>

