<%@ Page Title="" Language="C#" MasterPageFile="~/QuizzlySiteStud.Master" AutoEventWireup="true" CodeBehind="ViewMarks.aspx.cs" Inherits="QuizzlySite.html.student.ViewMarks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../css/ViewMarkStyles.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h2 style="text-align: center;">View your marks</h2>
    <hr />
    <br />

    <div class="container-fluid" style="text-align: center;">

        <p class="labels">Select a test that you have taken below to view your marks for it</p>
        <br />

        <asp:DropDownList CssClass="form-control inputWidthFix" ID="ddlTestsTaken" runat="server"></asp:DropDownList>
        <br />
        <br />

        <asp:Button CssClass="btn btnCreateTest" ID="btnViewMemo" runat="server" Text="View Marks" OnClick="btnViewMemo_Click" />

        <br />
        <br />

        <h4><asp:Label ID="lbMark" runat="server"></asp:Label></h4>
        <h4><asp:Label ID="lbPercentage" runat="server"></asp:Label></h4>

    </div>

</asp:Content>
