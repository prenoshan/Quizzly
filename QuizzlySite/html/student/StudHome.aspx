<%@ Page Title="" Language="C#" MasterPageFile="~/QuizzlySiteStud.Master" AutoEventWireup="true" CodeBehind="StudHome.aspx.cs" Inherits="QuizzlySite.html.student.StudHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="../../css/StudStyles.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" ID="errorOne">
        <br />
        <p class="error">You don't have access to that page</p>
        <hr />
    </asp:Panel>
    <div style="text-align: center;" class="container-fluid">

        <br />

        <h2>Welcome
            <asp:Label ID="lbName" runat="server"></asp:Label></h2>

        <br />

        <p class="labels">Use the buttons below to view memos and marks for the tests you have taken</p>

        <br />

        <asp:Button CssClass="btn btnCreateTest" ID="btnViewMarks" runat="server" Text="View Marks" OnClick="btnViewMarks_Click" />

        &nbsp;

        <asp:Button CssClass="btn btnCreateTest" ID="btnViewMemos" runat="server" Text="View Memos" OnClick="btnViewMemos_Click" />

        <br />
        <br />

    </div>

</asp:Content>
