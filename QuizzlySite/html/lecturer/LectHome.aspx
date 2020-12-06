<%@ Page Title="" Language="C#" MasterPageFile="~/QuizzlySiteLect.Master" AutoEventWireup="true" CodeBehind="LectHome.aspx.cs" Inherits="QuizzlySite.html.lecturer.LectHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="../../css/LectStyles.css" rel="stylesheet" />

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel runat="server" ID="errorOne">
        <br />
        <p class="error">You don't have access to that page</p>
        <hr />
    </asp:Panel>

    <div style="text-align: center;" class="container-fluid">

        <br />

        <h2>Welcome <asp:label ID="lbName" runat="server"></asp:label></h2>

        <br />

        <asp:Button CssClass="btn btnCreateTest" ID="btnCreateTest" runat="server" Text="Create Test" OnClick="btnCreateTest_Click" />

        <br />
        <br />

    </div>

</asp:Content>
