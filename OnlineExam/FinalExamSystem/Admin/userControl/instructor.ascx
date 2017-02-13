<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="instructor.ascx.cs" Inherits="WebApplication1.instructor" %>
<style type="text/css">
    .auto-style1 {
        height: 34px;
        width: 194px;
    }
    .auto-style6 {
        width: 194px;
    }
    .auto-style7 {
        width: 74px;
    }
    .auto-style8 {
        height: 34px;
        width: 74px;
    }
    .auto-style9 {
        width: 300px;
    }
    .auto-style10 {
        height: 34px;
        width: 300px;
    }
    .auto-style11 {
        width: 127px;
    }
    .auto-style12 {
        width: 87px;
    }
</style>
<table style="width:100%;">
    <tr>
        <td class="auto-style7">Select Instructor</td>
        <td class="auto-style9" colspan="2">
            <asp:DropDownList ID="ddl_selectInst" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_selectInst_SelectedIndexChanged" CssClass="form-control">
            </asp:DropDownList>
        </td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style8">
            <asp:Label ID="lbl_insID" runat="server" AssociatedControlID="txt_instId" Text="Instructor_ID" CssClass="col-md-2 control-label"></asp:Label>
        </td>
        <td class="auto-style10" colspan="2">
            <asp:TextBox ID="txt_instId" runat="server" Enabled="False" CssClass="form-control" Width="200px"></asp:TextBox>
        </td>
        <td class="auto-style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
    <tr>
        <td class="auto-style7">&nbsp;<asp:Label ID="lbl_insuser" runat="server" AssociatedControlID="txt_userName" Text="Username" CssClass="col-md-2 control-label"></asp:Label>
        </td>
        <td class="auto-style9" colspan="2">
            <asp:TextBox ID="txt_userName" runat="server" CssClass="form-control" Width="200px" style="margin-left: 0px"></asp:TextBox>
        </td>
        <td class="auto-style6">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="lbl_inspass" runat="server" AssociatedControlID="txt_password" Text="Password" CssClass="col-md-2 control-label"></asp:Label>
        </td>
        <td class="auto-style9" colspan="2">
            <asp:TextBox ID="txt_password" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
        </td>
        <td class="auto-style6">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="lbl_insname" runat="server" AssociatedControlID="txt_InsName" Text="Instructor_Name" CssClass="col-md-2 control-label"></asp:Label>
        </td>
        <td class="auto-style9" colspan="2">
            <asp:TextBox ID="txt_InsName" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
        </td>
        <td class="auto-style6">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="lbl_insdegree" runat="server" AssociatedControlID="txt_InsDegree" Text="Instructor_Degree" CssClass="col-md-2 control-label"></asp:Label>
        </td>
        <td class="auto-style9" colspan="2">
            <asp:TextBox ID="txt_InsDegree" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
        </td>
        <td class="auto-style6">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="lbl_inssalary" runat="server" AssociatedControlID="txt_InsSalary" Text="Instructor_Salary" CssClass="col-md-2 control-label"></asp:Label>
        </td>
        <td class="auto-style9" colspan="2">
            <asp:TextBox ID="txt_InsSalary" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
        </td>
        <td class="auto-style6">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="lbl_insdepart" runat="server" AssociatedControlID="ddl_Dept" Text="Department" CssClass="col-md-2 control-label"></asp:Label>
        </td>
        <td class="auto-style9" colspan="2">
            <asp:DropDownList ID="ddl_Dept" runat="server" CssClass="form-control">
            </asp:DropDownList>
        </td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="lbl_insActive" runat="server" AssociatedControlID="cb_active" Text="Active" CssClass="col-md-2 control-label"></asp:Label>
        </td>
        <td class="auto-style9" colspan="2">
            <asp:CheckBox ID="cb_active" runat="server" CssClass="form-control" />
        </td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Button ID="btn_InsertIns" runat="server" Text="Insert" OnClick="btn_InsertIns_Click" CssClass="btn btn-primary" Width="150px" />
        </td>
        <td class="auto-style11">
            <asp:Button ID="btn_Update" runat="server" Text="Update" OnClick="btn_Update_Click" CssClass="btn btn-primary" Width="150px" Height="29px" />
        </td>
        <td class="auto-style12">
            <asp:Button ID="btn_Delete" runat="server" Text="Delete" OnClick="btn_Delete_Click" OnClientClick="return confirm('Are you sure you want to delete this Instructor?');" CssClass="btn btn-danger" Width="150px" />
        </td>
        <td class="auto-style6">
            <asp:Button ID="btn_NewINs" runat="server" Text="New Instructor" OnClick="btn_NewINs_Click" CssClass="btn btn-default" Width="150px" />
        </td>
    </tr>
    <tr>
        <td class="auto-style7">&nbsp;</td>
        <td class="auto-style9" colspan="2">
            <asp:Label ID="lbl_status" runat="server"></asp:Label>
        </td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
</table>

