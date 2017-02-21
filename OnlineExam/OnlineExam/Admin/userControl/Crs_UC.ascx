<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Crs_UC.ascx.cs" Inherits="WebApplication1.Admin.Crs_UC" %>


<style type="text/css">

    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 164px;
    }
    .auto-style3 {
        width: 305px;
    }
    .auto-style4 {
        width: 131px;
    }
    .auto-style6 {
        width: 164px;
        height: 32px;
    }
    .auto-style7 {
        width: 305px;
        height: 32px;
    }
    .auto-style8 {
        width: 131px;
        height: 32px;
    }
    .auto-style10 {
        height: 32px;
    }
</style>

<table class="auto-style1">
    <tr>
        <td class="auto-style2">Select Course</td>
        <td class="auto-style3">
            <asp:DropDownList ID="ddl_selectCourse" runat="server" OnSelectedIndexChanged="ddl_selectCourse_SelectedIndexChanged" AutoPostBack="True" CssClass="form-control">
            </asp:DropDownList>
            </td>
        <td class="auto-style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lbl_id" runat="server" AssociatedControlID="txt_Cid" CssClass="col-md-2 control-label" Text="Course_ID"></asp:Label>
        </td>
        <td class="auto-style3">
            <asp:TextBox ID="txt_Cid" runat="server" Enabled="False" CssClass="form-control" Width="150px"></asp:TextBox>
        </td>
        <td class="auto-style4">
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lbl_name" runat="server" AssociatedControlID="txt_Cname" CssClass="col-md-2 control-label" Text="Course_Name"></asp:Label>
        </td>
        <td class="auto-style3">
            <asp:TextBox ID="txt_Cname" runat="server" CssClass="form-control" Width="150px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_Cname" ErrorMessage="*"></asp:RequiredFieldValidator>
        </td>
        <td class="auto-style4">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lbl_dura" runat="server" AssociatedControlID="txt_Cduration" CssClass="col-md-2 control-label" Text="Course_Duration"></asp:Label>
        </td>
        <td class="auto-style3">
            <asp:TextBox ID="txt_Cduration" runat="server" CssClass="form-control" Width="150px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Only Numbers" ValidationExpression="\d+" ControlToValidate="txt_Cduration"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_Cduration" ErrorMessage="*"></asp:RequiredFieldValidator>
        </td>
        <td class="auto-style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style6">
            <asp:Label ID="lbl_top" runat="server" AssociatedControlID="ddl_topic" CssClass="col-md-2 control-label" Text="Topic"></asp:Label>
        </td>
        <td class="auto-style7">
            <asp:DropDownList ID="ddl_topic" runat="server" CssClass="form-control">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddl_topic" ErrorMessage="*"></asp:RequiredFieldValidator>
        </td>
        <td class="auto-style8"></td>
        <td class="auto-style10"></td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Button ID="btn_insert" runat="server" OnClick="btn_insert_Click" Text="Insert" Width="150px" />
        </td>
        <td class="auto-style3">
            <asp:Button ID="btn_Update" runat="server" OnClick="btn_Update_Click" Text="Update" Width="150px" />
            <asp:Button ID="btn_delete" runat="server" Text="Delete" Width="150px" OnClientClick="return confirm('Are you sure you want to delete this Course?');" OnClick="btn_delete_Click" />
        </td>
        <td class="auto-style4">
            <asp:Button ID="btn_Newcourse" runat="server" OnClick="btn_Newcourse_Click" Text="New Course" Width="150px" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            &nbsp;</td>
        <td class="auto-style3">
            <asp:Label ID="lbl_status" runat="server"></asp:Label>
        </td>
        <td class="auto-style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">
            &nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>



