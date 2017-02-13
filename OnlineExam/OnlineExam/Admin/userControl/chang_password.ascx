<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="chang_password.ascx.cs" Inherits="WebApplication1.Admin.Admin_UC.chang_password" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style6 {
        height: 23px;
    }
    .auto-style7 {
        width: 154px;
        height: 23px;
    }
    .auto-style8 {
        width: 154px;
    }
</style>

<table class="auto-style1">
    <tr>
        <td class="auto-style7">
            </td>
        <td class="auto-style7"></td>
        <td class="auto-style6"></td>
    </tr>
    <tr>
        <td class="auto-style8">
            &nbsp;</td>
        <td class="auto-style8">
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style8">
            <asp:Label ID="lbl_current" runat="server" AssociatedControlID="txt_currentPass" CssClass="col-md-2 control-label" Text="Current Password :" Width="200px"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_currentPass" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style8">
            <asp:Label ID="lbl_new" runat="server" AssociatedControlID="txt_newPass" CssClass="col-md-2 control-label" Text="New Password :" Width="200px"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_newPass" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style8">
            <asp:Label ID="lbl_confirm" runat="server" AssociatedControlID="txt_confirmPass" CssClass="col-md-2 control-label" Text="Confirm new password :" Width="200px"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_confirmPass" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txt_currentPass" ControlToValidate="txt_confirmPass" ErrorMessage="Not Matched"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style8">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style8">
            <asp:Button ID="btn_changPass" runat="server" OnClick="btn_changPass_Click" Text="Change Password" CssClass="btn btn-primary" />
        </td>
        <td>
            <asp:Label ID="lbl_status" runat="server" CssClass="col-md-2 control-label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style8">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>

