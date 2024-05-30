<%@ Page Title="" Language="C#" MasterPageFile="~/merch.Master" AutoEventWireup="true" CodeBehind="buyMerchPage.aspx.cs" Inherits="Phase_1_project.buyMerchPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }
        .container {
            width: 80%;
            margin: 0 auto;
            background-color: #fff;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .auto-style1 {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }
        .auto-style1 th, .auto-style1 td {
            border: 1px solid #ddd;
            padding: 8px;
        }
        .auto-style1 th {
            background-color: #f2f2f2;
            text-align: center;
        }
        .auto-style1 td {
            text-align: center;
        }
        .auto-style1 tr:nth-child(even) {
            background-color: #f9f9f9;
        }
        .auto-style1 tr:hover {
            background-color: #f1f1f1;
        }
        .label {
            font-size: 18px;
            font-weight: bold;
        }
        .button {
            background-color:black;
            color: white;
            border: none;
            padding: 10px 20px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            margin: 4px 2px;
            cursor: pointer;
            border-radius: 4px;
        }
        .button:hover {
            background-color: black;
        }
        .center {
            text-align: center;
        }
        .total-items {
            font-size: 18px;
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/HtmlPage.html">Home</asp:HyperLink>
        </p>
        <table class="auto-style1">
            <tr>
                <th>Product</th>
                <th>Action</th>
                <th colspan="2"></th>
            </tr>
            <tr>
                <td><asp:Label ID="Label4" runat="server" Text="Alpine:" CssClass="label"></asp:Label></td>
                <td><asp:Button ID="Button1" runat="server" Text="Buy" OnClick="Button1_Click" CssClass="button" /></td>
                <td colspan="2"></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label5" runat="server" Text="Aston-Martin:" CssClass="label"></asp:Label></td>
                <td><asp:Button ID="Button2" runat="server" Text="Buy" OnClick="Button2_Click" CssClass="button" /></td>
                <td colspan="2"></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label6" runat="server" Text="Mercedes:" CssClass="label"></asp:Label></td>
                <td><asp:Button ID="Button3" runat="server" Text="Buy" OnClick="Button3_Click" CssClass="button" /></td>
                <td colspan="2"></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label7" runat="server" Text="Haas:" CssClass="label"></asp:Label></td>
                <td><asp:Button ID="Button4" runat="server" Text="Buy" OnClick="Button4_Click" CssClass="button" /></td>
                <td colspan="2"></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label8" runat="server" Text="Stake:" CssClass="label"></asp:Label></td>
                <td><asp:Button ID="Button5" runat="server" Text="Buy" OnClick="Button5_Click" CssClass="button" /></td>
                <td colspan="2"></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label9" runat="server" Text="McLaren:" CssClass="label"></asp:Label></td>
                <td><asp:Button ID="Button6" runat="server" Text="Buy" OnClick="Button6_Click" CssClass="button" /></td>
                <td colspan="2"></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label10" runat="server" Text="Red Bull:" CssClass="label"></asp:Label></td>
                <td><asp:Button ID="Button7" runat="server" Text="Buy" OnClick="Button7_Click" CssClass="button" /></td>
                <td colspan="2"></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label11" runat="server" Text="Ferrari:" CssClass="label"></asp:Label></td>
                <td><asp:Button ID="Button8" runat="server" Text="Buy" OnClick="Button8_Click" CssClass="button" /></td>
                <td colspan="2"></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label12" runat="server" Text="Williams:" CssClass="label"></asp:Label></td>
                <td><asp:Button ID="Button9" runat="server" Text="Buy" OnClick="Button9_Click" CssClass="button" /></td>
                <td colspan="2"></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label3" runat="server" Text="Red Bull Visa:" CssClass="label"></asp:Label></td>
                <td><asp:Button ID="Button10" runat="server" Text="Buy" OnClick="Button10_Click" CssClass="button" /></td>
                <td colspan="2"></td>
            </tr>
        </table>
        <p class="center total-items">
            <asp:Label ID="Label14" runat="server" Text="Total Items:"></asp:Label>
            <asp:Label ID="Label15" runat="server"></asp:Label>
            <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="Check Out" CssClass="button" />
        </p>
    </div>
</asp:Content>
