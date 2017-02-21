<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Topic_UC.ascx.cs" Inherits="WebApplication1.Admin.Topic_UC" %>
<style type="text/css">
    .auto-style1 {
        width: 211px;
    }
    .auto-style2 {
        width: 93px;
    }
</style>
<table style="width:100%;">
    <tr>
        <td class="auto-style2">Select Topic&nbsp;&nbsp;</td>
        <td class="auto-style1">
            <asp:DropDownList ID="ddl_topics" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_topics_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Topic_ID</td>
        <td class="auto-style1">
            <asp:TextBox ID="txt_TopicId" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Topic_Name</td>
        <td class="auto-style1">
            <asp:TextBox ID="txt_TopicName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_TopicName" ErrorMessage="*"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Button ID="btn_InsertTopic" runat="server" Text="Insert" OnClick="btn_InsertTopic_Click" Width="100px" />
        </td>
        <td class="auto-style1">
            <asp:Button ID="btn_update" runat="server" Text="Update" OnClick="btn_update_Click" Width="100px" />
            <asp:Button ID="btn_Delete" runat="server" Text="Delete" OnClick="btn_Delete_Click" Width="100px" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Button ID="btn_NewTopic" runat="server" Text="New Topic" OnClientClick="return confirm('Warning!!!! Are you sure you want to delete this Topic and All Its Courses?');" OnClick="btn_NewTopic_Click" Width="100px" />
        </td>
        <td class="auto-style1">
            <asp:Label ID="lbl_status" runat="server"></asp:Label>
        </td>
    </tr>
    </table>


