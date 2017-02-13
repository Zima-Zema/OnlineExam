<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GenerateExam.ascx.cs" Inherits="WebApplication1.Admin.Admin_UC.GenerateExam" %>
<style type="text/css">
    .auto-style1 {
        height: 30px;
    }
</style>
<asp:Panel ID="Panel1" runat="server">
    <table style="width: 670px;">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="lbl_mcq" runat="server" Text="Number Of MCQ"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="ddl_mcq" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>Select Course ID</td>
            <td>
                <asp:DropDownList ID="ddl_courseId" runat="server" OnSelectedIndexChanged="ddl_courseId_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:Label ID="lbl_status" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:Button ID="btn_GenerateExam" runat="server" OnClick="btn_GenerateExam_Click" Text="Generate Exam" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Panel>
<asp:Panel ID="Panel2" runat="server" Visible="False">
    Select Student To Assign for exam&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddl_selectStn" runat="server" OnSelectedIndexChanged="ddl_selectStn_SelectedIndexChanged">
    </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btn_assign" runat="server" OnClick="btn_assign_Click" Text="Assign" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lbl_assStatus" runat="server"></asp:Label>
</asp:Panel>

