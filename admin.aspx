<%@ Page Title="" Language="C#" MasterPageFile="~/merch.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="Phase_1_project.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body {
            font-family: Arial, sans-serif;
        }
        .container {
            width: 80%;
            margin: auto;
            padding: 20px;
            background-color: #f9f9f9;
            box-shadow: 0px 0px 10px rgba(0,0,0,0.1);
            border-radius: 8px;
        }
        .header {
            text-align: center;
            margin-bottom: 20px;
        }
        .header h1 {
            font-size: 2em;
            font-weight: bold;
            color: #333;
        }
        table {
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 20px;
        }
        table th, table td {
            padding: 10px;
            text-align: center;
            border: 1px solid #ddd;
        }
        table th {
            background-color: #f2f2f2;
            font-weight: bold;
        }
        table tr:nth-child(even) {
            background-color: #f9f9f9;
        }
        .center {
            text-align: center;
        }
        .stock-input {
            width: 50px;
            text-align: center;
        }
        .btn {
            padding: 5px 10px;
            background-color: black;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        .btn:hover {
            background-color: #45a049;
        }
        .label-counter {
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="header">
            <h1>Admin Page</h1>
        </div>
        <table>
            <tr>
                <th>Merch Type</th>
                <th>Current Stock</th>
                <th>Stock To Add</th>
                <th>Action</th>
            </tr>
            <tr>
                <td><asp:Label ID="Label3" runat="server" Text="Alpine Merch Counter:"></asp:Label></td>
                <td><asp:Label ID="Label24" runat="server" CssClass="label-counter"></asp:Label></td>
                <td><asp:TextBox ID="TextBox1" runat="server" CssClass="stock-input"></asp:TextBox></td>
                <td><asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" CssClass="btn" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label4" runat="server" Text="Aston-Martin Merch Counter:"></asp:Label></td>
                <td><asp:Label ID="Label15" runat="server" CssClass="label-counter"></asp:Label></td>
                <td><asp:TextBox ID="TextBox2" runat="server" CssClass="stock-input"></asp:TextBox></td>
                <td><asp:Button ID="Button2" runat="server" Text="Add" OnClick="Button2_Click" CssClass="btn" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label5" runat="server" Text="Ferrari Merch Counter:"></asp:Label></td>
                <td><asp:Label ID="Label16" runat="server" CssClass="label-counter"></asp:Label></td>
                <td><asp:TextBox ID="TextBox3" runat="server" CssClass="stock-input"></asp:TextBox></td>
                <td><asp:Button ID="Button3" runat="server" Text="Add" OnClick="Button3_Click" CssClass="btn" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label6" runat="server" Text="Haas Merch Counter:"></asp:Label></td>
                <td><asp:Label ID="Label17" runat="server" CssClass="label-counter"></asp:Label></td>
                <td><asp:TextBox ID="TextBox4" runat="server" CssClass="stock-input"></asp:TextBox></td>
                <td><asp:Button ID="Button4" runat="server" Text="Add" OnClick="Button4_Click" CssClass="btn" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label7" runat="server" Text="McLaren Merch Counter:"></asp:Label></td>
                <td><asp:Label ID="Label18" runat="server" CssClass="label-counter"></asp:Label></td>
                <td><asp:TextBox ID="TextBox5" runat="server" CssClass="stock-input"></asp:TextBox></td>
                <td><asp:Button ID="Button5" runat="server" Text="Add" OnClick="Button5_Click" CssClass="btn" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label8" runat="server" Text="Mercedes Merch Counter:"></asp:Label></td>
                <td><asp:Label ID="Label19" runat="server" CssClass="label-counter"></asp:Label></td>
                <td><asp:TextBox ID="TextBox6" runat="server" CssClass="stock-input"></asp:TextBox></td>
                <td><asp:Button ID="Button6" runat="server" Text="Add" OnClick="Button6_Click" CssClass="btn" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label9" runat="server" Text="RedBullVisa Merch Counter:"></asp:Label></td>
                <td><asp:Label ID="Label20" runat="server" CssClass="label-counter"></asp:Label></td>
                <td><asp:TextBox ID="TextBox7" runat="server" CssClass="stock-input"></asp:TextBox></td>
                <td><asp:Button ID="Button7" runat="server" Text="Add" OnClick="Button7_Click" CssClass="btn" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label10" runat="server" Text="RedBull Merch Counter:"></asp:Label></td>
                <td><asp:Label ID="Label21" runat="server" CssClass="label-counter"></asp:Label></td>
                <td><asp:TextBox ID="TextBox8" runat="server" CssClass="stock-input"></asp:TextBox></td>
                <td><asp:Button ID="Button8" runat="server" Text="Add" OnClick="Button8_Click" CssClass="btn" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label11" runat="server" Text="Stake Merch Counter:"></asp:Label></td>
                <td><asp:Label ID="Label22" runat="server" CssClass="label-counter"></asp:Label></td>
                <td><asp:TextBox ID="TextBox9" runat="server" CssClass="stock-input"></asp:TextBox></td>
                <td><asp:Button ID="Button9" runat="server" Text="Add" OnClick="Button9_Click" CssClass="btn" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label12" runat="server" Text="Williams Merch Counter:"></asp:Label></td>
                <td><asp:Label ID="Label23" runat="server" CssClass="label-counter"></asp:Label></td>
                <td><asp:TextBox ID="TextBox10" runat="server" CssClass="stock-input"></asp:TextBox></td>
                <td><asp:Button ID="Button10" runat="server" Text="Add" OnClick="Button10_Click" CssClass="btn" /></td>
            </tr>
        </table>
    </div>
</asp:Content>
