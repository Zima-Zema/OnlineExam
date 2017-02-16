<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="adminprofile.ascx.cs" Inherits="WebApplication1.Admin.Admin_UC.adminprofile" %>
<%@ Register src="chang_password.ascx" tagname="chang_password" tagprefix="uc1" %>
<style type="text/css">
    .auto-style1 {
        width: 258px;
    }
    .auto-style7 {
        width: 50%;
    }
    .auto-style8 {
        width: 132px;
    }
</style>

<asp:Panel ID="pl_show" runat="server">
    <table style="width: 670px;">
        <tr>
            <td class="auto-style7">UserName</td>
            <td class="auto-style8">
                <asp:Label ID="lbl_username" runat="server" Text="Label" CssClass="col-md-2 control-label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">First Name</td>
            <td class="auto-style8">
                <asp:Label ID="lbl_fname" runat="server" Text="Label" CssClass="col-md-2 control-label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Last Name</td>
            <td class="auto-style8">
                <asp:Label ID="lbl_lname" runat="server" Text="Label" CssClass="col-md-2 control-label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Salary</td>
            <td class="auto-style8">
                <asp:Label ID="lbl_salary" runat="server" Text="Label" CssClass="col-md-2 control-label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Enter Date</td>
            <td class="auto-style8">
                <asp:Label ID="lbl_enterdate" runat="server" Text="Label" CssClass="col-md-2 control-label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Button ID="btn_chPass" runat="server" CssClass="btn btn-primary" OnClick="btn_chPass_Click" Text="Change Password" />
            </td>
            <td class="auto-style8">
                <asp:Label ID="lbl_status" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Panel>
<asp:Panel ID="pl_change" runat="server" Visible="False">
    <uc1:chang_password ID="chang_password1" runat="server" />
</asp:Panel>


