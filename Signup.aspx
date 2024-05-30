<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="Phase_1_project.Login_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign up</title>
      <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@500&display=swap" rel="stylesheet"/>
        <link href="Style.css" rel="stylesheet" type="text/css" />
        <link rel="icon" href="/images/f1_logo.png" type="image/png"/>

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 207px;
        }
        </style>

</head>
<body>
    <div class="logo-container">
        <img src="images/f1_Logo.png" alt="F1 Logo" class="f1-logo" />
    </div>
    <form id="form1" runat="server" class="form-background">
        <div>
            
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                     <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Show Passwords" onclick="togglePasswordVisibility();" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Text="Confirm password"></asp:Label>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label5" runat="server" Text="favourite team"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="MerchName" DataValueField="MerchName">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [MerchName] FROM [Merchi]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Height="50px" Text="Sign up" Width="377px" OnClick="Button1_Click" />
                        <table class="auto-style1">
                            <tr>
                                <td>
                                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            
        </div>
    </form>

     

    <script>
     function togglePasswordVisibility() {
            var passwordField = document.getElementById('<%= TextBox3.ClientID %>');
            var confirmPasswordField = document.getElementById('<%= TextBox4.ClientID %>');

            if (passwordField.type === 'password') {
                passwordField.type = 'text';
                confirmPasswordField.type = 'text';
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
