<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="MasterPagetech.Customers" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentWelocmePage" runat="server">
    <asp:Label ID="lblCustomerError" runat="server"></asp:Label>
    <form id="form1" runat="server">
        <div class="container-fluid m-3">
            <div class="row">
                <div class="col-8">
                    <h3 class="Gridtitel">Customers</h3>
                </div>
                <div class="col-2">
                    <asp:TextBox ID="TxtSerch" class="form-control mr-sm-2" runat="server"></asp:TextBox>
                </div>
                <div class="col-2">
                    <asp:Button ID="BtnSerch" class="btn btn-outline-success my-2 my-sm-0" runat="server" Text="Serch" OnClick="BtnSerch_Click" />
                    <asp:Button ID="btnClear" class="btn btn-outline-success my-2 my-sm-0" runat="server" Text="Clear" OnClick="BtnClear_Click"/>
                </div>
            </div>
        </div>
        <div class="container d-flex justify-content-center custmerList">
            <asp:GridView ID="GridView1" runat="server" class="table table-bordered table-condensed table-responsive table-hover" 
                AllowPaging="true" OnPageIndexChanging="PageIndexChange" PageSize="4" >
            </asp:GridView>
            <asp:GridView ID="GridView2" runat="server" class="table table-bordered table-condensed table-responsive table-hover"
                OnRowDataBound="OnRowDataBound" OnSelectedIndexChanged="OnSelectedIndexChanged">
            </asp:GridView>
        </div>
    </form>
</asp:Content>


