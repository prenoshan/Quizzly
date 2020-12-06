<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="QuizzlySite.html.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Login</title>

    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <link href="https://fonts.googleapis.com/css?family=Lato&display=swap" rel="stylesheet" />

    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="../css/bootstrap/bootstrap.min.css" />

    <link href="../css/loginStyles.css" rel="stylesheet" />

    <!-- jQuery library -->
    <script src="../js/bootstrap/jquery.min.js"></script>

    <!-- Popper JS -->
    <script src="../js/bootstrap/popper.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="../js/bootstrap/bootstrap.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">

        <asp:Panel runat="server" ID="errorOne">
            <br />
            <p class="error">All fields are required</p>
            <hr />
        </asp:Panel>

        <asp:Panel runat="server" ID="errorTwo">
            <br />
            <p class="error">Invalid credentials</p>
            <hr />
        </asp:Panel>

         <asp:Panel runat="server" ID="errorThree">
            <br />
            <p class="error">You are not logged in</p>
            <hr />
        </asp:Panel>

        <div class="d-md-flex h-md-100">

            <!-- First Half -->

            <div class="col-md-6 p-0 bg-indigo h-md-100 firstBanner">
                <div class="text-white d-md-flex h-100 p-5 text-center justify-content-center imageBackground">
                    <div class="logoarea pt-5 pb-5">
                        <img class="imageLogo" src="../data/logo.png" alt="Logo" />
                    </div>
                </div>
            </div>

            <!-- Second Half -->

            <div class="secondBanner col-md-6 p-0 bg-white h-md-100 loginarea">
                <div style="text-align: center;" class="d-md-flex h-md-100 p-5 justify-content-center">
                    <div class="loginContent container-fluid">
                        <h2>Welcome to Zengage</h2>
                        <br />
                        <asp:TextBox CssClass="form-control inputWidthFix" TextMode="SingleLine" placeholder="Enter your username" ID="txtUsername" runat="server"></asp:TextBox>

                        <br />

                        <asp:TextBox TextMode="Password" placeholder="Enter your password" CssClass="form-control inputWidthFix" ID="txtPassword" runat="server"></asp:TextBox>

                        <br />

                        <p>
                            <asp:Label runat="server" ID="lbUserType">Student</asp:Label>
                        </p>
                        <div class="material-toggle">
                            <input type="checkbox" id="toggle" name="toggle" checked="false" class="switch" runat="server" onclick="userType_Click();" />
                            <label for="toggle" class=""></label>
                        </div>

                        <br />
                        <br />

                        <script>

                            function userType_Click() {

                                if (document.getElementById("toggle").checked) {

                                    document.getElementById("lbUserType").innerText = "Lecturer";

                                }

                                else {

                                    document.getElementById("lbUserType").innerText = "Student";

                                }

                            }

                        </script>

                        <asp:Button CssClass="btnLogin btn" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />

                    </div>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
