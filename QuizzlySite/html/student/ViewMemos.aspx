<%@ Page Title="" Language="C#" MasterPageFile="~/QuizzlySiteStud.Master" AutoEventWireup="true" CodeBehind="ViewMemos.aspx.cs" Inherits="QuizzlySite.html.student.ViewMemos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="../../css/ViewMemoStyles.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid" style="text-align: center;">

        <br />

        <h2 style="text-align: center;">View Memos</h2>
        <hr />
        <br />
        <p class="labels">Select a test that you have taken below to view its memo</p>
        <br />
        <asp:DropDownList CssClass="form-control inputWidthFix" ID="ddlTestsTaken" runat="server"></asp:DropDownList>
        <br />
        <br />

        <asp:Button CssClass="btn btnCreateTest" ID="btnViewMemo" runat="server" Text="View Memo" OnClick="btnViewMemo_Click" />

        <br />
        <br />

    </div>

    <br />

    <asp:GridView CssClass="table table-bordered gvMemos" HorizontalAlign="Center" ID="gvMemos" runat="server">

        <EmptyDataTemplate>
            <p class="labels">No memos available for current test</p>
        </EmptyDataTemplate>

    </asp:GridView>

</asp:Content>
