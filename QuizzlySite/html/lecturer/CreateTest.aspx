<%@ Page Title="" Language="C#" MasterPageFile="~/QuizzlySiteLect.Master" AutoEventWireup="true" CodeBehind="CreateTest.aspx.cs" Inherits="QuizzlySite.html.lecturer.CreateTest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../css/CreateTestStyles.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel runat="server" ID="errorOne">
        <br />
        <p class="error">All fields are required</p>
        <hr />
    </asp:Panel>

    <asp:Panel runat="server" ID="errorTwo">
        <br />
        <p class="error">Number of questions must be a valid number</p>
        <hr />
    </asp:Panel>

    <asp:Panel runat="server" ID="errorThree">
        <br />
        <p class="error">Test name you have specified already exists</p>
        <hr />
    </asp:Panel>

      <asp:Panel runat="server" ID="errorFour">
        <br />
        <p class="error">Invalid Request</p>
        <hr />
    </asp:Panel>

    <br />

    <h2 style="text-align: center;">Use the form below to create a test</h2>

    <hr />
    <br />

    <div style="text-align: center;" class="container-fluid">

        <p class="labels">Enter the test name below</p>
        <asp:TextBox CssClass="form-control inputWidthFix" TextMode="SingleLine" ID="tbTestName" runat="server"></asp:TextBox>

        <br />
        <br />

        <p class="labels">Choose a test category below</p>
        <asp:DropDownList CssClass="form-control inputWidthFix" ID="ddlTestCat" runat="server"></asp:DropDownList>

        <br />
        <br />

        <p class="labels">Enter the number of questions for the test</p>
        <asp:TextBox value="0" min="0" max="50" CssClass="form-control inputWidthFix" TextMode="Number" ID="tbQNumbers" runat="server"></asp:TextBox>

        <br />
        <br />

        <asp:Button CssClass="btn btnCreateTest" ID="btnTestCreate" runat="server" Text="Create Test" OnClick="btnTestCreate_Click" />

        <br />
        <br />
        <br />

    </div>
</asp:Content>
