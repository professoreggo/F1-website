<%@ Page Title="" Language="C#" MasterPageFile="~/merch.Master" AutoEventWireup="true" CodeBehind="managemembers.aspx.cs" Inherits="Phase_1_project.managemembers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    <asp:DropDownList ID="dd1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="MerchName" DataValueField="MerchName" Height="25px" Width="178px">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [MerchName] FROM [Merchi]"></asp:SqlDataSource>
</p>
<p>
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="MemberId" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="MemberId" HeaderText="MemberId" InsertVisible="False" ReadOnly="True" SortExpression="MemberId" />
            <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="favteam" HeaderText="favteam" SortExpression="favteam" />
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Members] WHERE [MemberId] = @original_MemberId AND [Username] = @original_Username AND [Email] = @original_Email AND [favteam] = @original_favteam" InsertCommand="INSERT INTO [Members] ([Username], [Email], [favteam]) VALUES (@Username, @Email, @favteam)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [MemberId], [Username], [Email], [favteam] FROM [Members] WHERE ([favteam] = @favteam)" UpdateCommand="UPDATE [Members] SET [Username] = @Username, [Email] = @Email, [favteam] = @favteam WHERE [MemberId] = @original_MemberId AND [Username] = @original_Username AND [Email] = @original_Email AND [favteam] = @original_favteam">
        <DeleteParameters>
            <asp:Parameter Name="original_MemberId" Type="Int32" />
            <asp:Parameter Name="original_Username" Type="String" />
            <asp:Parameter Name="original_Email" Type="String" />
            <asp:Parameter Name="original_favteam" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Username" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="favteam" Type="String" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="dd1" Name="favteam" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="Username" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="favteam" Type="String" />
            <asp:Parameter Name="original_MemberId" Type="Int32" />
            <asp:Parameter Name="original_Username" Type="String" />
            <asp:Parameter Name="original_Email" Type="String" />
            <asp:Parameter Name="original_favteam" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
    &nbsp;</p>
</asp:Content>
