<%@ Page Title="" Language="C#" MasterPageFile="~/QuizzlySiteLect.Master" AutoEventWireup="true" CodeBehind="CreateTestArea.aspx.cs" Inherits="QuizzlySite.html.lecturer.CreateTestArea" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../css/CreateTestAreaStyles.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel runat="server" ID="errorOne">
        <br />
        <p class="error">All fields are required</p>
        <hr />
    </asp:Panel>

    <asp:Panel runat="server" ID="errorTwo">
        <br />
        <p class="error">Please choose a correct answer</p>
        <hr />
    </asp:Panel>

    <asp:Panel ID="contentOne" runat="server">

        <br />

        <h2 style="text-align: center;">
            <asp:Label runat="server" ID="tbQuestionNum">Question 1 of 1</asp:Label></h2>

        <hr />
        <br />

        <div class="container-fluid" style="text-align: center;">

            <p class="labels">Enter Question</p>

            <asp:TextBox CssClass="form-control inputWidthFixTwo" TextMode="MultiLine" ID="tbQuestion" runat="server"></asp:TextBox>

            <br />

            <div class="input-group inputWidthFixTwo">
                <div class="input-group-prepend">
                    <div class="input-group-text">
                        <asp:RadioButton ID="rbAnsOne" runat="server" GroupName="CorrectAns" />
                    </div>
                </div>
                <asp:TextBox placeholder="Enter Answer One" CssClass="form-control inputWidthFix" ID="tbAnsOne" runat="server"></asp:TextBox>
            </div>

            <br />

            <div class="input-group inputWidthFixTwo">
                <div class="input-group-prepend">
                    <div class="input-group-text">
                        <asp:RadioButton ID="rbAnsTwo" runat="server" GroupName="CorrectAns" />
                    </div>
                </div>
                <asp:TextBox placeholder="Enter Answer Two" CssClass="form-control inputWidthFix" ID="tbAnsTwo" runat="server"></asp:TextBox>
            </div>

            <br />

            <div class="input-group inputWidthFixTwo">
                <div class="input-group-prepend">
                    <div class="input-group-text">
                        <asp:RadioButton ID="rbAnsThree" runat="server" GroupName="CorrectAns" />
                    </div>
                </div>
                <asp:TextBox placeholder="Enter Answer Three" CssClass="form-control inputWidthFix" ID="tbAnsThree" runat="server"></asp:TextBox>
            </div>

            <br />

            <div class="input-group inputWidthFixTwo">
                <div class="input-group-prepend">
                    <div class="input-group-text">
                        <asp:RadioButton ID="rbAnsFour" runat="server" GroupName="CorrectAns" />
                    </div>
                </div>
                <asp:TextBox placeholder="Enter Answer Four" CssClass="form-control inputWidthFix" ID="tbAnsFour" runat="server"></asp:TextBox>
            </div>

            <br />
            <br />

            <asp:Button CssClass="btn btnCreateTest" ID="btnAddQuestion" runat="server" Text="Next Question" OnClick="btnAddQuestion_Click" />

            <br />
            <br />
            <br />

        </div>

    </asp:Panel>

    <asp:Panel ID="contentTwo" runat="server">

        <div class="container-fluid centerSuccess" style="text-align: center;">

            <p class="success">Test has been set successfully</p>

            <p class="labels">Click below to set a new test</p>

            <asp:Button CssClass="btn btnCreateTest" ID="btnNewTest" runat="server" Text="Create New Test" OnClick="btnNewTest_Click" />

        </div>

    </asp:Panel>

</asp:Content>
