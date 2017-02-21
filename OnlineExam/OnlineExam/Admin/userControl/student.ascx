<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="student.ascx.cs" Inherits="WebApplication1.student" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 308px;
    }
    </style>

<table class="auto-style1">
    <tr>
        <td class="auto-style2">Select Student</td>
        <td>
            <asp:DropDownList ID="ddl_student" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True" CssClass="form-control">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbl" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">Student Id</td>
        <td>
            <asp:TextBox ID="txt_stdID" runat="server" Enabled="False" CssClass="form-control"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Username</td>
        <td>
            <asp:TextBox ID="txt_username" runat="server" CssClass="form-control"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Password</td>
        <td>
            <asp:TextBox ID="txt_password" runat="server" CssClass="form-control"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">First Name </td>
        <td>
            <asp:TextBox ID="txt_fname" runat="server" CssClass="form-control"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Last Name</td>
        <td>
            <asp:TextBox ID="txt_lname" runat="server" CssClass="form-control"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Department Id</td>
        <td>
            <asp:DropDownList ID="ddl_dept" runat="server" CssClass="form-control">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Active</td>
        <td>
            <asp:CheckBox ID="cb_active" runat="server" CssClass="form-control" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Button ID="btn_insert" runat="server" Text="Insert" OnClick="Insert_Click" CssClass="btn btn-primary" />
        </td>
        <td>
            <asp:Button ID="btn_update" runat="server" Text="Update" OnClick="Update_Click" CssClass="btn btn-primary" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Button ID="btn_delete" runat="server" OnClick="Delete_Click" Text="Delete" CssClass="btn btn-danger" />
        </td>
        <td>
            <asp:Button ID="btn_create" runat="server" OnClick="Create_Click" Text="Create New Student" CssClass="btn btn-default" />
        </td>
    </tr>
</table>

