<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="CustomerDeteail.aspx.cs" Inherits="MasterPagetech.CustomerDeteail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentWelocmePage" runat="server">
   <asp:Label ID="lblCustDetError" runat="server" />
    <h1>Customer Deteail</h1>
    Id:<asp:Label ID="LblId" runat="server" /><br />
    FirstName:<asp:Label ID="LblFirstName" runat="server" /><br />
    LastName:<asp:Label ID="LblLastName" runat="server" />
</asp:Content>
