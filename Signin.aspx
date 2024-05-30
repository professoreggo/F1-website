<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signin.aspx.cs" Inherits="Phase_1_project.Signin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign in</title>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@500&display=swap" rel="stylesheet"/>
    <link href="Style.css" rel="stylesheet" type="text/css" />
    <link rel="icon" href="/images/f1_logo.png" type="image/png"/>

</head>
<body>
    <center>
    <form id="form1" runat="server" class="form-background">
      <div class="logo-container">
        <img src="images/f1_Logo.png" alt="F1 Logo" class="f1-logo" />
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    Username </td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    Password</td>
                <td class="auto-style4">
                      <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Show Password" onclick="togglePasswordVisibility();" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" Height="45px" Text="Login" Width="376px" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="msglbl2" runat="server"></asp:Label>
                </td>
                <td class="auto-style4"></td>
            </tr>
        </table>
    </form>
        </center>

   

    <script>
        function togglePasswordVisibility() {
            var passwordField = document.getElementById('<%= TextBox2.ClientID %>');
            
            if (passwordField.type === 'password') {
                passwordField.type = 'text';
                
            } else {
                passwordField.type = 'password';
                confirmPasswordField.type = 'password';
            }
        }

    </script>

    <div class="welcome-container">
</div>

</body>
</html>
