<%@ Page Title="" Language="C#" MasterPageFile="~/merch.Master" AutoEventWireup="true" CodeBehind="adminhome.aspx.cs" Inherits="Phase_1_project.adminhome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f0f0;
            margin: 0;
            padding: 0;
        }
        .container {
            width: 80%;
            margin: 20px auto;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
        }
        .links {
            text-align: center;
            margin-bottom: 20px;
        }
        .links a {
            padding: 10px 20px;
            background-color:black;
            color: #fff;
            text-decoration: none;
            border-radius: 5px;
            margin: 0 10px;
        }
        .links a:hover {
            background-color:darkgray;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="links">
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/admin.aspx">Manage Merch</asp:HyperLink>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/managemembers.aspx">Manage Members</asp:HyperLink>
        </div>
    </div>
</asp:Content>
