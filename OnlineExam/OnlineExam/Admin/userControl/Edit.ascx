<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Edit.ascx.cs" Inherits="OnlineExam.Admin.userControl.Edit" %>
<style type="text/css">
    .auto-style1 {
        width: 123px;
    }
    .auto-style4 {
        width: 108px;
    }
    .auto-style5 {
        width: 109px;
    }
    .auto-style6 {
        width: 343px;
    }
</style>

<table style="width:100%;">
    <tr>
        <td class="auto-style1">
            <asp:Label ID="lbl_course" runat="server" Text="Courses"></asp:Label>
        </td>
        <td colspan="2">
            <asp:DropDownList ID="ddl_course" runat="server" OnSelectedIndexChanged="ddl_course_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="lbl_Q" runat="server" Text="Questions"></asp:Label>
        </td>
        <td colspan="2">
            <asp:DropDownList ID="ddl_qByCourse" runat="server" Enabled="False" OnSelectedIndexChanged="ddl_qByCourse_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td colspan="2">
            <asp:Panel ID="pl_true" runat="server">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="lbl_head" runat="server" CssClass="col-md-2 control-label" Text="Question Head"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_tfHead" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="lbl_tftupe" runat="server" CssClass="col-md-2 control-label" Text="Type"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddl_tfType" runat="server" Enabled="False">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="lbl_model" runat="server" CssClass="col-md-2 control-label" Text="Model Answer"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddl_tfModel" runat="server" CssClass="form-control">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label2" runat="server" CssClass="col-md-2 control-label" Text="Grade"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_tfGrade" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_tfGrade" ErrorMessage="Grade Must Be Number" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Panel ID="pl_trueToMcq" runat="server">
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td colspan="2">
            <asp:Panel ID="pl_mcq" runat="server">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_head0" runat="server" CssClass="col-md-2 control-label" Text="Question Head"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_mcqHead" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_mcqtype" runat="server" CssClass="col-md-2 control-label" Text="Type"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddl_mcqType" runat="server" Enabled="False">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="Label4" runat="server" CssClass="col-md-2 control-label" Text="Grade"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_mcqGrade" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_mcqGrade" ErrorMessage="Grade Must be Number" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_A" runat="server" CssClass="col-md-2 control-label" Text="A"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_ansA" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_B" runat="server" CssClass="col-md-2 control-label" Text="B"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_ansB" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_C" runat="server" CssClass="col-md-2 control-label" Text="C"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_ansC" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_D" runat="server" CssClass="col-md-2 control-label" Text="D"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_ansD" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_model1" runat="server" CssClass="col-md-2 control-label" Text="Model Answer"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddl_mcqModel" runat="server" CssClass="form-control">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style6" colspan="2">
            <asp:Button ID="btn_update" runat="server" CssClass="btn btn-primary" Text="Update" Width="150px" OnClick="btn_update_Click" />
            <asp:Button ID="btn_delete" runat="server" OnClientClick="return confirm('Are you sure you want to delete this Instructor?');" CssClass="btn btn-danger" Text="Delete" Width="150px" OnClick="btn_delete_Click" />
        </td>
        <td colspan="2">
            <asp:Button ID="btn_cancel" runat="server" Text="Cancel" Width="150px" CssClass="btn btn-default" OnClick="btn_cancel_Click" />
            <asp:Label ID="lbl_status" runat="server"></asp:Label>
        </td>
    </tr>
</table>

